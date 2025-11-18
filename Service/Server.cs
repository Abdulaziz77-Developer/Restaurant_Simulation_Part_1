using Restaurant_Simulation_Part_1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1.Service
{
    public class Server
    {
        private object locker = new();
        private SemaphoreSlim cookSemaphore;
        private List<Cook> cooks;
        private List<TableRequest> pendingOrders = new();
        private List<string> results = new();

        private int nextCookIndex = 0; // для циклического назначения повара

        public Server()
        {
            cooks = new List<Cook> { new Cook(), new Cook() };
            cookSemaphore = new SemaphoreSlim(cooks.Count);
        }

        public void NewRequest(string name, int countChicken, int countEgg, string drinkName = "No Drink")
        {
            var table = new TableRequest();
            lock (locker)
            {
                for (int i = 0; i < countEgg; i++)
                    table.Add<Egg>(name);
                for (int i = 0; i < countChicken; i++)
                    table.Add<ChickenOrder>(name);
                table.Add<Drink>(name, drinkName);

                pendingOrders.Add(table);
            }
        }

        public async Task SendOrdersToCookAsync()
        {
            List<Task> cookTasks = new();

            foreach (var table in pendingOrders.ToList())
            {
                await cookSemaphore.WaitAsync();

                // закрепляем за заказом конкретного повара циклично
                Cook assignedCook;
                lock (locker)
                {
                    assignedCook = cooks[nextCookIndex];
                    nextCookIndex = (nextCookIndex + 1) % cooks.Count;
                }

                var task = Task.Run(async () =>
                {
                    try
                    {
                        await assignedCook.ProcessAsync(table);

                        lock (locker)
                        {
                            foreach (var customer in table)
                            {
                                int eggs = table[customer].Count(i => i is Egg);
                                int chicken = table[customer].Count(i => i is ChickenOrder);
                                string drink = table[customer].OfType<Drink>().FirstOrDefault()?.Name ?? "No Drink";

                                // имитация сервировки
                                Task.Delay(2000).Wait();

                                results.Add($"Cook {assignedCook.Id} served {customer}: Eggs {eggs}, Chicken {chicken}, Drink {drink}");
                            }
                        }
                    }
                    finally
                    {
                        cookSemaphore.Release();
                    }
                });

                cookTasks.Add(task);
            }

            await Task.WhenAll(cookTasks);
            pendingOrders.Clear();
        }

        // Сортировка по имени клиента перед возвратом
        public List<string> Serve()
        {
            lock (locker)
            {
                var res = results
                    .OrderBy(r => r.Split("served ")[1].Split(':')[0])
                    .ToList();

                results.Clear();
                return res;
            }
        }

        public List<string> Results => results;
    }
}

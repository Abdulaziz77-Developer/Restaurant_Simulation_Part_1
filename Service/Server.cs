using Restaurant_Simulation_Part_1.Models;

namespace Restaurant_Simulation_Part_1.Service
{
    public class Server
    {
        private object locker = new object();
        public TableRequest table = new TableRequest();
        public Action<TableRequest>? ServerDelegate;
        public Cook cook = new Cook();
        private SemaphoreSlim semaphore = new SemaphoreSlim(2);
        private Cook cook2 = new Cook();
        List<string> result = new List<string>();
        public void NewRequest(string name, int countEgg, int countChicken, string drink = "No Drink")
        {
            lock (locker)
            {
                for (int i = 0; i < countEgg; i++)
                {
                    table.Add<Egg>(name);
                }
                for (int i = 0; i < countChicken; i++)
                {
                    table.Add<ChickenOrder>(name);
                }
                table.Add<Drink>(name, drink);
                result = new();
            }
        }
        public Server()
        {
           
        }
        public void SendOrdersToCook()
        {
                try
                {
                            Task.Run(async () =>
                            {  
                                await semaphore.WaitAsync();
                                cook.Process(table);
                                semaphore.Release();
                            }).ContinueWith(task => Serve()).Wait();
                            Task.Run(async () =>
                            {  await semaphore.WaitAsync();
                                cook2.Process(table);
                               semaphore.Release();
                            }).ContinueWith(task => Serve()).Wait();
                            
                }
                catch (Exception ex )
                {
                    throw new Exception(ex.Message);
                }

        }

        public List<string> Serve()
        {
            lock (locker)
            {
                int counterChicken = 0;
                int countEgg = 0;
                string? drinkName = "";
                foreach (var name in table)
                {
                    var items = table[name];
                    foreach (var item in items)
                    {
                        if (item is Egg)
                        {
                            countEgg++;
                        }
                        else if (item is Drink)
                        {
                            drinkName = item.ToString();
                        }
                        else
                        {
                            counterChicken++;
                        }
                    }
                    result.Add($"{name} : CountEgg {countEgg} | CountChicken {counterChicken} Drink {drinkName}");
                    countEgg = 0;
                    counterChicken = 0;
                    drinkName = string.Empty;
                }
                table = new TableRequest();
                return result;
            }
        }
    }
}

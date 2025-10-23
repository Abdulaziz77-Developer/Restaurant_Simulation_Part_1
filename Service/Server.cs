using Restaurant_Simulation_Part_1.Models;
using Restaurant_Simulation_Part_1.Models.Drinks;
using static Restaurant_Simulation_Part_1.Service.TableRequest;

namespace Restaurant_Simulation_Part_1.Service
{
    public class Server
    {
        public Server()
        {
            
        }
        public void Receive(TableRequest table)
        {
            table.Add(0, new ChickenOrder(5));
            table.Add(0, new Egg(5));
            table.Add(0, new Drink("Tea"));

            table.Add(1, new ChickenOrder(2));
            table.Add(1, new Drink("Coca Cola"));

            table.Add(2, new Egg(7));
            table.Add(2, new Egg(6));
        }

        public void Send(Cook cook, TableRequest table)
        {
            cook.Process(table);
        }

        public void Serve(TableRequest table)
        {
            for (int c = 0; c < 3; c++)
            {
                var items = table[c];
                Console.Write($"Customer {c} is served ");
                int chicken = 0, egg = 0;
                string drink = "no drink";

                foreach (var item in items)
                {
                    if (item is ChickenOrder) chicken++;
                    else if (item is Egg) egg++;
                    else if (item is Drink) drink = $"{(Drink)item}";
                }

                Console.WriteLine($"{chicken} chicken, {egg} egg, {drink}");
            }

            Console.WriteLine("Please enjoy your food!");
        }
    }
}

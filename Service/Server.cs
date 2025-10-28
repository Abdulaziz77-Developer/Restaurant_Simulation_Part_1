using Restaurant_Simulation_Part_1.Models;
using static Restaurant_Simulation_Part_1.Service.TableRequest;

namespace Restaurant_Simulation_Part_1.Service
{
    public class Server
    {
        private TableRequest table = new TableRequest();
        private int currentCliet = 0;
        private Cook cook = new Cook();
        private string[]? results = new string[] { };
        string  drinkName = "";
        public void NewRequest(int amountChicken, int amountEgg, string drinkName)
        {
            if (amountChicken < 0 || amountEgg < 0 || string.IsNullOrEmpty(drinkName))
            {
                throw new ArgumentException("Invalid order parameters.");
            }
            for(int i = 0; i < amountChicken; i++)
            {
                table.Add(currentCliet, new ChickenOrder());
            }
            for (int j = 0; j < amountEgg; j++)
            {
                table.Add(currentCliet, new Egg());
            }
            Drink drink = new Drink(drinkName);
            table.Add(currentCliet, drink);
            currentCliet++;
        }
        public void Send()
        { 
           
            cook.Process(table);
        }

        public string[] Serve()
        {
            int countEgg = 0;
            int countChicken = 0;

            for (int k = 0; k < table.GetCountCustomer(); k++)
            { 
                for (int j = 0; j < table[k].Length; j++)
                {
                    var items = table[k];
                    foreach (var item in items)
                    {
                        if (item is Egg)
                        {
                            countEgg++;
                        }
                        else if(item is Drink)
                        {
                            drinkName = ((Drink)item).Name;
                        }
                        else
                        {
                            countChicken++;
                        }
                        
                    }
                    Array.Resize(ref results, k + 1);
                    results[k] = $"Customer {k + 1} served with {countChicken} Chicken(s) and {countEgg} Egg(s)  Drink {drinkName}";
                    break;
                }
                drinkName = "";
                countChicken = 0;
                countEgg = 0;

            }
            table = new TableRequest();
            drinkName = string.Empty;
            currentCliet = 0;
            return results;
        }
    }
}

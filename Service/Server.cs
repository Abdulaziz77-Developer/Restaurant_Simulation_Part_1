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
        string[]? drinks = new string[] { }; 
        public void NewRequest(int amountChicken, int amountEgg, string drinkName)
        {
            if (amountChicken < 0 || amountEgg < 0 || string.IsNullOrEmpty(drinkName))
            {
                throw new ArgumentException("Invalid order parameters.");
            }
            for(int i = 0; i < amountChicken; i++)
            {
                table.Add(currentCliet, new ChickenOrder(1));
            }
            for (int j = 0; j < amountEgg; j++)
            {
                table.Add(currentCliet, new Egg(1));
            }
            if (drinks.Length <= currentCliet)
            {
                Array.Resize(ref drinks, currentCliet + 1);
            }
            drinks[currentCliet] = drinkName;
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
            int i = 0;
            
            while (table[i] != null)
            {
                if (table[i] == null)
                {
                    break;
                }
                for (int j = 0; j < table[i].Length; j++)
                {
                    var items = table[i];
                    foreach (var item in items)
                    {
                        if (item is Egg)
                        {
                            countEgg++;
                        }
                        else
                        {
                            countChicken++;
                        }
                    }
                    Array.Resize(ref results, i + 1);
                    results[i] = $"Customer {i + 1} served with {countChicken} Chicken(s) and {countEgg} Egg(s)  Drink {drinks[i]}";
                    break;
                }
                i++;
            }
            table = new TableRequest();
            drinks = new string[] { };
            currentCliet = 0;
            return results;
        }
    }
}

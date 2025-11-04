using Restaurant_Simulation_Part_1.Models;

namespace Restaurant_Simulation_Part_1.Service
{
    public class Server
    {
        public TableRequest table = new TableRequest();
        public Action<TableRequest>? ServerDelegate;
        public Cook cook = new Cook();
        List<string> result = new List<string>();
        private List<string> names = new List<string>();
        public void NewRequest(string name, int countEgg, int countChicken, string drink = "No Drink")
        {
            for (int i = 0; i < countEgg; i++)
            {
                table.Add<Egg>(name);
            }
            for (int i = 0; i < countChicken; i++)
            {
                table.Add<ChickenOrder>(name);
            }
            table.Add<Drink>(name,drink);
            names.Add(name);
            result = new();
        }
        public void SendOrdersToCook()
        {
            ServerDelegate += cook.Process;
            ServerDelegate?.Invoke(table);
            cook.CookDelegate += Serve;
        }

        public List<string> Serve()
        {
            int counterChicken = 0;
            int countEgg = 0;
            string? drinkName ="";
            foreach (var name in names)
            {
                var items = table[name];
                foreach (var item in items)
                {
                    if (item is Egg)
                    {
                        countEgg++;
                    }
                    else if(item is Drink)
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
            names = new();
            return result;
        }

       
    }
}

using Restaurant_Simulation_Part_1.Models;
//using static Restaurant_Simulation_Part_1.Service.TableRequest;

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
            //Drink drink1 = new Drink(drink);
            //table.Add<Drink>(drink1.Name);
            names.Add(name);
        }
        public void SendOrdersToCook()
        {
            ServerDelegate += cook.Process;
            ServerDelegate?.Invoke(table);
            cook.CookDelegate = Serve;
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
            return result;
        }

        #region OldCode 
        //private TableRequest table = new TableRequest();
        //private int currentCliet = 0;
        //public event Action<TableRequest> Mydelegate;
        //private Cook cook = new Cook();
        //List<string> names = new List<string>();
        //private string[]? results = new string[] { };
        //string drinkName = "";
        //public void NewRequest(int amountChicken, int amountEgg, string drinkName)
        //{
        //    if (amountChicken < 0 || amountEgg < 0 || string.IsNullOrEmpty(drinkName))
        //    {
        //        throw new ArgumentException("Invalid order parameters.");
        //    }
        //    for (int i = 0; i < amountChicken; i++)
        //    {
        //        //table.Add(currentCliet, new ChickenOrder());
        //        table.Add<ChickenOrder>("John");
        //    }
        //    for (int j = 0; j < amountEgg; j++)
        //    {
        //        //table.Add(currentCliet, new Egg());
        //        table.Add<Egg>("John");
        //    }
        //    Drink drink = new Drink(drinkName);
        //    table.Add<Drink>("John");
        //    //table.Add(currentCliet, drink);
        //    //currentCliet++//;

        //}
        //public void Send()
        //{
        //    Mydelegate += cook.Process;            
        //    Mydelegate?.Invoke(table);
        //    cook.Notify += Serve;
        //}

        //public string[] Serve()
        //{
        //    int countEgg = 0;
        //    int countChicken = 0;

        //    for (int k = 0; k < table.GetCountCustomer(); k++)
        //    {
        //        for (int j = 0; j < table[k].Length; j++)
        //        {
        //            var items = table[k];
        //            foreach (var item in items)
        //            {
        //                if (item is Egg)
        //                {
        //                    countEgg++;
        //                }
        //                else if (item is Drink)
        //                {
        //                    drinkName = ((Drink)item).Name;
        //                }
        //                else
        //                {
        //                    countChicken++;
        //                }

        //            }
        //            Array.Resize(ref results, k + 1);
        //            results[k] = $"Customer {k + 1} served with {countChicken} Chicken(s) and {countEgg} Egg(s)  Drink {drinkName}";
        //            break;
        //        }
        //        drinkName = "";
        //        countChicken = 0;
        //        countEgg = 0;

        //    }
        //    table = new TableRequest();
        //    drinkName = string.Empty;
        //    currentCliet = 0;
        //    return results;
        //}
        #endregion
    }
}

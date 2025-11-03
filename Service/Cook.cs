using Restaurant_Simulation_Part_1.Interfaces;
using Restaurant_Simulation_Part_1.Models;
using System.Security.Cryptography;
using static Restaurant_Simulation_Part_1.Service.TableRequest;

namespace Restaurant_Simulation_Part_1.Service
{
    public class Cook
    {
        public delegate List<string> ServerDelegate();
        public ServerDelegate? CookDelegate;
        public TableRequest table = new TableRequest();
        public Server server = new Server();
        public void Process(TableRequest table)
        {
            if (table == null)
            {
                throw new ArgumentNullException("Table is not be null ");
            }
            var items = table.Get<ChickenOrder>();
            foreach (var item in items)
            {
                item.CutUp();
                item.Cook();
            }
            var eggs = table.Get<Egg>();
            foreach (var egg in eggs)
            {
                using (egg)
                {
                    egg.Crack();
                    egg.Cook();
                }
            }
            CookDelegate?.Invoke();
            #region
            //public Server server = new Server();
            //public delegate string[] CookHandler();
            //public event  CookHandler Notify;
            //public void Process(TableRequest table)
            //{

            //    //var chickens = table[new CookedFood()];
            //    //foreach (var item in chickens)
            //    //{
            //    //    if (item is Egg e)
            //    //    {
            //    //        using (e)
            //    //        {
            //    //            e.Crack();
            //    //        }
            //    //    }
            //    //    else if(item is ChickenOrder c)
            //    //    {
            //    //        c.CutUp();
            //    //    }
            //    //    ((CookedFood)item).Cook();
            //    //}
            //    //Notify?.Invoke();
            //}
            #endregion
        }
    }
}

using Restaurant_Simulation_Part_1.Interfaces;
using Restaurant_Simulation_Part_1.Models;
using System.Security.Cryptography;
using static Restaurant_Simulation_Part_1.Service.TableRequest;

namespace Restaurant_Simulation_Part_1.Service
{
    public class Cook
    {
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
                Thread.Sleep(2000);
            }
            var eggs = table.Get<Egg>();
            foreach (var egg in eggs)
            {
                using (egg)
                {
                    egg.Crack();
                    egg.Cook();
                }
                Thread.Sleep(2000);
            }
        }
    }
}

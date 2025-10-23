using Restaurant_Simulation_Part_1.Interfaces;
using Restaurant_Simulation_Part_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Restaurant_Simulation_Part_1.Service.TableRequest;

namespace Restaurant_Simulation_Part_1.Service
{
    public class Cook
    {
        public void Process(TableRequest table)
        {
            var chickens = table[new ChickenOrder(2)];
            foreach (var item in chickens)
            {
                if (item is ChickenOrder c)
                {
                    c.Obtain();
                    c.CutUp();
                    c.Cook();
                }
            }

            var eggs = table[new Egg(0)];
            foreach (var item in eggs)
            {
                if (item is Egg e)
                {
                    e.Obtain();
                    e.Crack();
                    e.Cook();
                    e.Dispose();
                }
            }
        }

    }
}

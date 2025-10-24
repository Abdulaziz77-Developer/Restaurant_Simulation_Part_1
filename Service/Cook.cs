using Restaurant_Simulation_Part_1.Interfaces;
using Restaurant_Simulation_Part_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Restaurant_Simulation_Part_1.Service.TableRequest;

namespace Restaurant_Simulation_Part_1.Service
{
    public class Cook
    {
        public void Process(TableRequest table)
        {
            var chickens = table[new CookedFood()];
            foreach (var item in chickens)
            {
                if (item is Egg e)
                {
                    using (e)
                    {
                        e.Crack();
                    }
                }
                else if(item is ChickenOrder c)
                {
                    c.CutUp();
                }
                ((CookedFood)item).Cook();
            }
        }

    }
}

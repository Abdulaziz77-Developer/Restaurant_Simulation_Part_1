using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1
{
    public class Cook
    {
        MenuItem[][] menuItems;
        Order order;
        public Cook()
        {

        }
        public void RequestForFood(int quantity, MenuItem item)
        {
            if (item == MenuItem.Egg)
            {
                order = new EggOrder(quantity);
            }
            else
            {
                order = new Order(quantity);
            }
        }
        public void PrepareFood()
        {
            if (order is EggOrder)
            {
                ((EggOrder)order).DiscarsShell();
                ((EggOrder)order).Crack();
                ((EggOrder)order).Cook();
            }
            else
            {
                ((ChickenOrder)order).Cutup();
                ((ChickenOrder)order).Cook();
            }
           
        }
    }
}

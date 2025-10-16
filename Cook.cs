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
        Order[] orders = new Order[] { };
        int index = 0;
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
            //for (int i = 0; i < orders.Length; i++)
            //{
            //    if (orders[i] is ChickenOrder)
            //    {
            //        ((ChickenOrder)orders[i]).Cutup();
            //        ((ChickenOrder)orders[i]).Cook();
            //    }
            //    else
            //    {
            //        ((EggOrder)orders[i]).DiscarsShell();
            //        ((EggOrder)orders[i]).Crack();
            //        ((EggOrder)orders[i]).Cook();
            //    }
            //}
        }
    }
}

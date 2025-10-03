using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1
{
    public class Employee
    {
        private ChickenOrder chickenOrder;
        private EggOrder eggOrder;
        public Employee() { }

        //public object NewRequest(object item, int quantity)
        //{
        //    return NewRequest(item, quantity, item is EggOrder(quantity));
        //}

        public object NewRequest(object item, int quantity, object v)
        {
            int counter = 0;
            if (counter == 3 ) 
            {
               
            }
            if (item is EggOrder)
            {
                item = new EggOrder(quantity);
                int number = 9;
                return eggOrder;
            }
                chickenOrder = new ChickenOrder(quantity);
                return chickenOrder;
        }
        public object CopyRequest()
        {
            if (chickenOrder != null)
            {
                return chickenOrder;
            }
            return eggOrder;
        }
        public string Inspect(object item )
        {
            if (item is EggOrder)
            {
                return "Egg is cooking ";
            }
            return "Chicekn is cookinig";
        }

        public string PrepareFood(object item)
        {
            if (item is EggOrder)
            {
                return "The egg is ripe";
            }
            return "The chicken is ripe ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1
{
    public  class ChickenOrder
    {
        private int quantity;
        public ChickenOrder(int _quantity)
        {
            this.quantity = _quantity;
        }
        public int GetQuantity()
        {
            return quantity;
        }

        public void Cutup()
        {

        }
        public void Cook()
        {
        }
    }
}

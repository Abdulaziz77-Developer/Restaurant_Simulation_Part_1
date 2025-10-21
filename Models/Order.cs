using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1.Models
{
    public  class Order : MenuItem
    {
        private int _quantity;
        public Order(int quantity)
        {
            _quantity = quantity;
        }

        public int GetQuantity()
        {
            return _quantity;
        }
        public void Cook()
        {

        }
        public void SubtractQuantity()
        {

        }
    }
}

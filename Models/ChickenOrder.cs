using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1.Models
{
    public  class ChickenOrder :Order
    {
        private int quantity;
        public ChickenOrder(int _quantity):base(_quantity)
        {
            quantity = _quantity;
        }

        public void Cutup()
        {

        }
    }
}

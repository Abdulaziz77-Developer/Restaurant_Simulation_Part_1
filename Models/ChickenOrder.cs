using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1.Models
{
    public class ChickenOrder : MenuItem
    {
        private int quantity;

        public ChickenOrder(int _quantity) : base("Chicken")
        {
            quantity = _quantity;
        }

        public override void Obtain() => State = "Obtained";
        public void CutUp() => State = "Cut up";
        public void Cook() => State = "Cooked";
        public override void Serve() => State = "Served";
    }
}

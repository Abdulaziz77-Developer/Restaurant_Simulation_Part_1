using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1.Models
{
    public class ChickenOrder : CookedFood
    {
        
        public ChickenOrder() : base("Chicken")
        {
            
        }

        public override void Obtain() => State = "Obtained";
        public void CutUp() => State = "Cut up";
        public override void Serve() => State = "Served";
    }
}

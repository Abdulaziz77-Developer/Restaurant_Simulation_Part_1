using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1.Models
{
    public class CookedFood : MenuItem
    {
        public CookedFood()
        {
        }

        public CookedFood(string name) : base(name)
        {
        }

       

        public override void Obtain()
        {
            
        }

        public override void Serve()
        {
            
        }
        public void Cook() => State = "Cooked";
    }
}

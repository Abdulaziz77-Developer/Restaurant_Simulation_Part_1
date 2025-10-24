using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1.Models
{
    public class Egg : CookedFood, IDisposable
    {
            

            public Egg() : base("Egg")
            {
                
            }
            public override void Obtain() => State = "Obtained";
            public void Crack() => State = "Cracked";
            public override void Serve() => State = "Served";

            public void Dispose()
            {
                Console.WriteLine("Shells discarded");
            }
        }
    }


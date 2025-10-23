using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1.Models
{
    public class Egg : MenuItem, IDisposable
    {
            public int Quality { get; set; }

            public Egg(int quality) : base("Egg")
            {
                Quality = quality;
            }
            public override void Obtain() => State = "Obtained";
            public void Crack() => State = "Cracked";
            public void Cook() => State = "Cooked";
            public override void Serve() => State = "Served";

            public void Dispose()
            {
                Console.WriteLine("Shells discarded");
            }
        }
    }


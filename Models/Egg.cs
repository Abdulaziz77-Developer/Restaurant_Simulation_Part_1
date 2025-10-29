using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1.Models
{
    public class Egg : CookedFood, IDisposable
    {
        private static int quality;
        public static int GetQuality { get
            {
                if (quality < 25)
                {
                    quality  = new Random().Next(1,100);
                }
                return quality;
            }
            }
            public Egg() : base("Egg")
            {
            quality = new Random().Next(1, 100);
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


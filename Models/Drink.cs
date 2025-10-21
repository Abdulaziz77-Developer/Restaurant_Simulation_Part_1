using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1.Models
{
    public abstract class Drink : MenuItem
    {
        public abstract string Name { get; } 
    }
}

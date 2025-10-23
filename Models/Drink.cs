using Restaurant_Simulation_Part_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1.Models
{
    public sealed class Drink : MenuItem
    {
        new public string? Name { get; }
        public Drink(string name) : base(name) 
        {
            Name = name;
        }

        public override void Obtain() => State = "Obtained";
        public override void Serve() => State = "Served";
    }

}

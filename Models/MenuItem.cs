using Restaurant_Simulation_Part_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1.Models
{
    public abstract class MenuItem : IMenuItem
    {
        protected MenuItem()
        {
            
        }
        public string Name { get; protected set; }
        public string State { get; protected set; }

        public MenuItem(string name)
        {
            Name = name;
            State = "Requested";
        }

        public abstract void Obtain();
            
        public abstract void Serve();
    }
}

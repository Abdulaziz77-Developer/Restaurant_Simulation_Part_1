﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1
{
    public class EggOrder : Order
    {
        int quantity;
        private Random rand = new();
        private static int numberQuality = 0;
        
        public EggOrder(int quantity):base(quantity)
        {
            this.quantity = quantity;
            numberQuality = rand.Next(1, 100);
            
        }
        public static int? GetQuanlity()
        {
            return numberQuality;
        }
        public void Crack()
        {
        }
        public void DiscarsShell() { }  
    }
}

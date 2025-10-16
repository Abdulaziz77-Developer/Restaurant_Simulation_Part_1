using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1
{
    public class EggOrder : Order
    {
        int quantity;
        static bool isQuality = true;
        private Random rand = new();
        private static int numberQuality = 0;
        static int counter = 0;
        
        public EggOrder(int quantity):base(quantity)
        {
            this.quantity = quantity;
            numberQuality = rand.Next(1, 100);
            counter = rand.Next(1, 3);
            
        }
        public static int? GetQuanlity()
        {
            return numberQuality;
        }
        public void Crack()
        {
            if (GetQuanlity() <= 25)
            {
                throw new ArgumentOutOfRangeException("Rotten Egg");
            }
        }
        public void DiscarsShell() { }  
    }
}

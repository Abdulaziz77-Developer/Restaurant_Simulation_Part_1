using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1
{
    public class EggOrder
    {
        int quantity;
        bool isQuality = true;
        private Random rand = new();
        int numberQuality = 0;
        public EggOrder(int quantity)
        {
            this.quantity = quantity;
        }
        public int GetQuantity()
        {
            return this.quantity;
        }
        public int? GetQuanlity()
        {
            if (!isQuality)
            {
                return null;
            }
            this.numberQuality = rand.Next(1, 100);
            return this.numberQuality;
            
        }
        public void Crack()
        {
            if (GetQuanlity() <= 25)
            {
                throw new ArgumentOutOfRangeException("Rotten Egg");   
            }
            else
            {
            
            }
        }
        public void DiscarsShell()
        {

        }
        public void Cook()
        {
        }
       
    }
}

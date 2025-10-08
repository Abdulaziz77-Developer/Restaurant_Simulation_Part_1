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
        static bool isQuality = true;
        private Random rand = new();
        private static int numberQuality = 0;
        public EggOrder(int quantity)
        {
            this.quantity = quantity;
            numberQuality = rand.Next(1, 100);
        }
        public int GetQuantity()
        {
            return this.quantity;
        }
        public static int? GetQuanlity()
        {
            if (!EggOrder.isQuality)
            {
                isQuality = true;
                return null;
            }
            return numberQuality;
        }
        public void Crack()
        {
            if (GetQuanlity() <= 25)
            {
                throw new ArgumentOutOfRangeException("Rotten Egg");   
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

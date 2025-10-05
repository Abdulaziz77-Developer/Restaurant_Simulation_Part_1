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
        bool isCrack;
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
            numberQuality = rand.Next(1, 100);
            return numberQuality;
        }
        public void Crack()
        {
            if (this.numberQuality <= 25)
            {
                throw new InvalidOperationException("Число не должно быть не меньше 25 ");
                
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1
{
    public class EggOrder
    {
        private int quantity;
        bool isQuality = false;
        private Random rand = new();
        public EggOrder(int quantity)
        {
            this.quantity = quantity;
        }
        public int? GetQuality()
        {
            if (!isQuality)
            {
                return null;
            }
            return  rand.Next(1, 100);
        }
        public void Crack()
        {
            try
            {
                bool isCarsck = GetQuality() < 25;
            }
            catch (Exception)
            {

                throw new ArgumentNullException("This is is not cracked");
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

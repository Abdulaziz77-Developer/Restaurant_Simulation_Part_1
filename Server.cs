using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1
{
    public class Server
    {
        private Cook cook = new Cook();
        private string[] drinks = new string[8];
        private MenuItem[][] menuItems = new MenuItem[8][];
        private int currentClient = 0;
        private int counterForDrinks = 0;
        public Server()
        {

        }
        public void ReceiveRequestfromasingleCustomer(int amountChicken, int amountEgg, MenuItem item)
        {
            int total = amountChicken + amountEgg+1;
            int index = 0;
            if (currentClient == 8 )
            {
                throw new Exception("One table may be give 8 person ");
            }
            menuItems[currentClient] = new MenuItem[total];

                for (int j = 0; j < amountChicken; j++)
                {
                    menuItems[currentClient][index++] = MenuItem.Chicken;
                }
                for (int k = 0; k < amountEgg; k++)
                {
                    menuItems[currentClient][index++] = MenuItem.Egg;
                }
                drinks[counterForDrinks++] = item.ToString();
                currentClient++;
        }
            
        public void SendAllRequestsToCook()
        {
            int counterChicken = 0;
            int counterEgg = 0;
            for (int i = 0; i < menuItems.Length; i++)
            {
                if (menuItems[i] is null)
                {
                    continue;
                }
                else
                {
                    for (int j = 0; j < menuItems[i].Length; j++)
                    {
                        if (menuItems[i][j] is MenuItem.Egg)
                        {
                            counterEgg++;
                        }
                        else
                        {
                            counterChicken++;
                        }
                    }
                }
            }
            cook.RequestForFood(counterEgg, MenuItem.Egg);
            cook.RequestForFood(counterChicken,MenuItem.Chicken);
        }

        public string[] ServeFoodToCustomers()
        {
            int countChicken = 0;
            int countEgg = 0;
            string[] result = new string[menuItems.Length];
            for (int i = 0; i < menuItems.Length; i++)
            {
                countEgg = 0;
                countChicken = 0;
                if (menuItems[i] is null)
                {
                    continue;
                }
                for (int j = 0; j < menuItems[i].Length; j++)
                {
                    if (menuItems[i][j] is MenuItem.Chicken)
                    {
                        countChicken++;
                    }
                    else
                    {
                        countEgg++;
                    }   
                }
                result[i] = $"Client {i+1} Chicken {countChicken} Egg {countEgg} Drink {drinks[i]} ";
            }
              
            return result;
        }
    }
}

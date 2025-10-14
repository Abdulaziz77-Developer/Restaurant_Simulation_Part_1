using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1
{
    public class Waiter
    {
        private Employee employee = new Employee();
        private string[] drinks = new string[8];
        private MenuItem[][] menuItems = new MenuItem[8][];
        private int currentClient = 0;
        private int counterForDrinks = 0;
        public Waiter()
        {

        }
        public void NewOrder(int chickenCount, int eggCount)
        {
            if (chickenCount <= 0 && eggCount <= 0 )
            {
                throw new Exception("count the egg or chicken cannot small the zero ");
            }
            int totalItems = chickenCount + eggCount;
            menuItems[currentClient] = new MenuItem[totalItems];
                int index = 0;
                for (int i = 0; i < chickenCount; i++)
                    this.menuItems[currentClient][index++] = MenuItem.Chicken;

                for (int j  = 0;  j < eggCount; j++)
                    menuItems[currentClient][index++] = MenuItem.Egg;
                //if (string.IsNullOrWhiteSpace(selectedDrink?.ToString()))
                //{
                //    //menuItems[currentClient][index] = MenuItem.NoDrinks;
                //    selectedDrink = MenuItem.NoDrinks.ToString();
                //}
                //if (string.IsNullOrWhiteSpace(nameof(selectedDrink)))
                //{
                //    drinks[index] = Drinks.NoDrink;
                //}
                //else
                //{
                //    drinks[counterForDrink] = ((Drinks)selectedDrink);
                //}
            
            currentClient++;
        }
        public void  SetDrinks(string selectedDrink)
        {
            if(selectedDrink == null)
            {
                throw new ArgumentNullException("Не известный напиток ");
            }
            if (selectedDrink == "NoDrink")
            {
                this.drinks[counterForDrinks] = Drinks.NoDrink.ToString();
                counterForDrinks++;
            }
            this.drinks[counterForDrinks] = selectedDrink;
            counterForDrinks++;
        }
        public string[] GetAllClientDrinks()
        {
            return this.drinks;
        }
        public void SendAllRequestsToEmployee()
        {
            employee.RequestForFood(menuItems);
        }

        public Order[][] ServeFoodToCustomers()
        {
            var res  = this.employee.PrepareFoods();
            return res;
        }
    }
}

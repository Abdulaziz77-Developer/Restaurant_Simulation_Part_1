using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1
{
    public class Server
    {
        private Order[]? orders;
        private Employee employee = new Employee();
        private Menu[] menus;
        private Drinks[] drinks;

        public Server()
        {

        }
        public void NewRequest(Menu menu, Drinks drink)
        {
            if (menu == null)
            {
                throw new ArgumentNullException("Неизвестный тип заказа ");
                
            }
            menus.Append(menu);
            drinks.Append(drink);
        }
        public void SendRequestsToEmployee()
        {
            employee.RequestForFood(menus);
        }

        public Order[] ServeFoodToCustomers()
        {
            var foods = employee.PrepareFood();
            return foods;
        }
    }
}

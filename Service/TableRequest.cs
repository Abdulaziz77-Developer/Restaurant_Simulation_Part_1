using Restaurant_Simulation_Part_1.Interfaces;

namespace Restaurant_Simulation_Part_1.Service
{
    public class TableRequest
    {
        private IMenuItem[][] menuItems = { };
        private IMenuItem[] items = { };
        private Cook cook = new Cook();
        private int countCustomer = 1;


        public void Add(int customer, IMenuItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item not be null");
            }
            if (countCustomer == customer)
            {
                Array.Resize(ref menuItems[customer], menuItems[customer]?.Length + 1 ?? 1);
                menuItems[customer][menuItems[customer].Length - 1] = item;
            }
            else
            {
                Array.Resize(ref menuItems, menuItems.Length + 1);
                Array.Resize(ref menuItems[customer], menuItems[customer]?.Length + 1 ?? 1);
                menuItems[customer][menuItems[customer].Length - 1] = item;
                countCustomer = customer;
            }

                
                
        }
        public void Send(TableRequest table)
        {
           
            cook.Process(table);
        }

        public IMenuItem[] this[int customer]
        {
            get { 
                if (customer < 0 || customer >= menuItems.Length)
                {
                    return null;
                }
                return menuItems[customer];
            }
        }

        public IMenuItem[] this[IMenuItem item]
        {
            get
            {
                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (menuItems[i] == null) continue;
                    for (int j = 0; j < menuItems[i].Length; j++)
                    {
                        if (item != null && item.GetType() == menuItems[i][j].GetType())
                        {
                            Array.Resize(ref items, items.Length + 1);
                            items[i] = item;
                        }
                    }
                }
                return items;
            }
        }
    }
}

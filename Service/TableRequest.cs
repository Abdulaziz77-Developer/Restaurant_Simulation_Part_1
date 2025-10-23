using Restaurant_Simulation_Part_1.Interfaces;

namespace Restaurant_Simulation_Part_1.Service
{
    public class TableRequest
    {
        private IMenuItem[][] menuItems = new IMenuItem[8][];
        private IMenuItem[] items;

        public void Add(int customer, IMenuItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item not be null ");
            }
            menuItems[customer] = [item];
            Array.Resize(ref menuItems[customer], 1);
        }

        public IMenuItem[] this[int customer]
        {
            get
            {
                return menuItems[customer];
            }
        }

        public IMenuItem[] this[IMenuItem item]
        {
            get
            {
                for (int i = 0; i < menuItems.Length; i++)
                {
                    for (int j = 0; j < menuItems[i].Length; j++)
                    {
                        if (item != null && item.GetType() == menuItems[i][j].GetType())
                        {
                            items[i] = item;
                        }
                    }
                }
                return items;
            }
        }
    }
}

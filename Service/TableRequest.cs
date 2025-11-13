using Restaurant_Simulation_Part_1.Interfaces;
using Restaurant_Simulation_Part_1.Models;
using System.Collections;
using System.Security.Policy;

namespace Restaurant_Simulation_Part_1.Service
{
    public class TableRequest : IEnumerable
    {
        private  Dictionary<string, List<IMenuItem>> menuItems = new Dictionary<string, List<IMenuItem>>();
        public void Add<T>(string name,string drinkName = "No Drink") where T : IMenuItem, new()
        {
            var item = Activator.CreateInstance<T>();
            if (!menuItems.ContainsKey(name))
            {
                menuItems[name] = new List<IMenuItem>();
            }
            if (item == null)
            {
                throw new ArgumentNullException("item is not be null");
            }
            if (item is Drink)
            {
                var drink = new Drink(drinkName);
                menuItems[name].Add(drink);
                return;
            }
            menuItems[name].Add(item);
        }
        public void Add(string name, string drink)
        {
            Drink _drink = new(drink);
            menuItems[name].Add(_drink);
        }
        public   List<T> Get<T>() where T : IMenuItem 
        {
            var listOrders = new List<T>();
            var order = Activator.CreateInstance<T>();
            foreach (var item in menuItems.Values)
            {
                foreach (var item1 in item)
                {
                    if (item1.GetType() == order.GetType())
                    {
                        listOrders.Add(order);
                    }
                }
            }
            return listOrders;
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in  menuItems.OrderBy(item => item.Key).ToList())
            {
                yield return item.Key;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public List<IMenuItem> this[string name]
        {
            get
            {
                if (menuItems.TryGetValue(name,out var list))
                {
                    return list;
                }
                else
                {
                    throw new Exception("its user not found in customer user ");
                }
            }
        }
    }
}
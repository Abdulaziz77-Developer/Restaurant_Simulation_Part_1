using Restaurant_Simulation_Part_1.Interfaces;
using Restaurant_Simulation_Part_1.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant_Simulation_Part_1.Service
{
    public class TableRequest : IEnumerable<string>
    {
        private Dictionary<string, List<IMenuItem>> menuItems = new();

        public void Add<T>(string name, string drinkName = "No Drink") where T : IMenuItem, new()
        {
            var item = new T();
            if (!menuItems.ContainsKey(name))
                menuItems[name] = new List<IMenuItem>();

            if (item is Drink)
                menuItems[name].Add(new Drink(drinkName));
            else
                menuItems[name].Add(item);
        }

        public void Add(string name, string drink)
        {
            if (!menuItems.ContainsKey(name))
                menuItems[name] = new List<IMenuItem>();

            menuItems[name].Add(new Drink(drink));
        }

        public List<T> Get<T>() where T : IMenuItem
        {
            var list = new List<T>();
            foreach (var items in menuItems.Values)
            {
                foreach (var item in items)
                {
                    if (item is T t)
                        list.Add(t);
                }
            }
            return list;
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var key in menuItems.Keys.OrderBy(k => k))
                yield return key;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public List<IMenuItem> this[string name] => menuItems.TryGetValue(name, out var list) ? list : new List<IMenuItem>();
    }
}

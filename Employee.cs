using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1
{
    public class Employee
    {
        MenuItem[][] menuItems;
        Order[][] orders = new Order[][] { };
        private object obj;
        public Employee()
        {

        }
        public void RequestForFood(MenuItem[][] menus)
        {
             menuItems = menus;
        }
        // can you help me this method to make it better

        public Order[][] PrepareFoodss()
        {
            // 1️⃣ Проверяем, есть ли вообще меню
            if (menuItems == null)
                throw new InvalidOperationException("Menu items have not been set. Waiter must call RequestForFood() first.");

            // 2️⃣ Создаём массив заказов под всех клиентов
            orders = new Order[menuItems.Length][];

            // 3️⃣ Для каждого клиента создаём список заказов
            for (int i = 0; i < menuItems.Length; i++)
            {
                orders[i] = new Order[menuItems[i].Length];

                for (int j = 0; j < menuItems[i].Length; j++)
                {
                    if (menuItems[i][j] == MenuItem.Chicken)
                    {
                        var chicken = new ChickenOrder(1);
                        chicken.Cutup();
                        chicken.Cook();
                        orders[i][j] = chicken;
                    }
                    else if (menuItems[i][j] == MenuItem.Egg)
                    {
                        var egg = new EggOrder(1);
                        egg.DiscarsShell();
                        egg.Crack();
                        egg.Cook();
                        orders[i][j] = egg;
                    }
                }
            }

            return orders;
        }

        public Order[][] PrepareFood()
        {
            for (int i = 0; i < menuItems.Length; i++)
            {
                orders[i] = new Order[menuItems[i].Length];
                for (int j = 0; j < menuItems[i].Length; j++)
                {
                    if (menuItems[i][j] is MenuItem.Chicken)
                    {
                        obj = new ChickenOrder(menuItems[i].Length);
                        ((ChickenOrder)obj).Cutup();
                        ((ChickenOrder)obj).Cook();
                        this.orders[i][j] = ((ChickenOrder)obj);
                    }
                    else
                    {
                        obj = new EggOrder(menuItems[i].Length);
                        ((EggOrder)obj).DiscarsShell();
                        ((EggOrder)obj).Crack();
                        ((EggOrder)obj).Cook();
                        this.orders[i][j] = (((EggOrder)obj));
                    }
                }
            }
            return this.orders;
        }

        public Order[][] PrepareFoods()
        {

            orders = new Order[menuItems.Length][];
            for (int i = 0; i < menuItems.Length; i++)
            {
                orders[i] = new Order[menuItems[i].Length];
                for (int j = 0; j < menuItems[i].Length; j++)
                {
                    if (menuItems[i][j] is MenuItem.Chicken)
                    {
                       //for(int k = 0; k < menuItems[i].Length; i++)
                       // {
                            obj = new ChickenOrder(menuItems[i].Length);
                            ((ChickenOrder)obj).Cutup();
                            orders[i][j] = ((ChickenOrder)obj);
                        //}
                       ((ChickenOrder)obj).Cook();
                    }
                    else
                    {
                        //for (int e = 0; e < menuItems[i].Length; e++)
                        //{
                            obj = new EggOrder(menuItems[i].Length);
                            ((EggOrder)obj).DiscarsShell();
                            ((EggOrder)obj).Crack();
                            orders[i][j] = ((EggOrder)obj);
                        //}
                         ((EggOrder)obj).Cook();
                    }
                }
            }
            return orders;
        }
        #region Old PrepareFood
        //public string PrepareFood(object item)
        //{
        //    #region PrepareFood Part One
        //    //string text = "";
        //    //try
        //    //{
        //    //    if (!this.isPrepared)
        //    //    {
        //    //        if (item is ChickenOrder)
        //    //        {
        //    //            for (int i = 0; i < ((ChickenOrder)item).GetQuantity(); i++)
        //    //            {
        //    //                ((ChickenOrder)this.item).Cutup();
        //    //            }
        //    //            ((ChickenOrder)this.item).Cook();
        //    //            text = "The chicken is ripe ";
        //    //        }
        //    //        else if (item is EggOrder)
        //    //        {
        //    //            for (int i = 0; i < ((EggOrder)this.item).GetQuantity(); i++)
        //    //            {
        //    //                ((EggOrder)this.item).Crack();
        //    //                ((EggOrder)this.item).DiscarsShell();
        //    //            }
        //    //            ((EggOrder)this.item).Cook();
        //    //            text = "Ваш заказ готова ";
        //    //        }

        //    //        this.isPrepared = true;
        //    //    }
        //    //    else
        //    //    {
        //    //        throw new InvalidOperationException("«уже приготовил, больше не может приготовить снова");
        //    //    }
        //    //    return text;
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    throw new InvalidOperationException("Сотрудник получил неподдерживаемый заказ.", ex);
        //    //}
        //    #endregion
        //    return "OK";
        //}
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1
{
    public class Employee
    {
        Menu[] _menus;
        Order[] orders = new Order[] { };
        EggOrder eggOrder;
        ChickenOrder chickenOrder;
        public Employee()
        {

        }
        public void RequestForFood(Menu[] menus)
        {
            this._menus= menus;
        }

        public Order[] PrepareFood()
        {
            for (int i = 0; i < _menus.Length; i++) 
            {
                if (_menus[i] is Menu.Egg)
                {
                   
                    
                    for (int e = 0; e < (int)_menus[i]; e++)
                    {
                        eggOrder = new EggOrder((int)_menus[i]);
                        eggOrder.Crack();
                        eggOrder.DiscarsShell();
                        this.orders.Append(eggOrder);
                    }
                    this.eggOrder.Cook();
                }
                else
                {
                    for (int j = 0; j < (int)_menus[i]; j++)
                    {
                        chickenOrder = new ChickenOrder((int)_menus[i]);
                        chickenOrder.Cutup();
                        chickenOrder.SubtractQuantity();
                        this.orders.Append(chickenOrder);
                    }
                    this.chickenOrder.Cook();
                }
            }
            return this.orders;
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

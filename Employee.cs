using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1
{
    public class Employee
    {
        private ChickenOrder chickenOrder;
        private EggOrder eggOrder;
        private object? myObject;
        private string text = string.Empty;
        int counter = 1;
        int wrongNumber = 3;
        private bool isPrepared = false;
        public Employee()
        {
            
        }
        #region
        //public object NewRequest(object item, int quantity)
        //{
        //    return NewRequest(item, quantity, item is EggOrder(quantity));
        //}
        #endregion
        #region This is bad method to create NewRequest 
        //public object NewRequest(object item, int quantity)
        //{

        //    while (counter > 0)
        //    {
        //        if (wrongNumber == counter)
        //        {
        //            if (item is EggOrder)
        //            {
        //                item = new ChickenOrder(quantity);
        //                chickenOrder = (ChickenOrder)item;
        //                counter++;
        //                wrongNumber += 3;
        //                return item;
        //            }
        //            else
        //            {
        //                item = new EggOrder(quantity);
        //                eggOrder = (EggOrder)item;
        //                counter++;
        //                wrongNumber += 3;
        //                return item;
        //            }
        //        }
        //        else if (item is EggOrder)
        //        {
        //            item = new EggOrder(quantity);
        //            eggOrder = (EggOrder)item;
        //            counter++;
        //            return item;
        //        }
        //        else
        //        {
        //            item = new ChickenOrder(quantity);
        //            chickenOrder = (ChickenOrder)item;
        //            counter++;
        //            return item;

        //        }

        //    }
        //    return item;

        //}
        #endregion

        #region
        //public EggOrder? NewRequest(EggOrder egg , int quantity)
        //{
        //    egg = new EggOrder(quantity);
        //    eggOrder = egg;
        //    return egg;
        //}
        #endregion
        public object NewRequest( object item,int quantity)
        {
            if (item is null)
            {
                throw new InvalidOperationException("Нет заказа для приготовления");
            }
            isPrepared = false;
            if (item is ChickenOrder)
            {
                var chicken = new ChickenOrder(quantity);
                this.chickenOrder = chicken;
                return chicken;
            }
            else
            {
                var egg = new EggOrder(quantity);
                eggOrder = egg;
                return egg;
            }
            
        }
        public object? CopyRequest()
        {
            if (this.chickenOrder is not null && this.eggOrder is null)
            {
                ChickenOrder chicken = new(this.chickenOrder.GetQuantity());
                return chicken;
            }
            else if(this.chickenOrder is null && this.eggOrder is not null)
            {
                EggOrder _eggOrder = new(this.eggOrder.GetQuantity());
                return _eggOrder;
            }

            else if(this.chickenOrder is null && this.eggOrder is null)
            {
                throw new InvalidOperationException("Нельзя скопировать: сотрудник ещё не получил ни одного запроса.");
            }
            else
            {
                throw new InvalidOperationException("Нельзя скопировать: сотрудник ещё не получил ни одного запроса.");
            }
            
        }
        public string Inspect(object item)
        {
            if (item is ChickenOrder chicken)
            {
                text = $"Кол-во куриц: {chicken.GetQuantity()}";
            }
            else if (item is EggOrder egg)
            {
                text = $"Кол-во яиц: {egg.GetQuantity()}";
            }
            else
            {
                text = "Неизвестный заказ";
            }

            return text;
        }

        public string PrepareFood(object item)
        {
            isPrepared = true;
            string text = "";
            
            #region Test Exception
            //try
            //{

            //        if (item is ChickenOrder)
            //        {
            //            for (int i = 0; i < ((ChickenOrder)item).GetQuantity(); i++)
            //            {
            //                ((ChickenOrder)item).Cutup();
            //            }
            //            ((ChickenOrder)item).Cook();
            //            text = "The chicken is ripe ";
            //        }
            //        var num = ((EggOrder)item).GetQuanlity();
            //        if (num > 25)
            //        {
            //            text = $"Тухлый {num}";
            //            if (item is EggOrder)
            //            {
            //                for (int i = 0; i < ((EggOrder)item).GetQuantity(); i++)
            //                {
            //                    ((EggOrder)item).Crack();
            //                    ((EggOrder)item).DiscarsShell();
            //                }
            //           ((EggOrder)item).Cook();

            //            }
            //        }
            //        else
            //        {
            //            text = $"Не Тухлый {num}";
            //        }                   

            //    return text;
            //}
            //catch (Exception)
            //{

            //    throw new Exception("once the food is prepared, the employee cannot be prepare it again");
            //}
            #endregion
            try
            {
                if (counter != 2)
                {
                    if (item is ChickenOrder chicken)
                    {
                        for (int i = 0; i < chicken.GetQuantity(); i++)
                        {
                            chicken.Cutup();
                        }
                        chicken.Cook();
                        text = "The chicken is ripe ";
                    }
                    else if (item is EggOrder egg)
                    {
                        
                            text = $"Тухлый {egg.GetQuanlity()}";
                            for (int i = 0; i < egg.GetQuantity(); i++)
                            {
                                egg.Crack();
                                egg.DiscarsShell();
                            }
                            egg.Cook();
                        
                        //else
                        //{
                        //    text = $"Не Тухлый {num}";
                        //}
                    }
                    else
                    {
                        throw new InvalidCastException("Неизвестный тип заказа — сотрудник не знает, как его готовить.");
                    }
                }

                return text;
            }
            catch (InvalidCastException ex)
            {
                throw new InvalidOperationException("Сотрудник получил неподдерживаемый заказ.", ex);
            }

        }

    }
}


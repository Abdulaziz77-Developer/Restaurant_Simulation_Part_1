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
        private string text = string.Empty;
        private bool isPrepared = true;
        public Employee()
        {
            
        }
       
        public object NewRequest( object item,int quantity)
        {
            this.isPrepared = false;
            if (item is null)
            {
                throw new InvalidOperationException("Нет заказа для приготовления");
            }
           
            if (item is ChickenOrder)
            {
                var chicken = new ChickenOrder(quantity);
                this.chickenOrder = chicken;
                return chicken;
            }
            else
            {
                var egg = new EggOrder(quantity);
                this.eggOrder = egg;
                return egg;
            }
           
        }
        public object? CopyRequest()
        {
            this.isPrepared = false;
            if (this.chickenOrder is not null)
            {
                ChickenOrder chicken = new(this.chickenOrder.GetQuantity());
                return chicken;
            }
            else if(this.eggOrder is not null)
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
          
            string text = "";
            
           
            try
            {

                
                if (!this.isPrepared)
                {
                    if (item is ChickenOrder)
                    {
                        for (int i = 0; i < chickenOrder.GetQuantity(); i++)
                        {
                            chickenOrder.Cutup();
                        }
                        chickenOrder.Cook();
                        text = "The chicken is ripe ";
                    }
                    else if (item is EggOrder)
                    {

                        text = $"Тухлый {eggOrder.GetQuanlity()}";
                        for (int i = 0; i < eggOrder.GetQuantity(); i++)
                        {
                            eggOrder.Crack();
                            eggOrder.DiscarsShell();
                        }
                        eggOrder.Cook();

                       
                    }

                    else
                    {
                        throw new InvalidCastException("Неизвестный тип заказа — сотрудник не знает, как его готовить.");
                    }
                    this.isPrepared = true;

                }
                else
                {
                    throw new InvalidOperationException("«уже приготовил, больше не может приготовить снова");
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


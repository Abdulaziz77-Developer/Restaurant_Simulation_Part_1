using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1
{
    public class Employee
    {
        private object? item;
        private string text = string.Empty;
        private bool isPrepared = true;
        public Employee()
        {
            
        }
        public object NewRequest( string food,int quantity)
        {
            this.isPrepared = false;
            if (food.Equals(""))
            {
                throw new InvalidOperationException("Нет заказа для приготовления");
            }
           
            if (food.Equals("chicken"))
            {
                var chicken = new ChickenOrder(quantity);
                this.item = chicken;
                return chicken;
            }
            else
            {
                var egg = new EggOrder(quantity);
                this.item = egg;
                return egg;
            }
           
        }
        public object? CopyRequest()
        {
            this.isPrepared = false;
            if (this.item is ChickenOrder)
            {
                ChickenOrder chicken = new(((ChickenOrder)this.item).GetQuantity());
                return chicken;
            }
            else if (this.item is EggOrder)
            {
                int countQuality = Convert.ToInt32(EggOrder.GetQuanlity());
                EggOrder _eggOrder = new(((EggOrder)this.item).GetQuantity());
                return _eggOrder;
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
                        for (int i = 0; i < ((ChickenOrder)item).GetQuantity(); i++)
                        {
                            ((ChickenOrder)this.item).Cutup();
                        }
                        ((ChickenOrder)this.item).Cook();
                        text = "The chicken is ripe ";
                    }
                    else if (item is EggOrder)
                    {
                        for (int i = 0; i < ((EggOrder)this.item).GetQuantity(); i++)
                        {
                            ((EggOrder)this.item).Crack();
                            ((EggOrder)this.item).DiscarsShell();
                        }
                        ((EggOrder)this.item).Cook();
                        text = "Ваш заказ готова ";
                    }
                 
                    this.isPrepared = true;
                }
                else
                {
                    throw new InvalidOperationException("«уже приготовил, больше не может приготовить снова");
                }
                return text;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Сотрудник получил неподдерживаемый заказ.", ex);
            }

        }

    }
}


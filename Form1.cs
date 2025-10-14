using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Restaurant_Simulation_Part_1
{
    public partial class Form1 : Form
    {
        private Drinks[] drinks = { Drinks.Tea, Drinks.Fanta, Drinks.Coffee, Drinks.Pepsi };
        //private Drinks[] drinkrequest = { };
        Waiter waiter = new Waiter();
        public Form1()
        {
            InitializeComponent();
            countEgg.Text = "0";
            countChicken.Text = "0";
            chickenLabel.Text = $"How many {MenuItem.Chicken.ToString()}?";
            eggLabel.Text = $"How many {MenuItem.Egg.ToString()}?";
            foreach (var item in drinks)
            {
                drinksBox.Items.Add(item.ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            int amountChicken = int.Parse(countChicken.Text);
            int amountEgg = int.Parse(countEgg.Text);
            string drink;
            if (drinksBox.SelectedItem is null)
            {
                drink = "Nodrink";
            }
            else
            {
                drink = drinksBox.SelectedItem.ToString();
            }
            MessageBox.Show($"{drink}");
            try
            {
                waiter.NewOrder(amountChicken, amountEgg);
                waiter.SetDrinks(drink);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            #region TestNewOrderRequest
            //if (currentClient >= 8)
            //{
            //    MessageBox.Show("Уже 8 клиентов! Нельзя добавить больше.");
            //    return;
            //}

            //int chickenCount = int.Parse(countChicken.Text);
            //int eggCount = int.Parse(countEgg.Text);
            //string? selectedDrink = drinksBox.SelectedItem?.ToString();

            //int totalItems = chickenCount + eggCount + 1;
            //menuItems[currentClient] = new MenuItem[totalItems];

            //int index = 0;
            //for (int i = 0; i < chickenCount; i++)
            //    menuItems[currentClient][index++] = MenuItem.Chicken;

            //for (int i = 0; i < eggCount; i++)
            //    menuItems[currentClient][index++] = MenuItem.Egg;
            //if (string.IsNullOrWhiteSpace(selectedDrink))
            //{
            //    //menuItems[currentClient][index] = MenuItem.NoDrinks;
            //    selectedDrink = MenuItem.NoDrinks.ToString();
            //}
            //menuItems[currentClient][index] = MenuItem.Drinks;

            ////listOrders.Items.Add($"Client {currentClient + 1}: {chickenCount} Chicken, {eggCount} Egg, Drink = {selectedDrink}");
            //MessageBox.Show(menuItems[0].Length.ToString());
            //currentClient++;


            //countChicken.Text = "0";
            //countEgg.Text = "0";
            //drinksBox.SelectedIndex = 0;
            #endregion
        }

        private void SendRequestForCook_Click(object sender, EventArgs e)
        {
            try
            {
                waiter.SendAllRequestsToEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ServePrepareFood_Click(object sender, EventArgs e)
        {
            int _amountchicken = 0;
            int _amountegg = 0;
            var items = waiter.ServeFoodToCustomers();
            var _drinks = waiter.GetAllClientDrinks();
            for (int i = 0; i < items.Length; i++)
            {
                _amountchicken = 0;
                _amountegg = 0;
                if (items[i] is null)
                {
                    //continue;
                }
                else
                {
                    for (int j = 0; j < items[i].Length; j++)
                    {
                        if (items[i][j] is null)
                        {
                            break;
                        }
                        if (items[i][j] is ChickenOrder)
                        {
                            _amountchicken++;
                        }
                        else if (items[i][j] is EggOrder)
                        {
                            _amountegg++;
                        }
                        countEggQuality.Text = $"{EggOrder.GetQuanlity()}";

                    }
                    try
                    {
                        if (Convert.ToInt32(countEggQuality.Text) < 25)
                        {
                            throw new InvalidOperationException("Quantity egg dont isnt small 25");
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    if (_amountchicken is 0 && _amountegg is 0)
                    {
                        continue;
                    }
                    else
                    {
                        listOrders.Items.Add($"Client {i + 1} Chicken {_amountchicken} Egg {_amountegg} Drink {_drinks[i]} ");
                    }

                }
            }
            countEgg.Text = "0";
            countChicken.Text = "0";

        }

        private void countChicken_Click(object sender, EventArgs e)
        {
            countChicken.Text = "";
        }

        private void countEgg_Click(object sender, EventArgs e)
        {
            countEgg.Text = "";
        }
    }
}

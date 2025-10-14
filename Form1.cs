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
           
            try
            {
                waiter.NewOrder(amountChicken, amountEgg);
                waiter.SetDrinks(drink);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
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
            try
            {

           
            for (int i = 0; i < items.Length; i++)
            {
                _amountchicken = 0;
                _amountegg = 0;
                if (items[i] is null)
                {
                    
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
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
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

using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Restaurant_Simulation_Part_1
{
    public partial class Form1 : Form
    {
        private Drinks[] drinks = { Drinks.Tea, Drinks.Fanta, Drinks.Coffee, Drinks.Pepsi };
        private Drinks[] drinkrequest = { };
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
            int amountEgg = int.Parse(countChicken.Text);
            int amountChicken = int.Parse(countEgg.Text);
            try
            {
                waiter.NewOrder(amountChicken, amountEgg);
            }
            catch (Exception ex )
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

    }
}

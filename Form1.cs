using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Restaurant_Simulation_Part_1
{
    public partial class Form1 : Form
    {
        private MenuItem[] drinks = { MenuItem.Tea, MenuItem.Fanta, MenuItem.Cola,  MenuItem.Coffee};
        Server server = new Server();
        private MenuItem[][] menuitems = new MenuItem[8][];
        private int countClient = 0;
        public Form1()
        {
            InitializeComponent();
            countEgg.Text = "0";
            countChicken.Text = "0";
            chickenLabel.Text = $"How many {MenuItem.Chicken.ToString()}?";
            eggLabel.Text = $"How many {MenuItem.Egg.ToString()}?";
            foreach (var item in drinks)
            {
                drinksBox.Items.Add(item);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            try
            {
              if (string.IsNullOrWhiteSpace(countChicken.Text) || 
                  string.IsNullOrWhiteSpace(countEgg.Text) ||
                  string.IsNullOrEmpty(countChicken.Text) || 
                  string.IsNullOrEmpty(countEgg.Text))
                {
                    throw new Exception("amountegg or amountchicken does not be empty or null");
                }
                int amountChicken = int.Parse(countChicken.Text);
                int amountEgg = int.Parse(countEgg.Text);
                if (amountChicken < 0 || amountEgg < 0)
                {
                    throw new InvalidOperationException("the egg amount or chicken amount does not small the zero");
                }
                MenuItem drinkItem;
                if (drinksBox.SelectedItem == null)
                {
                    drinkItem = MenuItem.NoDrinks;
                }
                else
                {
                    drinkItem = (MenuItem)drinksBox.SelectedItem;
                }
                server.ReceiveRequestfromasingleCustomer(amountChicken, amountEgg, drinkItem);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            countChicken.Text = "0";
            countEgg.Text = "0";
            listOrders.Items.Clear();
        }

        private void SendRequestForCook_Click(object sender, EventArgs e)
        {
            try
            {
                server.SendAllRequestsToCook();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ServePrepareFood_Click(object sender, EventArgs e)
        {
            string[] result = server.ServeFoodToCustomers();
            listOrders.Items.Clear();
            for (int i = 0; i < result.Length; i++)
            {
                if (string.IsNullOrEmpty(result[i]))
                {
                    continue;
                }
                listOrders.Items.Add(result[i]);
            }
            
            countEgg.Text = "0";
            countChicken.Text = "0";

        }
        #region
        //int _amountchicken = 0;
        //int _amountegg = 0;
        //var items = server.ServeFoodToCustomers();

        //try
        //{
        //for (int i = 0; i < items.Length; i++)
        //{
        //    _amountchicken = 0;
        //    _amountegg = 0;
        //    if (items[i] is null)
        //    {

        //    }
        //    else
        //    {
        //        for (int j = 0; j < items[i].Length; j++)
        //        {
        //            if (items[i][j] is null)
        //            {
        //                break;
        //            }
        //            if (items[i][j] is ChickenOrder)
        //            {
        //                _amountchicken++;
        //            }
        //            else if (items[i][j] is EggOrder)
        //            {
        //                _amountegg++;
        //            }
        //            countEggQuality.Text = $"{EggOrder.GetQuanlity()}";

        //        }
        //        try
        //        {
        //            if (Convert.ToInt32(countEggQuality.Text) < 25)
        //            {
        //                throw new InvalidOperationException("Quantity egg dont isnt small 25");
        //            }
        //        }
        //        catch (Exception)
        //        {

        //            throw;
        //        }
        //        if (_amountchicken is 0 && _amountegg is 0)
        //        {
        //            continue;
        //        }
        //        else
        //        {
        //            listOrders.Items.Add($"Client {i + 1} Chicken {_amountchicken} Egg {_amountegg} Drink ");
        //        }
        //    }
        //}
        //}
        //catch (Exception ex)
        //{

        //    MessageBox.Show(ex.Message);
        //}
        #endregion
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

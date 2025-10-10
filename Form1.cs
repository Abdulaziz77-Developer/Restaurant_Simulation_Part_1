using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Restaurant_Simulation_Part_1
{
    public partial class Form1 : Form
    {
        private Drinks[] drinks = { Drinks.Tea, Drinks.Fanta, Drinks.Coffee, Drinks.Pepsi };
        private Drinks[] drinkrequest = { };
        Server server = new Server();
        private Menu[] menus = { };
        public Form1()
        {
            InitializeComponent();
            countEgg.Text = "0";
            countChicken.Text = "0";
            chickenLabel.Text = $"How many {Menu.Chicken.ToString()}?";
            eggLabel.Text = $"How many {Menu.Egg.ToString()}?";
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
            try
            {
                if (string.IsNullOrWhiteSpace(countChicken.Text)
                || Convert.ToInt32(countChicken.Text) < 0 ||
                string.IsNullOrWhiteSpace(countEgg.Text) ||
                Convert.ToInt32(countEgg.Text) < 0)
                {
                    throw new OverflowException("Cannot convert string to int or input is null or whitespace ");
                }
                else
                {
                    int amountEgg = Convert.ToInt32(countEgg.Text);
                    int amountChicken = Convert.ToInt32(countChicken.Text);
                    for (int i = 0; i < amountEgg; i++)
                    {
                        menus.Append(Menu.Egg);
                    }
                    for (int i = 0; i < amountChicken; i++)
                    {
                        menus.Append(Menu.Chicken);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //var number = Menu.Chicken;
            //MessageBox.Show($"{(int)number}");
        }
    }
}

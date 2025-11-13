using Restaurant_Simulation_Part_1.Models;
using Restaurant_Simulation_Part_1.Service;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Restaurant_Simulation_Part_1
{
    public partial class Form1 : Form
    {
     
        private readonly string[] drinks = { "CocaCola", "Fanta", "Sprite", "Water" };
        public  Server server = new Server();
        private object locker = new object();
        public Form1()
        {
            InitializeComponent();
            drinksBox.Items.AddRange(drinks);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            countEggQuality.Text = "0";
            //listOrders.Items.Clear();
            int amountEgg = int.Parse(countEgg.Text);
            int amountChicken = int.Parse(countChicken.Text);
            string drinkName = drinksBox.SelectedItem?.ToString() ?? "No Drink"; 
            string name = userName.Text;

            if (string.IsNullOrEmpty(name))
            {
                drinkName = "No Drink";
            }

            server.NewRequest(name, amountChicken, amountEgg, drinkName); 
            countEgg.Text = "0";
            countChicken.Text = "0";
            drinksBox.Items.Clear();
            for (int i = 0; i < drinks.Length; i++)
            {
                drinksBox.Items.Add(drinks[i]);
            }
        }

        private void SendRequestForCook_Click(object sender, EventArgs e)
        {
            lock (locker)
            {
                Task.Run(() => server.SendOrdersToCook()).
                    ContinueWith(task => ShowResult());
            }
        }
        public void ShowResult()
        {
            var result = server.Serve();
            lock (locker)
                this.Invoke((Action)(() =>
                {
                    foreach (var item in result)
                    {
                        listOrders.Items.Add(item);
                    }
                }));
        }
      
        private void countChicken_Click(object sender, EventArgs e)
        {
            countChicken.Text = "";
        }

        private void countEgg_Click(object sender, EventArgs e)
        {
            countEgg.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

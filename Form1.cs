using System.Security.Cryptography.X509Certificates;

namespace Restaurant_Simulation_Part_1
{
    public partial class Form1 : Form
    {
        bool isChicken;
        bool isEgg;
        private EggOrder egg;
        private ChickenOrder chicken;
        private Employee employee = new Employee();
        int counter = 1;
        int wrongnumber = 3;
        private int countItem;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {

            if (wrongnumber != counter)
            {
                isChicken = rbtnChicken.Checked;
                isEgg = rbtnEgg.Checked;
                if (txtQuantity.Text != string.Empty)
                {
                    if (isChicken)
                    {
                       this.countItem = int.Parse(txtQuantity.Text);
                        chicken = (ChickenOrder)employee.NewRequest(1, this.countItem);
                        txtResult.Text += $"{employee.Inspect(chicken)} {Environment.NewLine}";
                        countEggQuality.Text = "0";
                    }
                    if (isEgg)
                    {
                        this.countItem = int.Parse(txtQuantity.Text);
                        egg = (EggOrder)employee.NewRequest(2, this.countItem);
                        txtResult.Text += $"{employee.Inspect(egg)} {Environment.NewLine}";
                        countEggQuality.Text = $"{egg.GetQuanlity()}";
                    }
                }
                else
                {
                    throw new ArgumentException(
                        "—трока не можеть быть пустой null или содержать только пробел ",
                        nameof(txtQuantity.Text));
                }
                counter++;
            }
            else if (counter % 2 == 0)
            {
                MessageBox.Show("" +
                    "—отрудник должень выбрать заказ чтобы заказать нажимету кнопку Prepand Food");
                counter++;
            }
            else
            {
                if (isChicken)
                {
                    this.countItem = int.Parse(txtQuantity.Text);
                    egg = ((EggOrder)employee.NewRequest(2, this.countItem));
                    txtResult.Text += employee.Inspect(egg) + Environment.NewLine;
                    countEggQuality.Text = $"{egg.GetQuanlity()}";
                }
                if (isEgg)
                {

                    this.countItem = int.Parse(txtQuantity.Text);
                    chicken = ((ChickenOrder)employee.NewRequest(1, countItem));
                    txtResult.Text += employee.Inspect(chicken) + Environment.NewLine;
                    countEggQuality.Text = "0";
                }
                wrongnumber += 3;
                counter++;
            }

        }

        private void copyRequest_Click(object sender, EventArgs e)
        {

            var item = employee.CopyRequest();
            if (isEgg && item != null)
            {
                txtQuantity.Text = $"{((EggOrder)item).GetQuantity()}";
                txtResult.Text += Environment.NewLine + $"{employee.Inspect((EggOrder)item)}";
                countEggQuality.Text = $"{((EggOrder)item).GetQuanlity()}";
            }   
            if (isChicken && item != null)
            {
                txtQuantity.Text = $"{((ChickenOrder)item).GetQuantity()}";
                txtResult.Text += $"{employee.Inspect((ChickenOrder)item)}";
            }
        }

        private void btnPrepareFood_Click(object sender, EventArgs e)
        {
           
            if (isChicken)
            {
                string text = txtResult.Text;
                var res = employee.PrepareFood(chicken);
                MessageBox.Show(res);
                txtQuantity.Text = "0";

            }
            if (isEgg)
            {
                var result = employee.PrepareFood(egg);
                txtQuantity.Text = "0";
                MessageBox.Show(result);
            }
        }
    }
}

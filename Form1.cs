using System.Security.Cryptography.X509Certificates;

namespace Restaurant_Simulation_Part_1
{
    public partial class Form1 : Form
    {
        
        bool isChicken;
        bool isEgg;
        private object? obj;
        private EggOrder egg;
        private ChickenOrder chicken;
        private Employee employee = new Employee();
       
        static Random random = new Random();
        private int countItem;
        public Form1()
        {
            InitializeComponent();
            txtQuantity.Text = "0";

        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            
            this.isChicken = rbtnChicken.Checked;
            this.isEgg = rbtnEgg.Checked;
            bool isErrorRequest = random.Next(0, 3) == 0;

            
            try
            {
                if (string.IsNullOrEmpty(nameof(txtQuantity.Text)) || txtQuantity.Text == "0")
                {
                    throw new InvalidOperationException("Количество не можеть быть равень нулю ");
                }
                countItem = int.Parse(txtQuantity.Text);
                if (countItem < 0 || countItem == 0)
                {
                    throw new Exception("Количество не можеть быть меньше с нулю ");
                }

                if (isErrorRequest)
                {
                    if (this.isChicken)
                    {
                        var obj = employee.NewRequest("chicken", countItem);
                        txtResult.Text += employee.Inspect(obj) + Environment.NewLine;
                        txtQuantity.Text += EggOrder.GetQuanlity();
                    }
                    if (this.isEgg)
                    {
                        var obj = employee.NewRequest("egg", countItem);
                        txtResult.Text += employee.Inspect(obj) + Environment.NewLine;

                    }
                }
                else
                {
                    if (this.isChicken)
                    {
                       this.obj = ((ChickenOrder)employee.NewRequest("chicken", countItem));
                       txtResult.Text += employee.Inspect(obj) + Environment.NewLine;
                    }
                    else
                    {
                       
                        this.obj = ((EggOrder)employee.NewRequest("egg", countItem));
                        txtResult.Text += employee.Inspect(obj) + Environment.NewLine;
                        countEggQuality.Text = EggOrder.GetQuanlity().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtQuantity.Text = "0";
        }

        private void copyRequest_Click(object sender, EventArgs e)
        {
            try
            {

                var item = employee.CopyRequest();
                if (this.isEgg && obj != null)
                {
                    txtQuantity.Text = $"{((EggOrder)obj).GetQuantity()}";
                    txtResult.Text += $"{employee.Inspect((EggOrder)obj)}" + Environment.NewLine;
                    countEggQuality.Text = $"{EggOrder.GetQuanlity().ToString()}";
                }
                if (this.isChicken && obj != null)
                {
                    txtQuantity.Text = $"{((ChickenOrder)obj).GetQuantity()}";
                    txtResult.Text += $"{employee.Inspect((ChickenOrder)obj)}" + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrepareFood_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.isChicken && obj != null)
                {
                    string text = txtResult.Text;
                    var res = employee.PrepareFood(obj);
                    MessageBox.Show(res);
                    txtQuantity.Text = "0";

                }
                else if (this.isEgg && obj != null)
                {
                    var result = employee.PrepareFood(this.obj);
                    txtQuantity.Text = "0";
                    MessageBox.Show(result);
                }
                else
                {
                    throw new InvalidCastException("Неизвестный тип заказа — сотрудник не знает, как его готовить.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void txtQuantity_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

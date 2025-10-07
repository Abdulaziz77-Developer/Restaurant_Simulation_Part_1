using System.Security.Cryptography.X509Certificates;

namespace Restaurant_Simulation_Part_1
{
    public partial class Form1 : Form
    {
        bool _isEgg;
        bool _IsChikken;
        bool isChicken;
        bool isEgg;
        private EggOrder egg;
        private ChickenOrder chicken;
        private Employee employee = new Employee();
        int counter = 1;
        int wrongnumber = 3;
        static Random random = new Random();
        private int countItem;
        public Form1()
        {
            InitializeComponent();
            txtQuantity.Text = "0";

        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            #region NewRequest 
            //    bool isError = random.Next(0, 3) == 0;

            //    if (isError)
            //    {
            //        isChicken = rbtnChicken.Checked;
            //        isEgg = rbtnEgg.Checked;
            //        if (txtQuantity.Text != string.Empty)
            //        {
            //            if (isChicken)
            //            {
            //               this.countItem = int.Parse(txtQuantity.Text);
            //                chicken = (ChickenOrder)employee.NewRequest(1, this.countItem);
            //                txtResult.Text += $"{employee.Inspect(chicken)} {Environment.NewLine}";
            //                countEggQuality.Text = "0";
            //            }
            //            if (isEgg)
            //            {
            //                this.countItem = int.Parse(txtQuantity.Text);
            //                egg = (EggOrder)employee.NewRequest(2, this.countItem);
            //                txtResult.Text += $"{employee.Inspect(egg)} {Environment.NewLine}";
            //                countEggQuality.Text = $"{egg.GetQuanlity()}";
            //            }
            //        }
            //        else
            //        {
            //            throw new ArgumentException(
            //                "—трока не можеть быть пустой null или содержать только пробел ",
            //                nameof(txtQuantity.Text));
            //        }

            //    }
            //    //else if (counter % 2 == 1)
            //    //{
            //    //    MessageBox.Show("" +
            //    //        "—отрудник должень выбрать заказ чтобы заказать нажимету кнопку Prepand Food");
            //    //    counter++;
            //    //}
            //    else
            //    {
            //        if (isChicken)
            //        {
            //            this.countItem = int.Parse(txtQuantity.Text);
            //            egg = ((EggOrder)employee.NewRequest(2, this.countItem));
            //            txtResult.Text += employee.Inspect(egg) + Environment.NewLine;
            //            countEggQuality.Text = $"{egg.GetQuanlity()}";
            //        }
            //        if (isEgg)
            //        {

            //            this.countItem = int.Parse(txtQuantity.Text);
            //            chicken = ((ChickenOrder)employee.NewRequest(1, countItem));
            //            txtResult.Text += employee.Inspect(chicken) + Environment.NewLine;
            //            countEggQuality.Text = "0";
            //        }
            //        //wrongnumber += 3;
            //        //counter++;
            //    }
            #endregion
            this.isChicken = rbtnChicken.Checked;
            this.isEgg = rbtnEgg.Checked;
            bool isErrorRequest = random.Next(0, 3) == 0;

            //MessageBox.Show(countItem.ToString());
            try
            {
                if (string.IsNullOrEmpty(nameof(txtQuantity.Text)) || txtQuantity.Text == "0")
                {
                    throw new InvalidOperationException(" оличество не можеть быть равень нулю ");
                }
                countItem = int.Parse(txtQuantity.Text);
                if (countItem < 0 || countItem == 0)
                {
                    throw new Exception(" оличество не можеть быть меньше с нулю ");
                }

                if (isErrorRequest)
                {
                    if (this.isChicken)
                    {
                        this.egg = new EggOrder(countItem);
                        var item = employee.NewRequest(this.egg, countItem);
                        txtResult.Text += employee.Inspect(item) + Environment.NewLine;
                        txtQuantity.Text += egg.GetQuanlity();
                    }
                    if (this.isEgg)
                    {
                        this.chicken = new ChickenOrder(countItem);
                        var item = employee.NewRequest(this.chicken, countItem);
                        txtResult.Text += employee.Inspect(item) + Environment.NewLine;

                    }
                }
                else
                {
                    if (this.isChicken)
                    {
                        var objChicken = new ChickenOrder(countItem);
                       this.chicken = ((ChickenOrder)employee.NewRequest(objChicken, countItem));
                        txtResult.Text += employee.Inspect(chicken) + Environment.NewLine;
                    }
                    else
                    {
                        var objEgg = new EggOrder(countItem);
                        this.egg = ((EggOrder)employee.NewRequest(objEgg, countItem));
                        txtResult.Text += employee.Inspect(egg) + Environment.NewLine;
                        countEggQuality.Text = egg.GetQuanlity().ToString();
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
                if (this.isEgg && item != null)
                {
                    txtQuantity.Text = $"{((EggOrder)item).GetQuantity()}";
                    txtResult.Text += $"{employee.Inspect((EggOrder)item)}" + Environment.NewLine;
                    countEggQuality.Text = $"{((EggOrder)item).GetQuanlity()}";
                }
                if (this.isChicken && item != null)
                {
                    txtQuantity.Text = $"{((ChickenOrder)item).GetQuantity()}";
                    txtResult.Text += $"{employee.Inspect((ChickenOrder)item)}" + Environment.NewLine;
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
                if (this.isChicken)
                {
                    string text = txtResult.Text;
                    var res = employee.PrepareFood(this.chicken);
                    MessageBox.Show(res);
                    txtQuantity.Text = "0";

                }
                else if (this.isEgg)
                {
                    var result = employee.PrepareFood(this.egg);
                    txtQuantity.Text = "0";
                    MessageBox.Show(result);
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

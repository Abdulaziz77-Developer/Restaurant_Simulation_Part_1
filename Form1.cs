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
        static Random random = new Random();
        private int countItem;
        public Form1()
        {
            InitializeComponent();

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
            countItem = int.Parse(txtQuantity.Text);
            try
            {
                if (isErrorRequest)
                {
                    if (this.isChicken)
                    {
                        egg = new EggOrder(countItem);
                        var item = employee.NewRequest(egg, countItem);
                        txtResult.Text += Environment.NewLine + employee.Inspect(item);
                        txtQuantity.Text += egg.GetQuanlity();
                    }
                    if (this.isEgg)
                    {
                        chicken = new ChickenOrder(countItem);
                        var item =  employee.NewRequest(chicken, countItem);
                        txtResult.Text += Environment.NewLine + employee.Inspect(item);
                       
                    }
                }
                else
                {
                    if (this.isChicken)
                    {
                        chicken = new ChickenOrder(countItem);
                        employee.NewRequest(chicken, countItem);
                        txtResult.Text += employee.Inspect(chicken) + Environment.NewLine;
                    }
                    else
                    {
                        egg = new EggOrder(countItem);
                        employee.NewRequest(egg, countItem);
                        txtResult.Text +=  employee.Inspect(egg) + Environment.NewLine;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

        private void copyRequest_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrepareFood_Click(object sender, EventArgs e)
        {

            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }
    }
}

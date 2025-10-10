namespace Restaurant_Simulation_Part_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            drinksBox = new ComboBox();
            countEgg = new TextBox();
            countChicken = new TextBox();
            eggLabel = new Label();
            chickenLabel = new Label();
            btnNewRequest = new Button();
            copyRequest = new Button();
            label2 = new Label();
            countEggQuality = new Label();
            btnPrepareFood = new Button();
            label4 = new Label();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(drinksBox);
            groupBox1.Controls.Add(countEgg);
            groupBox1.Controls.Add(countChicken);
            groupBox1.Controls.Add(eggLabel);
            groupBox1.Controls.Add(chickenLabel);
            groupBox1.Controls.Add(btnNewRequest);
            groupBox1.Location = new Point(45, 14);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(580, 218);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mune";
            // 
            // drinksBox
            // 
            drinksBox.FormattingEnabled = true;
            drinksBox.Location = new Point(372, 39);
            drinksBox.Name = "drinksBox";
            drinksBox.Size = new Size(151, 39);
            drinksBox.TabIndex = 11;
            // 
            // countEgg
            // 
            countEgg.Location = new Point(262, 92);
            countEgg.Name = "countEgg";
            countEgg.Size = new Size(48, 38);
            countEgg.TabIndex = 10;
            // 
            // countChicken
            // 
            countChicken.Location = new Point(262, 36);
            countChicken.Name = "countChicken";
            countChicken.Size = new Size(48, 38);
            countChicken.TabIndex = 9;
            // 
            // eggLabel
            // 
            eggLabel.AutoSize = true;
            eggLabel.Location = new Point(29, 92);
            eggLabel.Name = "eggLabel";
            eggLabel.Size = new Size(185, 31);
            eggLabel.TabIndex = 1;
            eggLabel.Text = "How many egg?";
            // 
            // chickenLabel
            // 
            chickenLabel.AutoSize = true;
            chickenLabel.Location = new Point(29, 36);
            chickenLabel.Name = "chickenLabel";
            chickenLabel.Size = new Size(227, 31);
            chickenLabel.TabIndex = 0;
            chickenLabel.Text = "How many chicken?";
            // 
            // btnNewRequest
            // 
            btnNewRequest.Location = new Point(39, 157);
            btnNewRequest.Name = "btnNewRequest";
            btnNewRequest.Size = new Size(459, 38);
            btnNewRequest.TabIndex = 2;
            btnNewRequest.Text = "Receive this request  from a Customer";
            btnNewRequest.UseVisualStyleBackColor = true;
            btnNewRequest.Click += btnNewRequest_Click;
            // 
            // copyRequest
            // 
            copyRequest.Location = new Point(84, 255);
            copyRequest.Name = "copyRequest";
            copyRequest.Size = new Size(459, 38);
            copyRequest.TabIndex = 3;
            copyRequest.Text = "Send all Customer  requests to the Cook";
            copyRequest.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 316);
            label2.Name = "label2";
            label2.Size = new Size(156, 31);
            label2.TabIndex = 4;
            label2.Text = "Egg Quality : ";
            // 
            // countEggQuality
            // 
            countEggQuality.AutoSize = true;
            countEggQuality.Location = new Point(207, 316);
            countEggQuality.Name = "countEggQuality";
            countEggQuality.Size = new Size(27, 31);
            countEggQuality.TabIndex = 5;
            countEggQuality.Text = "0";
            // 
            // btnPrepareFood
            // 
            btnPrepareFood.Location = new Point(84, 366);
            btnPrepareFood.Name = "btnPrepareFood";
            btnPrepareFood.Size = new Size(459, 38);
            btnPrepareFood.TabIndex = 6;
            btnPrepareFood.Text = "Serve prepare food to the Customer ";
            btnPrepareFood.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 428);
            label4.Name = "label4";
            label4.Size = new Size(90, 31);
            label4.TabIndex = 7;
            label4.Text = "Results";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 31;
            listBox1.Location = new Point(45, 462);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(580, 159);
            listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 653);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(btnPrepareFood);
            Controls.Add(countEggQuality);
            Controls.Add(label2);
            Controls.Add(copyRequest);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Restaurant";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Button btnNewRequest;
        private Button copyRequest;
        private Label label2;
        private Label countEggQuality;
        private Button btnPrepareFood;
        private Label label4;
        private ComboBox drinksBox;
        private TextBox countEgg;
        private TextBox countChicken;
        private Label eggLabel;
        private Label chickenLabel;
        private ListBox listBox1;
    }
}

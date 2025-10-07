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
            rbtnEgg = new RadioButton();
            rbtnChicken = new RadioButton();
            label1 = new Label();
            txtQuantity = new TextBox();
            btnNewRequest = new Button();
            copyRequest = new Button();
            label2 = new Label();
            countEggQuality = new Label();
            btnPrepareFood = new Button();
            label4 = new Label();
            txtResult = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnEgg);
            groupBox1.Controls.Add(rbtnChicken);
            groupBox1.Location = new Point(45, 14);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(289, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mune";
            // 
            // rbtnEgg
            // 
            rbtnEgg.AutoSize = true;
            rbtnEgg.Location = new Point(20, 92);
            rbtnEgg.Name = "rbtnEgg";
            rbtnEgg.Size = new Size(75, 35);
            rbtnEgg.TabIndex = 1;
            rbtnEgg.TabStop = true;
            rbtnEgg.Text = "Egg";
            rbtnEgg.UseVisualStyleBackColor = true;
            // 
            // rbtnChicken
            // 
            rbtnChicken.AutoSize = true;
            rbtnChicken.Location = new Point(20, 51);
            rbtnChicken.Name = "rbtnChicken";
            rbtnChicken.Size = new Size(120, 35);
            rbtnChicken.TabIndex = 0;
            rbtnChicken.TabStop = true;
            rbtnChicken.Text = "Chicken";
            rbtnChicken.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 186);
            label1.Name = "label1";
            label1.Size = new Size(108, 31);
            label1.TabIndex = 0;
            label1.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(159, 186);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(175, 38);
            txtQuantity.TabIndex = 1;
            txtQuantity.Click += txtQuantity_Click;
            
            // 
            // btnNewRequest
            // 
            btnNewRequest.Location = new Point(351, 186);
            btnNewRequest.Name = "btnNewRequest";
            btnNewRequest.Size = new Size(274, 38);
            btnNewRequest.TabIndex = 2;
            btnNewRequest.Text = "Submit  new request";
            btnNewRequest.UseVisualStyleBackColor = true;
            btnNewRequest.Click += btnNewRequest_Click;
            // 
            // copyRequest
            // 
            copyRequest.Location = new Point(45, 252);
            copyRequest.Name = "copyRequest";
            copyRequest.Size = new Size(362, 38);
            copyRequest.TabIndex = 3;
            copyRequest.Text = "Copy with previous request ";
            copyRequest.UseVisualStyleBackColor = true;
            copyRequest.Click += copyRequest_Click;
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
            btnPrepareFood.Location = new Point(45, 371);
            btnPrepareFood.Name = "btnPrepareFood";
            btnPrepareFood.Size = new Size(440, 38);
            btnPrepareFood.TabIndex = 6;
            btnPrepareFood.Text = "Prepare Food";
            btnPrepareFood.UseVisualStyleBackColor = true;
            btnPrepareFood.Click += btnPrepareFood_Click;
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
            // txtResult
            // 
            txtResult.Location = new Point(45, 462);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(448, 150);
            txtResult.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 653);
            Controls.Add(txtResult);
            Controls.Add(label4);
            Controls.Add(btnPrepareFood);
            Controls.Add(countEggQuality);
            Controls.Add(label2);
            Controls.Add(copyRequest);
            Controls.Add(btnNewRequest);
            Controls.Add(txtQuantity);
            Controls.Add(label1);
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
        private Label label1;
        private TextBox txtQuantity;
        private Button btnNewRequest;
        private Button copyRequest;
        private Label label2;
        private Label countEggQuality;
        private RadioButton rbtnEgg;
        private RadioButton rbtnChicken;
        private Button btnPrepareFood;
        private Label label4;
        private TextBox txtResult;
    }
}

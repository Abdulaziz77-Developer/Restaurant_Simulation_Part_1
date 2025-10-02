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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(45, 14);
            groupBox1.Margin = new Padding(5, 5, 5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 5, 5, 5);
            groupBox1.Size = new Size(289, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mune";
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
            // textBox1
            // 
            textBox1.Location = new Point(159, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 38);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(351, 186);
            button1.Name = "button1";
            button1.Size = new Size(274, 38);
            button1.TabIndex = 2;
            button1.Text = "Submit  new request";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(45, 252);
            button2.Name = "button2";
            button2.Size = new Size(362, 38);
            button2.TabIndex = 3;
            button2.Text = "Copy with previous request ";
            button2.UseVisualStyleBackColor = true;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 316);
            label3.Name = "label3";
            label3.Size = new Size(27, 31);
            label3.TabIndex = 5;
            label3.Text = "0";
            // 
            // button3
            // 
            button3.Location = new Point(45, 371);
            button3.Name = "button3";
            button3.Size = new Size(440, 38);
            button3.TabIndex = 6;
            button3.Text = "Prepare Food";
            button3.UseVisualStyleBackColor = true;
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
            // textBox2
            // 
            textBox2.Location = new Point(45, 462);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(448, 150);
            textBox2.TabIndex = 8;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 51);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(120, 35);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Chicken";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(20, 92);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 35);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Egg";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 653);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Restaurant";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button3;
        private Label label4;
        private TextBox textBox2;
    }
}

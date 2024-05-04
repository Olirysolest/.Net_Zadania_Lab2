namespace Kalkulator
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            button16 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(184, 133);
            button1.Name = "button1";
            button1.Size = new Size(104, 42);
            button1.TabIndex = 1;
            button1.Text = "=";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Wynik_Click;
            // 
            // button2
            // 
            button2.Location = new Point(15, 53);
            button2.Name = "button2";
            button2.Size = new Size(47, 32);
            button2.TabIndex = 2;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Num_Click;
            // 
            // button3
            // 
            button3.Location = new Point(68, 53);
            button3.Name = "button3";
            button3.Size = new Size(47, 32);
            button3.TabIndex = 3;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Num_Click;
            // 
            // button4
            // 
            button4.Location = new Point(121, 53);
            button4.Name = "button4";
            button4.Size = new Size(47, 32);
            button4.TabIndex = 4;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Num_Click;
            // 
            // button5
            // 
            button5.Location = new Point(15, 100);
            button5.Name = "button5";
            button5.Size = new Size(47, 32);
            button5.TabIndex = 5;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Num_Click;
            // 
            // button6
            // 
            button6.Location = new Point(68, 100);
            button6.Name = "button6";
            button6.Size = new Size(47, 32);
            button6.TabIndex = 6;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Num_Click;
            // 
            // button7
            // 
            button7.Location = new Point(121, 100);
            button7.Name = "button7";
            button7.Size = new Size(47, 32);
            button7.TabIndex = 7;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Num_Click;
            // 
            // button8
            // 
            button8.Location = new Point(15, 138);
            button8.Name = "button8";
            button8.Size = new Size(47, 32);
            button8.TabIndex = 8;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Num_Click;
            // 
            // button9
            // 
            button9.Location = new Point(68, 138);
            button9.Name = "button9";
            button9.Size = new Size(47, 32);
            button9.TabIndex = 9;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Num_Click;
            // 
            // button10
            // 
            button10.Location = new Point(121, 138);
            button10.Name = "button10";
            button10.Size = new Size(47, 32);
            button10.TabIndex = 10;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Num_Click;
            // 
            // button11
            // 
            button11.Location = new Point(15, 189);
            button11.Name = "button11";
            button11.Size = new Size(153, 32);
            button11.TabIndex = 11;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Num_Click;
            // 
            // button12
            // 
            button12.Location = new Point(181, 53);
            button12.Name = "button12";
            button12.Size = new Size(54, 26);
            button12.TabIndex = 12;
            button12.Text = "*";
            button12.UseVisualStyleBackColor = true;
            button12.Click += Dzial_Click;
            // 
            // button13
            // 
            button13.Location = new Point(234, 53);
            button13.Name = "button13";
            button13.Size = new Size(54, 26);
            button13.TabIndex = 13;
            button13.Text = "/";
            button13.UseVisualStyleBackColor = true;
            button13.Click += Dzial_Click;
            // 
            // button14
            // 
            button14.Location = new Point(181, 91);
            button14.Name = "button14";
            button14.Size = new Size(54, 26);
            button14.TabIndex = 14;
            button14.Text = "+";
            button14.UseVisualStyleBackColor = true;
            button14.Click += Dzial_Click;
            // 
            // button15
            // 
            button15.Location = new Point(234, 91);
            button15.Name = "button15";
            button15.Size = new Size(54, 26);
            button15.TabIndex = 15;
            button15.Text = "-";
            button15.UseVisualStyleBackColor = true;
            button15.Click += Dzial_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 38);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.GreenYellow;
            label1.Location = new Point(17, 10);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 209);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 17;
            label2.Text = "28229";
            label2.Click += label2_Click;
            // 
            // button16
            // 
            button16.Location = new Point(184, 186);
            button16.Name = "button16";
            button16.Size = new Size(104, 40);
            button16.TabIndex = 18;
            button16.Text = "C";
            button16.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 238);
            Controls.Add(button16);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Kalkulator";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button16;
    }
}

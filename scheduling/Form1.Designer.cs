namespace scheduling
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
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-8, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 87);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.menu_burger;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(11, 56);
            button1.Name = "button1";
            button1.Size = new Size(27, 23);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(608, 150);
            button2.Name = "button2";
            button2.Size = new Size(65, 43);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(505, 150);
            button3.Name = "button3";
            button3.Size = new Size(65, 43);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(403, 150);
            button4.Name = "button4";
            button4.Size = new Size(65, 43);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(608, 257);
            button5.Name = "button5";
            button5.Size = new Size(65, 43);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(505, 257);
            button6.Name = "button6";
            button6.Size = new Size(65, 43);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(403, 257);
            button7.Name = "button7";
            button7.Size = new Size(65, 43);
            button7.TabIndex = 6;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(608, 198);
            label1.Name = "label1";
            label1.Size = new Size(67, 12);
            label1.TabIndex = 7;
            label1.Text = "ادارة المعلمين ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(503, 198);
            label2.Name = "label2";
            label2.Size = new Size(69, 12);
            label2.TabIndex = 8;
            label2.Text = "المواد الدراسية ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(617, 303);
            label3.Name = "label3";
            label3.Size = new Size(56, 12);
            label3.TabIndex = 9;
            label3.Text = "عرض جدول ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(419, 198);
            label4.Name = "label4";
            label4.Size = new Size(38, 12);
            label4.TabIndex = 10;
            label4.Text = "الفصول";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(419, 303);
            label5.Name = "label5";
            label5.Size = new Size(44, 12);
            label5.TabIndex = 11;
            label5.Text = "بناء جدول";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(515, 303);
            label6.Name = "label6";
            label6.Size = new Size(55, 12);
            label6.TabIndex = 12;
            label6.Text = "تعديل جدول";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}

namespace RSA
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox8 = new TextBox();
            button3 = new Button();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            button4 = new Button();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            button5 = new Button();
            textBox13 = new TextBox();
            label10 = new Label();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            label11 = new Label();
            button6 = new Button();
            textBox16 = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(236, 236);
            button1.Name = "button1";
            button1.Size = new Size(225, 25);
            button1.TabIndex = 0;
            button1.Text = "Запуск шифрования";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 67);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(353, 67);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(312, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(236, 38);
            label1.Name = "label1";
            label1.Size = new Size(225, 21);
            label1.TabIndex = 3;
            label1.Text = "Введите два простых числа";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(270, 9);
            label2.Name = "label2";
            label2.Size = new Size(165, 29);
            label2.TabIndex = 4;
            label2.Text = "Алгоритм RSA";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(218, 126);
            label3.Name = "label3";
            label3.Size = new Size(262, 21);
            label3.TabIndex = 5;
            label3.Text = "Проверка на простоту успешна?";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox3.Location = new Point(236, 150);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(58, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox4.Location = new Point(405, 150);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(56, 23);
            textBox4.TabIndex = 7;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(236, 98);
            button2.Name = "button2";
            button2.Size = new Size(225, 25);
            button2.TabIndex = 8;
            button2.Text = "Проверка на простоту";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(264, 176);
            label4.Name = "label4";
            label4.Size = new Size(171, 21);
            label4.TabIndex = 9;
            label4.Text = "Исходное сообщение:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox5.Location = new Point(12, 200);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(653, 30);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox6.Location = new Point(12, 288);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(309, 23);
            textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox7.Location = new Point(368, 288);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(297, 23);
            textBox7.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(76, 264);
            label5.Name = "label5";
            label5.Size = new Size(185, 21);
            label5.TabIndex = 13;
            label5.Text = "Зашифрованные блоки";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(425, 264);
            label6.Name = "label6";
            label6.Size = new Size(187, 21);
            label6.TabIndex = 14;
            label6.Text = "Дешифрованные блоки";
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox8.Location = new Point(12, 369);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(653, 23);
            textBox8.TabIndex = 16;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(236, 317);
            button3.Name = "button3";
            button3.Size = new Size(225, 25);
            button3.TabIndex = 17;
            button3.Text = "Получение хэша";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox9.Location = new Point(12, 9);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(109, 23);
            textBox9.TabIndex = 18;
            textBox9.Visible = false;
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox10.Location = new Point(12, 9);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(109, 23);
            textBox10.TabIndex = 19;
            textBox10.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(327, 345);
            label7.Name = "label7";
            label7.Size = new Size(45, 21);
            label7.TabIndex = 20;
            label7.Text = "Хэш:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(195, 426);
            label8.Name = "label8";
            label8.Size = new Size(329, 21);
            label8.TabIndex = 23;
            label8.Text = "Цифровая подпись + исходное сообщение:";
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(236, 398);
            button4.Name = "button4";
            button4.Size = new Size(225, 25);
            button4.TabIndex = 22;
            button4.Text = "Получение ЦП";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox11
            // 
            textBox11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox11.Location = new Point(12, 450);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(653, 23);
            textBox11.TabIndex = 21;
            // 
            // textBox12
            // 
            textBox12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox12.Location = new Point(12, 9);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(109, 23);
            textBox12.TabIndex = 24;
            textBox12.Visible = false;
            // 
            // button5
            // 
            button5.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(236, 479);
            button5.Name = "button5";
            button5.Size = new Size(225, 25);
            button5.TabIndex = 26;
            button5.Text = "Получение хэша";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox13
            // 
            textBox13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox13.Location = new Point(21, 531);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(644, 23);
            textBox13.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(327, 507);
            label10.Name = "label10";
            label10.Size = new Size(45, 21);
            label10.TabIndex = 28;
            label10.Text = "Хэш:";
            // 
            // textBox14
            // 
            textBox14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox14.Location = new Point(12, 9);
            textBox14.Multiline = true;
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(109, 23);
            textBox14.TabIndex = 29;
            textBox14.Visible = false;
            // 
            // textBox15
            // 
            textBox15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox15.Location = new Point(21, 581);
            textBox15.Multiline = true;
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(644, 23);
            textBox15.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(251, 557);
            label11.Name = "label11";
            label11.Size = new Size(195, 21);
            label11.TabIndex = 31;
            label11.Text = "Вычисление хэш-образа:";
            // 
            // button6
            // 
            button6.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(150, 610);
            button6.Name = "button6";
            button6.Size = new Size(399, 25);
            button6.TabIndex = 32;
            button6.Text = "Получение хэш-образа из цифровой подписи";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox16
            // 
            textBox16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox16.Location = new Point(21, 662);
            textBox16.Multiline = true;
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(644, 23);
            textBox16.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(251, 638);
            label9.Name = "label9";
            label9.Size = new Size(195, 21);
            label9.TabIndex = 34;
            label9.Text = "Вычисление хэш-образа:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 692);
            Controls.Add(label9);
            Controls.Add(textBox16);
            Controls.Add(button6);
            Controls.Add(label11);
            Controls.Add(textBox15);
            Controls.Add(textBox14);
            Controls.Add(label10);
            Controls.Add(button5);
            Controls.Add(textBox13);
            Controls.Add(textBox12);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(textBox11);
            Controls.Add(label7);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(button3);
            Controls.Add(textBox8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "RSA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private Label label4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label5;
        private Label label6;
        private TextBox textBox8;
        private Button button3;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label7;
        private Label label8;
        private Button button4;
        private TextBox textBox11;
        private TextBox textBox12;
        private Button button5;
        private TextBox textBox13;
        private Label label10;
        private TextBox textBox14;
        private TextBox textBox15;
        private Label label11;
        private Button button6;
        private TextBox textBox16;
        private Label label9;
    }
}

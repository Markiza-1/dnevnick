namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textdate = new System.Windows.Forms.TextBox();
            this.textboxGlav = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.glav = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(629, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(548, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(629, 359);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textdate
            // 
            this.textdate.Location = new System.Drawing.Point(27, 330);
            this.textdate.Name = "textdate";
            this.textdate.Size = new System.Drawing.Size(100, 20);
            this.textdate.TabIndex = 5;
            this.textdate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textboxGlav
            // 
            this.textboxGlav.Location = new System.Drawing.Point(27, 390);
            this.textboxGlav.Name = "textboxGlav";
            this.textboxGlav.Size = new System.Drawing.Size(100, 20);
            this.textboxGlav.TabIndex = 6;
            this.textboxGlav.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(167, 330);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(256, 90);
            this.textBox3.TabIndex = 7;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(27, 308);
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Size = new System.Drawing.Size(53, 20);
            this.date.TabIndex = 8;
            this.date.Text = "Дата";
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // glav
            // 
            this.glav.Location = new System.Drawing.Point(27, 364);
            this.glav.Name = "glav";
            this.glav.ReadOnly = true;
            this.glav.Size = new System.Drawing.Size(70, 20);
            this.glav.TabIndex = 9;
            this.glav.Text = "Заголовок";
            this.glav.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(167, 308);
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Size = new System.Drawing.Size(53, 20);
            this.text.TabIndex = 10;
            this.text.Text = "Текст";
            this.text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-4, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(779, 302);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(429, 390);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(81, 20);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "Слова";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(429, 418);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 16;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.glav);
            this.Controls.Add(this.date);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textboxGlav);
            this.Controls.Add(this.textdate);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textdate;
        private System.Windows.Forms.TextBox textboxGlav;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox glav;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}


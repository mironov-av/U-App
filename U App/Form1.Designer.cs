namespace U_App
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttons3 = new U_App.Buttons();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttons7 = new U_App.Buttons();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttons8 = new U_App.Buttons();
            this.buttons9 = new U_App.Buttons();
            this.buttons10 = new U_App.Buttons();
            this.buttons2 = new U_App.Buttons();
            this.buttons1 = new U_App.Buttons();
            this.buttons6 = new U_App.Buttons();
            this.buttons5 = new U_App.Buttons();
            this.buttons4 = new U_App.Buttons();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(84, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 584);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(269, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Загрузка видео";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox3.Location = new System.Drawing.Point(67, 533);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(560, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Введите теги для видео";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // textBox2
            //
            this.textBox2.AutoSize = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox2.Location = new System.Drawing.Point(67, 389);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(560, 120);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Введите описание видео";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(67, 341);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(560, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Введите название видео";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.buttons3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(67, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 196);
            this.panel2.TabIndex = 0;
            this.panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel2_DragDrop);
            this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel2_DragEnter);
            this.panel2.DragLeave += new System.EventHandler(this.panel2_DragLeave);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttons3
            // 
            this.buttons3.BackColor = System.Drawing.Color.MediumPurple;
            this.buttons3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttons3.ForeColor = System.Drawing.Color.White;
            this.buttons3.Location = new System.Drawing.Point(212, 106);
            this.buttons3.Name = "buttons3";
            this.buttons3.Size = new System.Drawing.Size(133, 40);
            this.buttons3.TabIndex = 0;
            this.buttons3.Text = "Выберете файл";
            this.buttons3.Click += new System.EventHandler(this.buttons3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(189, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Перетащите файлы сюда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(208, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "или нажмите кнопку";
            // 
            // textBox5
            // 
            this.textBox5.AutoSize = false;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox5.Location = new System.Drawing.Point(67, 389);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(560, 120);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Введите описание загружаемого файла";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.Enter += new System.EventHandler(this.textBox5_Enter);
            this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox4.Location = new System.Drawing.Point(67, 341);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(560, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Введите название файла";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.Enter += new System.EventHandler(this.textBox4_Enter);
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(139, 54);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(400, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.buttons7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(67, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 196);
            this.panel3.TabIndex = 3;
            this.panel3.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel3_DragDrop);
            this.panel3.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel3_DragEnter);
            this.panel3.DragLeave += new System.EventHandler(this.panel3_DragLeave);
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // buttons7
            // 
            this.buttons7.BackColor = System.Drawing.Color.MediumPurple;
            this.buttons7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttons7.ForeColor = System.Drawing.Color.White;
            this.buttons7.Location = new System.Drawing.Point(212, 106);
            this.buttons7.Name = "buttons7";
            this.buttons7.Size = new System.Drawing.Size(133, 40);
            this.buttons7.TabIndex = 3;
            this.buttons7.Text = "Выберете файл";
            this.buttons7.Click += new System.EventHandler(this.buttons7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(189, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Перетащите файлы сюда";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(208, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "или нажмите кнопку";
            // 
            // buttons8
            // 
            this.buttons8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttons8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttons8.ForeColor = System.Drawing.Color.White;
            this.buttons8.Location = new System.Drawing.Point(167, 106);
            this.buttons8.Name = "buttons8";
            this.buttons8.Size = new System.Drawing.Size(100, 30);
            this.buttons8.TabIndex = 3;
            this.buttons8.Text = "Назад";
            this.buttons8.Click += new System.EventHandler(this.buttons8_Click);
            // 
            // buttons9
            // 
            this.buttons9.BackColor = System.Drawing.Color.SeaGreen;
            this.buttons9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttons9.ForeColor = System.Drawing.Color.White;
            this.buttons9.Location = new System.Drawing.Point(287, 106);
            this.buttons9.Name = "buttons9";
            this.buttons9.Size = new System.Drawing.Size(100, 30);
            this.buttons9.TabIndex = 0;
            this.buttons9.Text = "Загрузить";
            this.buttons9.Click += new System.EventHandler(this.buttons9_Click);
            // 
            // buttons10
            // 
            this.buttons10.BackColor = System.Drawing.Color.Brown;
            this.buttons10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttons10.ForeColor = System.Drawing.Color.White;
            this.buttons10.Location = new System.Drawing.Point(259, 74);
            this.buttons10.Name = "buttons10";
            this.buttons10.Size = new System.Drawing.Size(100, 30);
            this.buttons10.TabIndex = 0;
            this.buttons10.Text = "Отменить";
            this.buttons10.Click += new System.EventHandler(this.buttons10_Click);
            // 
            // buttons2
            // 
            this.buttons2.BackColor = System.Drawing.SystemColors.Control;
            this.buttons2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttons2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttons2.Location = new System.Drawing.Point(205, 52);
            this.buttons2.Name = "buttons2";
            this.buttons2.Size = new System.Drawing.Size(122, 53);
            this.buttons2.TabIndex = 1;
            this.buttons2.Text = "Google Drive";
            this.buttons2.Click += new System.EventHandler(this.buttons2_Click);
            // 
            // buttons1
            // 
            this.buttons1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttons1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttons1.ForeColor = System.Drawing.SystemColors.Control;
            this.buttons1.Location = new System.Drawing.Point(84, 52);
            this.buttons1.Name = "buttons1";
            this.buttons1.Size = new System.Drawing.Size(124, 53);
            this.buttons1.TabIndex = 0;
            this.buttons1.Text = "YouTube";
            this.buttons1.Click += new System.EventHandler(this.buttons1_Click);
            // 
            // buttons6
            // 
            this.buttons6.BackColor = System.Drawing.Color.Brown;
            this.buttons6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttons6.ForeColor = System.Drawing.Color.White;
            this.buttons6.Location = new System.Drawing.Point(259, 74);
            this.buttons6.Name = "buttons6";
            this.buttons6.Size = new System.Drawing.Size(100, 30);
            this.buttons6.TabIndex = 6;
            this.buttons6.Text = "Отменить";
            this.buttons6.Click += new System.EventHandler(this.buttons6_Click);
            // 
            // buttons5
            // 
            this.buttons5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttons5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttons5.ForeColor = System.Drawing.Color.White;
            this.buttons5.Location = new System.Drawing.Point(167, 106);
            this.buttons5.Name = "buttons5";
            this.buttons5.Size = new System.Drawing.Size(100, 30);
            this.buttons5.TabIndex = 5;
            this.buttons5.Text = "Назад";
            this.buttons5.Click += new System.EventHandler(this.buttons5_Click);
            // 
            // buttons4
            // 
            this.buttons4.BackColor = System.Drawing.Color.SeaGreen;
            this.buttons4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttons4.ForeColor = System.Drawing.Color.White;
            this.buttons4.Location = new System.Drawing.Point(287, 106);
            this.buttons4.Name = "buttons4";
            this.buttons4.Size = new System.Drawing.Size(100, 30);
            this.buttons4.TabIndex = 4;
            this.buttons4.Text = "Загрузить";
            this.buttons4.Click += new System.EventHandler(this.buttons4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 715);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttons2);
            this.Controls.Add(this.buttons1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Buttons buttons1;
        private Buttons buttons2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Buttons buttons3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Buttons buttons4;
        private Buttons buttons5;
        private Buttons buttons6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Buttons buttons7;
        private System.Windows.Forms.Panel panel3;
        private Buttons buttons8;
        private Buttons buttons9;
        private Buttons buttons10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


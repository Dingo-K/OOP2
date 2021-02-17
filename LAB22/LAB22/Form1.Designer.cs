namespace LAB22
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Flat = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Build = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Street = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Ball = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Group = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Secondname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this._Name = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Course)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(856, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 46);
            this.button3.TabIndex = 65;
            this.button3.Text = "Загрузка";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(722, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 46);
            this.button2.TabIndex = 64;
            this.button2.Text = "Сохранение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 46);
            this.button1.TabIndex = 63;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Flat
            // 
            this.Flat.Location = new System.Drawing.Point(355, 468);
            this.Flat.Multiline = true;
            this.Flat.Name = "Flat";
            this.Flat.Size = new System.Drawing.Size(189, 28);
            this.Flat.TabIndex = 62;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label14.Location = new System.Drawing.Point(352, 447);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 18);
            this.label14.TabIndex = 61;
            this.label14.Text = "Квартира";
            // 
            // Build
            // 
            this.Build.Location = new System.Drawing.Point(355, 411);
            this.Build.Multiline = true;
            this.Build.Name = "Build";
            this.Build.Size = new System.Drawing.Size(189, 28);
            this.Build.TabIndex = 60;
            this.Build.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label13.Location = new System.Drawing.Point(352, 390);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 18);
            this.label13.TabIndex = 59;
            this.label13.Text = "Дом";
            // 
            // Street
            // 
            this.Street.Location = new System.Drawing.Point(355, 340);
            this.Street.Multiline = true;
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(189, 28);
            this.Street.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label12.Location = new System.Drawing.Point(352, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 18);
            this.label12.TabIndex = 57;
            this.label12.Text = "Улица";
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(355, 279);
            this.City.Multiline = true;
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(189, 28);
            this.City.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.Location = new System.Drawing.Point(352, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 18);
            this.label11.TabIndex = 55;
            this.label11.Text = "Город";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(588, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(396, 382);
            this.listView1.TabIndex = 54;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Ball
            // 
            this.Ball.Location = new System.Drawing.Point(355, 200);
            this.Ball.Multiline = true;
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(189, 28);
            this.Ball.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(352, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 18);
            this.label10.TabIndex = 52;
            this.label10.Text = "Средний балл";
            // 
            // Group
            // 
            this.Group.Location = new System.Drawing.Point(355, 104);
            this.Group.Maximum = 12;
            this.Group.Minimum = 1;
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(186, 56);
            this.Group.TabIndex = 51;
            this.Group.Value = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(352, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 50;
            this.label9.Text = "Группа";
            // 
            // Course
            // 
            this.Course.Location = new System.Drawing.Point(77, 352);
            this.Course.Maximum = 4;
            this.Course.Minimum = 1;
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(186, 56);
            this.Course.TabIndex = 46;
            this.Course.Value = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(74, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "Курс";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ПОИТ",
            "ПОИБМС",
            "ДЭВИ",
            "ИСИТ"});
            this.comboBox1.Location = new System.Drawing.Point(74, 292);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 24);
            this.comboBox1.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(74, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 43;
            this.label6.Text = "Специальность";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(355, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(352, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "Дата рождения ";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(74, 227);
            this.Age.Multiline = true;
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(189, 28);
            this.Age.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(74, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Возраст";
            // 
            // Secondname
            // 
            this.Secondname.Location = new System.Drawing.Point(74, 166);
            this.Secondname.Multiline = true;
            this.Secondname.Name = "Secondname";
            this.Secondname.Size = new System.Drawing.Size(189, 28);
            this.Secondname.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(71, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(71, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Имя";
            // 
            // Firstname
            // 
            this.Firstname.Location = new System.Drawing.Point(74, 44);
            this.Firstname.Multiline = true;
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(189, 28);
            this.Firstname.TabIndex = 34;
            this.Firstname.TextChanged += new System.EventHandler(this.Firstname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(71, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Фамилия";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(163, 380);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 17);
            this.label15.TabIndex = 66;
            this.label15.Text = "1";
            // 
            // _Name
            // 
            this._Name.Location = new System.Drawing.Point(74, 104);
            this._Name.Multiline = true;
            this._Name.Name = "_Name";
            this._Name.Size = new System.Drawing.Size(189, 28);
            this._Name.TabIndex = 67;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(434, 143);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 17);
            this.label16.TabIndex = 68;
            this.label16.Text = "1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(74, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 18);
            this.label8.TabIndex = 70;
            this.label8.Text = "Пол";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Женщина";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Мужчина";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this._Name);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Flat);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Build);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Street);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Secondname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Course)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Flat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Build;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Street;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox Ball;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar Group;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar Course;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Secondname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Firstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox _Name;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}


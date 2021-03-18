
namespace LAB22
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.Label();
            this._Name = new System.Windows.Forms.Label();
            this.Secondname = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.Street = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.DateB = new System.Windows.Forms.Label();
            this.Group = new System.Windows.Forms.Label();
            this.Ball = new System.Windows.Forms.Label();
            this.Build = new System.Windows.Forms.Label();
            this.Flat = new System.Windows.Forms.Label();
            this.Special = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Label1.Location = new System.Drawing.Point(169, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(118, 24);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Сортировка";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(39, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(379, 133);
            this.listView1.TabIndex = 72;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(379, 43);
            this.button1.TabIndex = 73;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(67, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 17);
            this.label2.TabIndex = 75;
            this.label2.Text = "Сортировка производиться по фамилии!!!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 77;
            this.label4.Text = "Фамилия:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 78;
            this.label5.Text = "Имя:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 79;
            this.label6.Text = "Курс:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 80;
            this.label7.Text = "Отчество:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(596, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 81;
            this.label8.Text = "Специальность:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(796, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 82;
            this.label9.Text = "Пол:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(796, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 83;
            this.label10.Text = "Дата рождени:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(796, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 84;
            this.label11.Text = "Группа:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(796, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 17);
            this.label12.TabIndex = 85;
            this.label12.Text = "Средний бал:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(468, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 86;
            this.label13.Text = "Город:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(468, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 87;
            this.label14.Text = "Улица:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(796, 205);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 17);
            this.label15.TabIndex = 88;
            this.label15.Text = "Квартира:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(796, 179);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 17);
            this.label16.TabIndex = 89;
            this.label16.Text = "Дом:";
            // 
            // Firstname
            // 
            this.Firstname.AutoSize = true;
            this.Firstname.Location = new System.Drawing.Point(539, 42);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(0, 17);
            this.Firstname.TabIndex = 90;
            // 
            // _Name
            // 
            this._Name.AutoSize = true;
            this._Name.Location = new System.Drawing.Point(504, 73);
            this._Name.Name = "_Name";
            this._Name.Size = new System.Drawing.Size(0, 17);
            this._Name.TabIndex = 91;
            this._Name.Click += new System.EventHandler(this.label18_Click);
            // 
            // Secondname
            // 
            this.Secondname.AutoSize = true;
            this.Secondname.Location = new System.Drawing.Point(539, 101);
            this.Secondname.Name = "Secondname";
            this.Secondname.Size = new System.Drawing.Size(0, 17);
            this.Secondname.TabIndex = 92;
            // 
            // Course
            // 
            this.Course.AutoSize = true;
            this.Course.Location = new System.Drawing.Point(505, 129);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(0, 17);
            this.Course.TabIndex = 93;
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(516, 179);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(0, 17);
            this.City.TabIndex = 94;
            // 
            // Street
            // 
            this.Street.AutoSize = true;
            this.Street.Location = new System.Drawing.Point(516, 205);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(0, 17);
            this.Street.TabIndex = 95;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(833, 42);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(0, 17);
            this.Gender.TabIndex = 96;
            // 
            // DateB
            // 
            this.DateB.AutoSize = true;
            this.DateB.Location = new System.Drawing.Point(898, 73);
            this.DateB.Name = "DateB";
            this.DateB.Size = new System.Drawing.Size(0, 17);
            this.DateB.TabIndex = 97;
            // 
            // Group
            // 
            this.Group.AutoSize = true;
            this.Group.Location = new System.Drawing.Point(855, 101);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(0, 17);
            this.Group.TabIndex = 98;
            // 
            // Ball
            // 
            this.Ball.AutoSize = true;
            this.Ball.Location = new System.Drawing.Point(889, 129);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(0, 17);
            this.Ball.TabIndex = 99;
            // 
            // Build
            // 
            this.Build.AutoSize = true;
            this.Build.Location = new System.Drawing.Point(833, 179);
            this.Build.Name = "Build";
            this.Build.Size = new System.Drawing.Size(0, 17);
            this.Build.TabIndex = 100;
            // 
            // Flat
            // 
            this.Flat.AutoSize = true;
            this.Flat.Location = new System.Drawing.Point(865, 205);
            this.Flat.Name = "Flat";
            this.Flat.Size = new System.Drawing.Size(0, 17);
            this.Flat.TabIndex = 101;
            // 
            // Special
            // 
            this.Special.AutoSize = true;
            this.Special.Location = new System.Drawing.Point(705, 261);
            this.Special.Name = "Special";
            this.Special.Size = new System.Drawing.Size(0, 17);
            this.Special.TabIndex = 102;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(379, 43);
            this.button2.TabIndex = 103;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 299);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Special);
            this.Controls.Add(this.Flat);
            this.Controls.Add(this.Build);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.DateB);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Street);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.Secondname);
            this.Controls.Add(this._Name);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label Firstname;
        private System.Windows.Forms.Label _Name;
        private System.Windows.Forms.Label Secondname;
        private System.Windows.Forms.Label Course;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label Street;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label DateB;
        private System.Windows.Forms.Label Group;
        private System.Windows.Forms.Label Ball;
        private System.Windows.Forms.Label Build;
        private System.Windows.Forms.Label Flat;
        private System.Windows.Forms.Label Special;
        private System.Windows.Forms.Button button2;
    }
}
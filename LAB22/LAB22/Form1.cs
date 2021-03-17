using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LAB22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Course.Scroll += trackBar1_Scroll;
            Group.Scroll += trackBar2_Scroll;
            
        }

        private void ClearInput()
        {
            Firstname.Clear();
            _Name.Clear();
            Secondname.Clear();
            comboBox1.SelectedIndex = 0;
            Ball.Clear();
            City.Clear();
            Street.Clear();
            Build.Clear();
            Flat.Clear();
            Group.Value = 1;
            Course.Value = 1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            label16.Text = "1";
            label15.Text = "1";
        }
        private void SortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кульш Денис Александрович\n"+"Version: 1.0.0");
        }
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems != null)
            {
                ListViewItem lvi = listView1.SelectedItems[0];
                listView1.Items.Remove(lvi);
            }
        }
        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label16.Text = String.Format("{0}", Group.Value);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label15.Text = String.Format("{0}", Course.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double _ball = Convert.ToDouble(Ball.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте корректность балла");
            }
            try
            {
                char[] forname = Firstname.Text.ToCharArray();
                double _ball = Convert.ToDouble(Ball.Text);
                foreach (char i in forname)
                {
                    if (Char.IsLetter(i) == false)
                    {
                        throw new Exception("Фамилия");
                    }
                }

                forname = _Name.Text.ToCharArray();
                foreach (char i in forname)
                {
                    if (Char.IsLetter(i) == false)
                    {
                        throw new Exception("Имя");
                    }
                }
                forname = Secondname.Text.ToCharArray();
                foreach (char i in forname)
                {
                    if (Char.IsLetter(i) == false)
                    {
                        throw new Exception("Отчество");
                    }
                }
                forname = City.Text.ToCharArray();
                foreach (char i in forname)
                {
                    if (Char.IsLetter(i) == false)
                    {
                        throw new Exception("Город");
                    }
                }
                forname = Street.Text.ToCharArray();
                foreach (char i in forname)
                {
                    if (Char.IsLetter(i) == false)
                    {
                        throw new Exception("Улица");
                    }
                }
                
                
                forname = Build.Text.ToCharArray();
                char t = '/';
                int a = 0;
                int b = 0;
                foreach (char i in forname)
                {
                    if (b == 0)
                    {
                        if (i == t)
                        {
                            throw new Exception("Дом");
                        }
                    }
                    if (i == t)
                    {
                        
                        if(a>0)
                        {
                            throw new Exception("Дом");
                        }
                        a++;
                        continue;
                    }
                    if (Char.IsDigit(i) == false)
                    {
                        
                        throw new Exception("Дом");
                    }
                    b++;
                }
                forname = Flat.Text.ToCharArray();
                foreach (char i in forname)
                {
                    if (Char.IsDigit(i) == false)
                    {
                        throw new Exception("Квартира");
                    }
                }
                int _age;
                double ball = Convert.ToDouble(Ball.Text);
                if(ball < 0)
                {
                    throw new Exception("Балл");
                }
                _age = int.Parse(Flat.Text);
                if (_age <= 0)
                {
                    throw new Exception("Неверно указана квартира");
                }
                string one = "";
                if (radioButton1.Checked)
                {
                    one = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    one = radioButton2.Text;
                }

                Student first = new Student(Firstname.Text, _Name.Text, Secondname.Text,comboBox1.Text, Course.Value, one, dateTimePicker1.Text, Group.Value,_ball , City.Text, Street.Text, Build.Text, Flat.Text);
                ListViewItem LVI = new ListViewItem(first.firstname);
                LVI.Tag = first;
                listView1.Items.Add(LVI);
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Проверьте корректность {ex.Message}");
                
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 1)
            {
                Student first = (Student)listView1.SelectedItems[0].Tag;

                if(first != null)
                {
                    
                    Firstname.Text = first.firstname;
                    _Name.Text = first.name;
                    Secondname.Text = first.secondname;
                    comboBox1.Text = first.special;
                    Course.Value = first.course;
                    dateTimePicker1.Text = first.time;
                    Group.Value = first.group;
                    Ball.Text =Convert.ToString(first.ball);
                    City.Text = first.city;
                    Street.Text = first.street;
                    Build.Text = first.build;
                    Flat.Text = first.flat;
                    label16.Text = String.Format("{0}", Group.Value);
                    label15.Text = String.Format("{0}", Course.Value);
                    if (first.gender == "Мужчина")
                    {
                        radioButton1.Checked = true;
                    }
                    if (first.gender == "Женщина")
                    {
                        radioButton2.Checked = true;
                    }
                }
            }
            if (listView1.SelectedItems.Count == 0)
            {
                ClearInput();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            foreach(ListViewItem item in listView1.Items)
            {
                if(item.Tag != null)
                {
                    students.studentlist.Add((Student)item.Tag);
                }
            }
            XMLSerialize(students);
        }
        private void XMLSerialize(Students students)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Students));

            using (FileStream fs = new FileStream("Students.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, students);
            }
        }
        private Students XMLDeSerialize()
        {
            
                XmlSerializer xml = new XmlSerializer(typeof(Students));

                using (FileStream fs = new FileStream("Students.xml", FileMode.OpenOrCreate))
                {
                    Students students = (Students)xml.Deserialize(fs);
                    return students;
                }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Students students = XMLDeSerialize();
            
            foreach(Student student in students.studentlist)
            {
                Add(student);
            }
        }

        private void Add(Student first)
        {
            ListViewItem LVI = new ListViewItem(first.firstname);
            LVI.Tag = first;
            listView1.Items.Add(LVI);
        }

        private void Firstname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;

        }

    }
}

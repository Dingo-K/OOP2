using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LAB22
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
        private void Add(Student first)
        {
            ListViewItem LVI = new ListViewItem(first.firstname);
            LVI.Tag = first;
            listView1.Items.Add(LVI);
        }
        private void XMLSerialize(Students students)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Students));

            using (FileStream fs = new FileStream("StudentsFind.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, students);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Students students = XMLDeSerialize();
            foreach (Student student in students.studentlist)
            {
                if(textBox1.Text != null)
                {
                    Regex regex = new Regex(textBox1.Text + @"(\w*)");
                    if (regex.IsMatch(student.firstname))
                    {
                        Add(student);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Tag != null)
                {
                    students.studentlist.Add((Student)item.Tag);
                }
            }
            XMLSerialize(students);
        }
    }
}

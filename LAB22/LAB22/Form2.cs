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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
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
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void Add(Student first)
        {
            ListViewItem LVI = new ListViewItem(first.firstname);
            LVI.Tag = first;
            listView1.Items.Add(LVI);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Student first = (Student)listView1.SelectedItems[0].Tag;

                if (first != null)
                {
                    Firstname.Text = first.firstname;
                    _Name.Text = first.name;
                    Secondname.Text = first.secondname;
                    Special.Text = first.special;
                    Course.Text = Convert.ToString(first.course);
                    DateB.Text = first.time;
                    Group.Text = Convert.ToString(first.group);
                    Ball.Text = Convert.ToString(first.ball);
                    City.Text = first.city;
                    Street.Text = first.street;
                    Build.Text = first.build;
                    Flat.Text = first.flat;
                    Gender.Text = first.gender;
                }

            }
            if (listView1.SelectedItems.Count == 0)
            {

                Firstname.Text = " ";
                _Name.Text = " ";
                Secondname.Text = " ";
                Special.Text = " ";
                Course.Text = " ";
                DateB.Text = " ";
                Group.Text = " ";
                Ball.Text = " ";
                City.Text = " ";
                Street.Text = " ";
                Build.Text = " ";
                Flat.Text = " ";
                Gender.Text = " ";
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Students students = XMLDeSerialize();
            var sortedstudents = from u in students.studentlist
                                 orderby u.firstname
                                 select u;
            foreach (Student student in sortedstudents)
            {
                Add(student);
            }
        }
        private void XMLSerialize(Students students)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Students));

            using (FileStream fs = new FileStream("StudentsSort.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, students);
            }
        }
        private void button2_Click(object sender, EventArgs e)
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

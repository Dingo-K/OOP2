using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB22
{
    [Serializable]
    public class Student
    {
        public string name;
        public string firstname;
        public string secondname;
        public string age;
        public string special;
        public int course;
        public string gender;
        public string time;
        public int group;
        public string ball;
        public string city;
        public string street;
        public string build;
        public string flat;
        public Student()
        {

        }
        
        public Student(string name, string firstname, string secondname, string age, string special, int course, string gender, string time, int group, string ball, string city, string street, string build, string flat)
        {
            this.name = name;
            this.firstname = firstname;
            this.secondname = secondname;
            this.age = age;
            this.course = course;
            this.special = special;
            this.gender = gender;
            this.time = time;
            this.group = group;
            this.ball = ball;
            this.city = city;
            this.street = street;
            this.build = build;
            this.flat = flat;
        }
    }
    [Serializable]
    public class Students
    {
        public List<Student> studentlist = new List<Student>();

        public Students()
        {

        }

        
    }
}

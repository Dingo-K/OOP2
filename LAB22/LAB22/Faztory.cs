using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB22
{
    class Faztory
    {
    }

   abstract class Adding
    {
        public abstract void Add(string firstname, string name, string secondname, string special, int course, string gender, string time, int group, double ball, string city, string street, string build, string flat);
    }

    class Create : Adding
    {
        public string name;    
        public string firstname;
        public string secondname;
        public string special;
        public int course;
        public string gender;
        public string time;
        public int group;
        public double ball;
        public string city;
        public string street;
        public string build;
        [Valid]
        public string flat;

        public override void Add(string firstname, string name, string secondname, string special, int course, string gender, string time, int group, double ball, string city, string street, string build, string flat)
        {
            this.name = name;
            this.firstname = firstname;
            this.secondname = secondname;
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
    
    abstract class FactoryStudent
    {
        public abstract Adding Create_student();
    }

    class StudentFactory : FactoryStudent
    {
        
        public override Adding Create_student()
        {
            return new Create();
        }
    }
    
    class Students1
    {
        public string name;
        public string firstname;
        public string secondname;
        public string special;
        public int course;
        public string gender;
        public string time;
        public int group;
        public double ball;
        public string city;
        public string street;
        public string build;
        [Valid]
        public string flat;
        private Adding Create;

        public Students1(StudentFactory factory)
        {
            Create = factory.Create_student();
        }

        public void Add()
        {
            Create.Add(firstname, name, secondname, special, course, gender, time, group, ball, city, street, build, flat);
        }
    }
}

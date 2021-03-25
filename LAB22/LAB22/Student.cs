using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB22
{

     public interface Istudent
    {
        Istudent Clone();
    }
    [Serializable]
    public class Student 
    {
        public string name;
        [Required(ErrorMessage = "Фамилия не установлена")]
        public string firstname;
        public string secondname;
        public string special;
        public int course;
        public string gender;
        public string time;
        public int group;
        [Range(0, 100, ErrorMessage = "Недопустимый балл")]
        public double ball;
        public string city;
        public string street;
        public string build;
        [Valid]
        public string flat;

       
        public Student()
        {

        }
        
        public Student(string firstname, string name, string secondname, string special, int course, string gender, string time, int group, double ball, string city, string street, string build, string flat)
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
    [Serializable]
    public class Students : Istudent
    {
        public List<Student> studentlist = new List<Student>();
        public List<Student> studentlist1 = new List<Student>();

        public Students()
        {

        }

        public Students(List<Student> students)
        {
            studentlist1= students;
        }
        public Istudent Clone()
        {
            return new Students(this.studentlist);
        }
        
    }

    public class Valid : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string userName = value.ToString();
                if (userName == "0")
                {
                    this.ErrorMessage = "Не существует квартира 0";
                }
                else
                    return true;
            }
            return false;
        }
    }
}

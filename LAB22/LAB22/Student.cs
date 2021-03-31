using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB22
{ // паттерн адаптер
    public interface IFstudent
    {
        void ReadTo();
    }

    public interface IWorker
    {
        string name { get; set; }
        string secondname { get; set; }
        string position { get; set; }
        

        
    }

     public interface Istudent
    {
        Istudent Clone();
    }
    [Serializable]
    public class Student : IFstudent
    {
        public string name { get; set; }
        [Required(ErrorMessage = "Фамилия не установлена")]
        public string firstname { get; set; }
        public string secondname { get; set; }
        public string special { get; set; }
        public int course { get; set; }
        public string gender { get; set; }
        public string time { get; set; }
        public int group { get; set; }
        [Range(0, 100, ErrorMessage = "Недопустимый балл")]
        public double ball { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string build { get; set; }
        [Valid]
        public string flat { get; set; }

        public void ReadTo()
        {

        }
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

    public class Worker : IWorker
    {
        public string name { get; set; }
        public string secondname { get; set; }
        
        public string position { get; set; }
        
    }

    public class AboutpersonAdapt : IFstudent
    {
        Worker worker;
        Student Student;

        public AboutpersonAdapt(Worker _worker)
        {
            worker = _worker;
        }

        public AboutpersonAdapt(Student _Student)
        {
            Student = _Student;
        }

        public void ReadTo()
        {
            if(worker != null)
            {
                Console.WriteLine(worker.name + "\n" + worker.secondname + "\n" + worker.position);
            }
            if(Student != null)
            {
                Console.WriteLine(Student.name + "\n" + Student.secondname + "\n" + Student.special);
            }
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

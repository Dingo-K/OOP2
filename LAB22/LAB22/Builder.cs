using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB22
{
    class StudentBuilder
    {
        public FIO FIO;
        public Ball Ball;
        public Place Place;
        public Aboutgroup Aboutgroup;

        public StudentBuilder(string firstname, string name, string secondname, string special, int course, string gender, int group, double ball, string city, string street, string build, string flat)
        {
            FIO.firstname = firstname;
            FIO.name = name;
            FIO.secondname = secondname;
            Ball.ball = ball;
            Place.city = city;
            Place.build = build;
            Place.street = street;
            Place.flat = flat;
            Aboutgroup.course = course;
            Aboutgroup.group = group;
            Aboutgroup.special = special;
        }
    }


    class FIO
    {
        public string firstname;
        public string name;
        public string secondname;
        public string gender;
    }

    class Ball
    {
        public double ball;
    }

    class Place
    {
        public string city;
        public string build;
        public string street;
        public string flat;
    }

    class Aboutgroup
    {
        public int group;
        public int course;
        public string special;
    }
}

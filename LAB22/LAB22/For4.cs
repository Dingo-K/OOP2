using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB22
{
    class For4
    {
    }

    class Info
    {
        public Part_of_info part { get; set; }

        public void Start(string _name, int _width, int _height, string _color)
        {
            part = Part_of_info.getinstance(_name, _width, _height, _color);
        }
    }

    class Part_of_info
    {
        private static Part_of_info instance;
        public string name { get; private set; }
        public int width { get; private set; }
        public int height { get; private set; }
        public string color { get; private set; }
        private Part_of_info(string name, int width, int height, string color)
        {
            this.name = name;
            this.width = width;
            this.height = height;
            this.color = color;
        }

        public static Part_of_info getinstance(string name, int width, int height, string color)
        {
            if(instance == null)
            {
                instance = new Part_of_info(name,width,height,color);
            }

            return instance;
        }
    }
}

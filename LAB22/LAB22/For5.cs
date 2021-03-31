using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LAB22
{ // паттерн Command
    interface ISerial
    {
        void execute(Students students);
    }
    class Serial // получатель
    {

        public void XMLSerialize(Students students)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Students));

            using (FileStream fs = new FileStream("StudentsSort.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, students);
            }
        }
    }

    class SerCommand : ISerial // конкретная команда
    {
        Serial Serial;
        public SerCommand(Serial serial_)
        {
            Serial = serial_;
        }
        public void execute(Students students)
        {
            Serial.XMLSerialize(students);
        }
    }

    class Into // инициатор
    {
        ISerial Serial;
        public Into()
        {

        }

        public void SetCommand(ISerial serial_)
        {
            Serial = serial_;
        }

        public void Enter(Students students)
        {
            Serial.execute(students);
        }
    }
}

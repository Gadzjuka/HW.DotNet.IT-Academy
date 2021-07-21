using System;
using System.Collections.Generic;
using System.Text;

namespace HW07.Task2
{
    class Person
    {
        string _name;
        House _house;

        public Person()
        {
            _name = "Unknown";
            _house= new House();           
        }

        public Person(string name, House house)
        {
            _name = name;
            _house = house;
        }

        public Person(string name, int houseArea, string doorColor)
        {
            _name = name;
            _house = new House();
            _house.Area = houseArea;
            _house.Door.Color = doorColor;
        }

        public string Name { get => _name; set => _name = value; }
        internal House House { get => _house; set => _house = value; }

        public void ShowData()
        {
            Console.WriteLine($"I am {_name}");
            House.ShowData();
            House.GetDoor().ShowData();
        }
    }
}

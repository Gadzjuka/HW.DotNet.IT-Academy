using System;
using System.Collections.Generic;
using System.Text;

namespace HW07.Task2
{
    class House
    {
        protected Door _door;
        protected int _area;

        public House(Door door, int area)
        {
            _door = door;
            _area = area;
        }

        public House(string doorColor, int area)
        {
            _door = new Door();
            _door.Color = doorColor;
            _area = area;
        }

        public House()
        {
            _area = 200;
            _door = new Door();
        }

        public Door Door { get => _door; set => _door = value; }
        public int Area { get => _area; set => _area = value; }

        public void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {_area} m2");
        }

        public Door GetDoor()
        {
            return _door;
        }
    }
}

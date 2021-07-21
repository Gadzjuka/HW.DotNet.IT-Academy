using System;
using System.Collections.Generic;
using System.Text;

namespace HW07.Task2
{
    class Door
    {
        string _color;

        public Door()
        {
            _color = "transparent";
        }

        public Door(string color)
        {
            _color = color;
        }

        public string Color { get => _color; set => _color = value; }

        public void ShowData()
        {
            Console.WriteLine($"I am a door, my color is {_color}");
        }
    }
}

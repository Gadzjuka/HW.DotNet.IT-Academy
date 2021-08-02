using System;
using System.Collections.Generic;
using System.Text;

namespace HW07.Task1
{
    class Person
    {
        protected string _name = "Unknown";
        protected int _age = 16;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
        }
        public void SetAge(int age)
        {
            if (age > 16)
                _age = age;
            else
                Console.WriteLine("Incorrect age!");
        }
        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {_name}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HW07.Task1
{
    class Teacher : Person
    {
        private string _subject;
        public string Subject { get => _subject; set => _subject = value; }
        public void Explain()
        {
            Console.WriteLine("Explanation  begins");
        }
    }
}

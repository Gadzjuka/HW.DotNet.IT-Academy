using System;
using System.Collections.Generic;
using System.Text;

namespace HW07.Task3
{
    class Music : Item
    {
        private string _singer;
        private int _length;

        public Music()
        {
            this.Category = "unknown";
            this.Name = "unknown";
            this.Code = 0;
            this.Size = 0;
            this.Singer = "unknown";
            this.Length = 0;
        }

        public string Singer { get => _singer; set => _singer = value; }
        public int Length { get => _length; set => _length = value; }

        public void Play()
        {
            Console.WriteLine("Not implemented yet");
        }
        public void RetrieveInformation()
        {
            Console.WriteLine("Not implemented yet");
        }

        public void Show()
        {
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Category: {this.Category}");
            Console.WriteLine($"Size: {this.Size}");
            Console.WriteLine($"Singer: {this.Singer}");
            Console.WriteLine($"Length: {this.Length}");
        }
    }
}

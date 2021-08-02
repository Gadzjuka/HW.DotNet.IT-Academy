using System;
using System.Collections.Generic;
using System.Text;

namespace HW07.Task3
{
    class Film : Item
    {
        private string _director;
        private string _mainActor;
        private string _mainActress;

        public Film()
        {
            this.Category = "unknown";
            this.Name = "unknown";
            this.Code = 0;
            this.Size = 0;
            this.Director = "unknown";
            this.MainActor = "unknown";
            this.MainActress = "unknown";
        }

        public string Director { get => _director; set => _director = value; }
        public string MainActor { get => _mainActor; set => _mainActor = value; }
        public string MainActress { get => _mainActress; set => _mainActress = value; }

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
            Console.WriteLine($"Directror: {this.Director}");
            Console.WriteLine($"Main actor: {this.MainActor}");
            Console.WriteLine($"Main actress: {this.MainActress}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HW07.Task3
{
    class ComputerProgram : Item
    {
        public ComputerProgram()
        {
            this.Category = "unknown";
            this.Name = "unknown";
            this.Code = 0;
            this.Size = 0;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Category: {this.Category}");
            Console.WriteLine($"Size: {this.Size}");
        }
    }
}

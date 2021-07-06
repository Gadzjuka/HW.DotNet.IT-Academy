using System;
using System.Collections.Generic;
using System.Text;

namespace HW6.Task2
{
    internal class Motorcycle
    {
        Guid identifier;
        string model;
        string manufacturer;
        DateTime modelYear;
        int run;
        class Engine
        {
            short volume;
            short power;
            byte type;
        }
    }
}

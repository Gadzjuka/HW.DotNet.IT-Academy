using System;

namespace HW03.ReverseAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 90; i >= 65; i--)
            {
                Console.WriteLine($"{i-64}) { (char)i} {(char)(i+32)}" );                
            }
        }
    }
}

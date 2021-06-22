using System;

namespace ParseAndTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "112233";
            int x = int.Parse(number);
            int.TryParse(number, out int y);
        }
    }
}

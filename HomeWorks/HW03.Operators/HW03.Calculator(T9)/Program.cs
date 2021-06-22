using System;

namespace HW03.Calculator_T9_
{
    class Calculator
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine($"{a}+{b}={a+b}");
        }
        public void Subtraction(int a, int b)
        {
            Console.WriteLine($"{a}-{b}={a - b}");
        }
        public void Multiplication(int a, int b)
        {
            Console.WriteLine($"{a}х{b}={a * b}");
        }

        public void Division(int a, int b)
        {
            Console.WriteLine($"{a}/{b}={((double)a / b)}");
        }

        public void DivisionRemainder(int a, int b)
        {
            Console.WriteLine($"{a}%{b}={a % b}");
        }

        public void CircleArea(int a)
        {
            Console.WriteLine($"S=PI*D*D/4={Math.PI*Math.Pow(a,2)/4}");
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х для Convert:");
            int xConvert = GetNumberWithConvert();
            Console.WriteLine("Введите y для Convert:");
            int yConvert = GetNumberWithConvert();
            Console.WriteLine("Введите х для TryParse:");
            int xTryParse = GetNumberWithTryParse();
            Console.WriteLine("Введите y для TryParse:");
            int yTryParse = GetNumberWithTryParse();

            Calculator cal = new Calculator();
            cal.Sum(xConvert, yConvert);
            cal.Subtraction(xConvert, yConvert);
            cal.Multiplication(xConvert, yConvert);
            cal.Division(xTryParse, yTryParse);
            cal.DivisionRemainder(xTryParse, yTryParse);
            cal.CircleArea(xTryParse);


        }
        static int GetNumberWithConvert()
        {
            int number;
            while (true)
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    return number;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод. Повторите.");
                }
            }
        }

        static int GetNumberWithTryParse()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                    return number;
                else Console.WriteLine("Введенный символ не является числом, повторите попытку");
            }
        }
    }
}

using System;

namespace HW03.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            SumTwoNumbers();
        }

        //Запрос 2 переменных и вывод их суммы
        static void SumTwoNumbers()
        {
            double number1, number2;
            Console.WriteLine("Введите первое число:");
            number1 = GetNumberWithCheck();
            Console.WriteLine("Введите второе число:");
            number2 = GetNumberWithCheck();
            Console.WriteLine($"{number1}+{number2}={number1+number2}");
        }

        //Получение числа с проверкой на правильность ввода
        static double GetNumberWithCheck()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double number))
                    return number;
                else Console.WriteLine("Введенный символ не является числом, повторите попытку");
            }            
        }

    }
}

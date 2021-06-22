using System;

namespace HW03.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            SumTwoNumbers();
        }

        //Запрос 2 переменных и вывод их суммы (Задача 1)
        static void SumTwoNumbers()
        {
            double number1, number2, answer;
            Console.WriteLine("Введите первое число:");
            number1 = GetNumberWithCheck();
            Console.WriteLine("Введите второе число:");
            number2 = GetNumberWithCheck();
            Console.WriteLine("Введите сумму чисел:");
            answer = GetNumberWithCheck();

            if (answer == (number1 + number2)) Console.WriteLine("Правильно");
            else Console.WriteLine("Неправильно");
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

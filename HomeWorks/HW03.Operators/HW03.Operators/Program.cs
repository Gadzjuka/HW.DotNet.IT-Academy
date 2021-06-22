using System;

namespace HW03.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            SumTwoNumbers();
        }

        //Запрос 2 переменных и вывод их суммы (Задача 4)
        static void SumTwoNumbers()
        {
            double number1, number2, answer;
            char mathSimbol;
            Console.WriteLine("Введите первое число:");
            number1 = GetNumberWithCheck();
            Console.WriteLine("Введите второе число:");
            number2 = GetNumberWithCheck();
            Console.WriteLine("Введите символ \'+\' или \'-\':");
            mathSimbol = GetMathSimbolWithCheck();

            if (mathSimbol == '+')      //Если сумма (+)
            {
                Console.WriteLine("Введите сумму чисел:");
                answer = GetNumberWithCheck();
                Console.WriteLine($"{number1}+{number2}={number1 + number2}");
                if (answer == (number1 + number2)) Console.WriteLine("Правильно");
                else
                {
                    if (answer > (number1 + number2)) Console.WriteLine("Неправильно. Должно быть меньше.");
                    else Console.WriteLine("Неправильно. Должно быть больше.");
                }

            }
            else                        //Если разница (-)
            {
                Console.WriteLine("Введите разницу чисел:");
                answer = GetNumberWithCheck();
                Console.WriteLine($"{number1}-{number2}={number1 - number2}");
                if (answer == (number1 - number2)) Console.WriteLine("Правильно");
                else
                {
                    if (answer > (number1 - number2)) Console.WriteLine("Неправильно. Должно быть меньше.");
                    else Console.WriteLine("Неправильно. Должно быть больше.");
                }
            }     
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

        //Получение + или - с проверкой на правильность ввода
        static char GetMathSimbolWithCheck()
        {
            while (true)
            {
                if (char.TryParse(Console.ReadLine(), out char simbol))
                {
                    if (simbol == '+' || simbol == '-') return simbol;
                    else Console.WriteLine("Введенный символ не допустим");
                }
                else Console.WriteLine("Сочетание символов не допустимо");
            }
        }
    }
}

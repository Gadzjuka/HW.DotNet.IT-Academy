using System;

namespace HW03.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthOfBirth, yearOfBirth;
            int monthCurrent, yearCurrent;
            int age;


            Console.WriteLine("Введите месяц рождения:");
            while (true)
            {
                monthOfBirth = GetNumberWithCheck();
                if (monthOfBirth > 12 || monthOfBirth < 1) Console.WriteLine("Не существует такого месяца. Повторите ввод.");
                else break;
            }

            Console.WriteLine("Введите год рождения:");
            yearOfBirth = GetNumberWithCheck();

            Console.WriteLine("Введите месяц сегодняшнего дня:");
            while (true)
            {
                monthCurrent = GetNumberWithCheck();
                if (monthCurrent > 12 || monthCurrent < 1) Console.WriteLine("Не существует такого месяца. Повторите ввод.");
                else break;
            }

            Console.WriteLine("Введите год сегодняшнего дня:");
            yearCurrent = GetNumberWithCheck();

            if (yearCurrent < yearOfBirth) 
            {
                Console.WriteLine("Еще не родился");
                return;
            }

            if (monthCurrent < monthOfBirth) age = yearCurrent - yearOfBirth - 1;
            else age= yearCurrent - yearOfBirth;

            Console.WriteLine($"Возраст составил {age} годков");
        }

        static int GetNumberWithCheck()
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

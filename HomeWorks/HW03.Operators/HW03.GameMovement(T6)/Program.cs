using System;

namespace HW03.GameMovement_T6_
{
    class Program
    {
        static void Main(string[] args)
        {
            char result;
            Console.WriteLine("Для выхода нажмите Z");
            Console.WriteLine("Для движения нажмите W,A,S,D");

            do
            {
                result = GetCharWithCheck();
                switch (result)
                {
                    case 'a':
                    case 'A':
                        Console.WriteLine("Перемещаем фигуру влево.");
                        break;

                    case 'W':
                    case 'w':
                        Console.WriteLine("Перемещаем фигуру вверх.");
                        break;

                    case 'S':
                    case 's':
                        Console.WriteLine("Перемещаем фигуру вниз.");
                        break;

                    case 'D':
                    case 'd':
                        Console.WriteLine("Перемещаем фигуру вправо.");
                        break;

                    case 'Z':
                    case 'z':
                        Console.WriteLine("Хорошая игра. Всего доброго!");
                        break;


                    default: Console.WriteLine("Не перемещаем фигуру.");
                        break;
                }
            }
            while ((result != 'z')&(result != 'Z'));
            
        }

        static char GetCharWithCheck()
        {
            while (true)
            {
                if (char.TryParse(Console.ReadLine(), out char simbol))
                return simbol;
                   
                else Console.WriteLine("Сочетание символов не допустимо");
            }
        }
    }
}

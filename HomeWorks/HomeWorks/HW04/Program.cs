using System;
using System.Diagnostics;

namespace HW04
{
    class Program
    {
        static void Main(string[] args)
        {
            Task5();
        }

        static void Task1()
        {
            Console.WriteLine("Задача 1");
            int mSize = 5;
            Random rn = new Random();
            int[] massiv1 = new int[mSize];
            int[] massiv2 = new int[mSize];
            int[] massiv3 = new int[mSize];
            for (int i = 0; i < mSize; i++)
            {
                massiv1[i] = rn.Next(0, 10);
                Console.WriteLine("Введите число для второго массива:");
                massiv2[i] = GetNumberWithTryParse();
                massiv3[i] = massiv1[i] + massiv2[i];
            }
            Console.WriteLine("Результат:");
            for (int i = 0; i < mSize; i++)
            {
                Console.WriteLine($"1) {massiv1[i]};\t2) {massiv2[i]}\t3) {massiv3[i]}");
            }
        }

        static void Task2()
        {
            Console.WriteLine("Задача 2");
            Console.WriteLine("Введите размер массива:");
            int mSize = GetNumberWithTryParse();
            int possition, newElement;
            int[] massiv1 = new int[mSize];
            for (int i = 0; i < mSize - 1; i++)
            {
                Console.WriteLine("Введите число для массива:");
                massiv1[i] = GetNumberWithTryParse();
            }
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < mSize; i++)
            {
                Console.WriteLine(massiv1[i]);
            }

            Console.WriteLine("Введите позицию:");
            possition = GetNumberWithTryParse();
            Console.WriteLine("Введите новый элемент:");
            newElement = GetNumberWithTryParse();

            if (possition > mSize)
            {
                Console.WriteLine("В массиве нет такой позиции!");
                return;
            }

            for (int i = (mSize - 1); i >= possition; i--)
            {
                massiv1[i] = massiv1[i - 1];
            }
            massiv1[possition - 1] = newElement;
            Console.WriteLine("Новый массив:");
            for (int i = 0; i < mSize; i++)
            {
                Console.WriteLine(massiv1[i]);
            }

        }

        static void Task3()
        {
            Console.WriteLine("Задача 3");
            int[] massiv = new int[100000000];
            Random rnd = new Random();
            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = rnd.Next();
            }
            sw.Start();
            Array.Reverse(massiv);
            sw.Stop();
            Console.WriteLine($"Время для Revere(): {sw.ElapsedMilliseconds}");

            Array.Reverse(massiv);
            sw.Start();
            for (int i = 0; i < massiv.Length / 2; i++)
            {
                int buf = massiv[i];
                massiv[i] = massiv[massiv.Length - 1 - i];
                massiv[massiv.Length - 1 - i] = buf;
            }
            sw.Stop();
            Console.WriteLine($"Время для самодельного Reverse(): {sw.ElapsedMilliseconds}");

        }

        static void Task4()
        {
            Console.WriteLine("Задача 4");

            string poem;
            poem = Console.ReadLine();
            poem = poem.Replace('О', 'А');
            string[] poemArray = poem.Split(';');
            foreach (string str in poemArray)
            {
                Console.WriteLine(str);
            }
        }

        static void Task5()
        {
            Console.WriteLine("Задача 5");
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Task5_1(str);
            Task5_2(str);
            Task5_3(str);
            Task5_4(str);
        }

        static void Task5_1(string str)
        {
            int possition=0, size=0;
            string newStr="";
            string[] strArray = str.Split(' ');
            Console.WriteLine("Задача 5.1");
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Length > size)
                {
                    size = strArray[i].Length;
                    possition = i;
                }
            }

            for (int i=0; i<strArray.Length; i++)
            {
                if (i == possition) continue;
                newStr = newStr + strArray[i]+" ";
            }
            Console.WriteLine(newStr);
        }

        static void Task5_2(string str)
        {
            int possitionMin=0, possitionMax=0;
            int sizeMin=100, sizeMax=0;
            string newString="";
            Console.WriteLine("Задача 5.2");
            string[] strArray = str.Split(' ');
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Length > sizeMax)
                {
                    sizeMax = strArray[i].Length;
                    possitionMax = i;
                }
                if (strArray[i].Length < sizeMin)
                {
                    sizeMin = strArray[i].Length;
                    possitionMin = i;
                }
            }
            string buf = strArray[possitionMax];
            strArray[possitionMax] = strArray[possitionMin];
            strArray[possitionMin] = buf;

            for (int i = 0; i < strArray.Length; i++)
            {
                newString += strArray[i] + " ";
            }
            Console.WriteLine(newString);
        }

        static void Task5_3(string str)
        {
            int letterCount = 0, punctuationCount = 0;
            Console.WriteLine("Задача 5.3");
            foreach (char ch in str)
            {
                if (char.IsLetter(ch)) letterCount++;
                if (ch == '.' || ch == ',' || ch == '!' || ch == '?' || ch == ':' || ch == ';' || ch == '-')
                    punctuationCount++;                
            }
            Console.WriteLine($"Количство букв: {letterCount}; количество знаков препинания: {punctuationCount}");
        }

        static void Task5_4(string str)
        {
            string[] strArray = str.Split(' ');
            Console.WriteLine("Задача 5.4");
            for (int i =1; i<strArray.Length;i++)
            {
                for (int j = 0; j < strArray.Length - 1; j++)
                {
                    if (strArray[j].Length< strArray[j+1].Length)
                    {
                        string buf = strArray[j];
                        strArray[j] = strArray[j + 1];
                        strArray[j + 1] = buf;
                    }
                }
            }
            foreach (string s in strArray)
            {
                Console.WriteLine(s);
            }
        }


        static int GetNumberWithTryParse()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                    return number;
                else Console.WriteLine("Введенная строка не является числом, повторите попытку");
            }
        }
    }
}

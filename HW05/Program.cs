using System;
using System.Text;
using System.Collections.Generic;

namespace HW05
{
    struct Address          //for Task #4
    {
        public string house;
        public string street;
        public string zipcode;
        public Address(string house, string street, string zipcode)
        {
            this.house = house;
            this.street = street;
            this.zipcode = zipcode;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            Task4();
        }

        static void Task1()
        {
            Console.WriteLine("Задача 1");
            Console.WriteLine("Введите строку с цифрами и математическим знаком:");
            string str = Console.ReadLine();
            char math = ' ';
            long x = 0, y = 0;
            int mathPosition = str.Length;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '*' || str[i] == '/' || str[i] == '+' || str[i] == '-')
                {
                    math = str[i];
                    mathPosition = i;
                }
                if (i < mathPosition && Char.IsDigit(str[i]))
                {
                    x = x * 10 + int.Parse(str[i].ToString());
                }
                if (i > mathPosition && Char.IsDigit(str[i]))
                {
                    y = y * 10 + int.Parse(str[i].ToString());
                }

            }
            switch (math)
            {
                case '+': Console.WriteLine($"{x}+{y}={x + y}"); break;
                case '-': Console.WriteLine($"{x}-{y}={x - y}"); break;
                case '*': Console.WriteLine($"{x}*{y}={x * y}"); break;
                case '/': Console.WriteLine($"{x}/{y}={((double)x / y)}"); break;
                default: Console.WriteLine("Нет математического знака!"); break;
            }

        }

        static void Task2()
        {
            Console.WriteLine("Задача 2");
            Console.WriteLine("Введите строку с ?");
            StringBuilder str = new StringBuilder(Console.ReadLine());
            int possitionQuestion = str.Length;


            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '?')
                {
                    possitionQuestion = i;
                }

                if (i < possitionQuestion)      //before '?'
                {
                    if (str[i] == '!' || str[i] == '.')
                    {
                        str.Remove(i, 1);
                        i--;
                        possitionQuestion--;
                    }
                }
                else                            //after '?'
                {
                    if (str[i] == ' ')
                    {
                        str[i] = '_';
                    }
                }
            }

            Console.WriteLine(str);
        }

        static void Task3()
        {
            Console.WriteLine("Задача 3");
            Console.WriteLine("Заполните 2 массива:");
            string[] str1 = ArrayOfString();
            string[] str2 = ArrayOfString();
            string[] sum;
            List<string> stringList = new List<string>();

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str2[j].Contains(str1[i]))
                    {
                        stringList.Add(str1[i]);
                        break;
                    }
                }
            }
            if (stringList.Count != 0)
            {
                stringList.Sort();
                sum = stringList.ToArray();
                Console.WriteLine("Следующие элементы вошли в итоговый массив:");
                foreach (string str in sum)
                {
                    Console.WriteLine(str);
                }
            }
            else Console.WriteLine("Ни один элемент массива №1 не вошел в массив №2!");
        }

        static void Task4()
        {
            Console.WriteLine("Задача 4");
            Console.WriteLine("Введите строку с адресами:");
            string addresses = Console.ReadLine();
            Console.WriteLine("Введите zipcode:");
            string zipcode = Console.ReadLine();
            Console.WriteLine(Travel(addresses, zipcode));
        }

        static string Travel(string addresses, string zipcode)
        {
            string sortedAddresses = zipcode + ":/";
            string[] singleAddress = addresses.Split(',');
            Address[] adrs = new Address[singleAddress.Length];

            for (int i = 0; i < singleAddress.Length; i++)
            {
                int j = 0;
                for (j = 0; j < singleAddress[i].Length; j++)
                {
                    if (!char.IsDigit(singleAddress[i][j])) break;
                }

                adrs[i].house = singleAddress[i].Substring(0, j);
                adrs[i].street = singleAddress[i].Substring(j + 1, singleAddress[i].Length - 10 - j);
                adrs[i].zipcode = singleAddress[i].Substring(singleAddress[i].Length - 8, 8);
            }

            string streets = "", houses = "";
            foreach (Address temp in adrs)
            {
                if (temp.zipcode == zipcode)
                {
                    streets += temp.street + ",";
                    houses += temp.house + ",";
                }
            }
            if (streets == "")
            {
                return sortedAddresses;
            }
            else return (zipcode + ":" + streets.Substring(0, streets.Length - 1) + "/" + houses.Substring(0, houses.Length - 1));
        }

        static string[] ArrayOfString()                 //get string array
        {
            Console.WriteLine("Введите размер массива:");
            int size = GetIntWithTryParse();
            string[] arStr = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Введите элемент строкового массива:");
                arStr[i] = Console.ReadLine();
            }
            return arStr;
        }
        static int GetIntWithTryParse()                 //get int
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                    return number;
                else Console.WriteLine("Неправильный ввод! Повторите:");
            }
        }
    }
}



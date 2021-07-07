using System;

namespace Motorcycle
{
    class Program
    {
        static void Main(string[] args)
        {         
            Motorcycle[] motorcycles = new Motorcycle[3];
            Motorcycle.Engine[] engines = new Motorcycle.Engine[3];
            for (int i = 0; i < 3; i++)
            {
                motorcycles[i] = GetMoto();
                engines[i] = GetEngine();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i+1}.\t");
                Console.WriteLine($"Мотоцикл(производитель):\"{motorcycles[i].manufacturer}\", Модель: \"{motorcycles[i].model}\", Vin Number (Индентификатор): \"{motorcycles[i].identifier}\", Год: {motorcycles[i].modelYear.Year}");
                Console.Write($"\t{i+1}.1");
                Console.WriteLine($"Двигатель(объем): {engines[i].volume}, Мощность: {engines[i].power}");
                Console.WriteLine();
            }
        }

        static Motorcycle GetMoto()
        {
            Motorcycle moto = new Motorcycle();
            string buf;
            int bufInt;
            Console.WriteLine($"Введите параметры мотоцикла:");
            Console.Write("Производитель:");
            buf=Console.ReadLine();
            if (!string.IsNullOrEmpty(buf)) moto.manufacturer = buf;
            else Console.WriteLine("Нельзя пустую строку!");

            Console.Write("Модель:");
            buf = Console.ReadLine();
            if (!string.IsNullOrEmpty(buf)) moto.model = buf;
            else Console.WriteLine("Нельзя пустую строку!");

            Console.Write("Пробег (0-100km):");
            bufInt = GetNumberWithTryParse();
            if (bufInt > 100|| bufInt < 0)
                Console.WriteLine("Пробег не больше 100 и не меньше 0");
            else moto.run = bufInt;
            
            return moto;
        }

        static Motorcycle.Engine GetEngine()
        {
            short buf;
            Motorcycle.Engine eng = new Motorcycle.Engine();
            Console.Write("Объем (125-3200сс):");
            buf = GetShortWithTryParse();
            if (buf<125||buf>3200 ) Console.WriteLine("Пробег не больше 3200 и не меньше 125");
            else eng.volume = buf;
            
            Console.Write("Мощность (50-300hp):");
            buf = GetShortWithTryParse();
            if (buf < 50 || buf > 300) Console.WriteLine("Мощность не больше 300 и не меньше 50");
            else eng.power = buf;
            return eng;
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

        static short GetShortWithTryParse()
        {
            while (true)
            {
                if (short.TryParse(Console.ReadLine(), out short number))
                    return number;
                else Console.WriteLine("Введенная строка не является числом, повторите попытку");
            }
        }
    }
}

using System;

namespace HW07.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerProgram[] computerPrograms = new ComputerProgram[5];
            Film[] films = new Film[5];
            Music[] musics = new Music[5];
            for (int i = 0; i < 5; i++)
            {
                computerPrograms[i] = NewComputerProgram();
                computerPrograms[i].Show();
                Console.WriteLine();
                films[i] = NewFilm();
                films[i].Show();
                Console.WriteLine();
                musics[i] = NewMusic();
                musics[i].Show();
                Console.WriteLine();
            }


        }

        static ComputerProgram NewComputerProgram()
        {
            Random rnd = new Random();
            ComputerProgram buf = new ComputerProgram();
            buf.Name = Faker.Name.FullName();
            buf.Category = "Computer program";
            buf.Size = rnd.NextDouble() * 1000;
            buf.Code = rnd.Next();
            return buf;
        }
        static Film NewFilm()
        {
            Random rnd = new Random();
            Film buf = new Film();
            buf.Name = Faker.Name.FullName();
            buf.Category = "Film";
            buf.Size = rnd.NextDouble() * 100;
            buf.Code = rnd.Next();
            buf.MainActor = Faker.Name.FullName();
            buf.MainActress = Faker.Name.FullName();
            buf.Director = Faker.Name.FullName();
            return buf;
        }
        static Music NewMusic()
        {
            Random rnd = new Random();
            Music buf = new Music();
            buf.Name = Faker.Name.FullName();
            buf.Category = "Computer program";
            buf.Size = rnd.NextDouble() * 10;
            buf.Code = rnd.Next();
            buf.Singer = Faker.Name.FullName();
            buf.Length = rnd.Next(150, 600);
            return buf;
        }
    }
}

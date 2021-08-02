using System;


namespace HW07.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Khodzin Ilya", 175, "red");
            person.ShowData();
            Console.WriteLine();

            Door door = new Door("blue");
            SmallApartment smallApartment = new SmallApartment(door);
            Person person1 = new Person("Stiv Maki", smallApartment);
            person1.ShowData();
        }
    }
}

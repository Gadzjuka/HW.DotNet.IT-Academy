using System;
using System.Collections.Generic;

namespace HW07.Booking.Com
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> persons = new List<User>();
            List<Room> rooms = new List<Room>();
            List<Apartment> apartments = new List<Apartment>();

            for (int i = 0; i < 5; i++)
            {
                persons.Add(NewUser());
                rooms.Add(NewRoom());
                apartments.Add(NewApartment());
            }

            Booking book = new Booking();
            BookingLogic(persons, rooms, apartments, ref book);
            book.ShowInformation();
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                if (persons[i].Id == book.UserID)
                {
                    persons[i].ShowUserInformation();
                    Console.WriteLine();
                }

                if (rooms[i].Id == book.PlaceID)
                {
                    rooms[i].ShowRoomInformation();
                    Console.WriteLine($"Total price: {rooms[i].PricePerPeriod((book.EndDate - book.StartDate).Days)}");
                    Console.WriteLine();
                }

                if (apartments[i].Id == book.PlaceID)
                {
                    apartments[i].ShowApartmentInformation();
                    Console.WriteLine($"Total price: {apartments[i].PricePerPeriod((book.EndDate - book.StartDate).Days)}");
                    Console.WriteLine();
                }
            }
        }

        private static void BookingLogic(List<User> persons, List<Room> rooms, List<Apartment> apartments, ref Booking book)
        {
            book.StartDate = DateTime.Today.AddDays(5);
            book.EndDate = DateTime.Today.AddDays(15);
            book.PlaceID = rooms[2].Id;
            rooms[2].ChangeAccessibilityFalse();
            book.UserID = persons[4].Id;
            book.PerconAmount = 1;
        }

        static User NewUser()
        {
            User user = new User();
            user.FirstName = Faker.Name.First();
            user.LastName = Faker.Name.Last();
            user.Email = Faker.Internet.Email();
            user.Login = Faker.Internet.UserName();
            user.ChangePassword(Faker.Identification.BulgarianPin());
            return user;
        }

        static Room NewRoom()
        {
            Random rnd = new Random();
            Room room = new Room();
            room.Name = Faker.Name.First();
            room.City = Faker.Address.City();
            room.Street = Faker.Address.StreetName();
            room.NumgerHouse = rnd.Next().ToString();
            room.Price = rnd.Next(10, 50);
            room.RoomNumber = rnd.Next(0, 500);
            room.BedAmount = rnd.Next(0, 4);
            return room;
        }
        static Apartment NewApartment()
        {
            Random rnd = new Random();
            Apartment room = new Apartment();
            room.Name = Faker.Name.First();
            room.City = Faker.Address.City();
            room.Street = Faker.Address.StreetName();
            room.NumgerHouse = rnd.Next().ToString();
            room.Price = rnd.Next(10, 50);
            room.Area = rnd.Next(50, 200);
            return room;
        }
    }
}

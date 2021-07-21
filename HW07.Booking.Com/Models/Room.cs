using System;
using System.Collections.Generic;
using System.Text;

namespace HW07.Booking.Com
{
    class Room : Place
    {
        private int _roomNumber;
        private int _bedAmount;

        public int RoomNumber { get => _roomNumber; set => _roomNumber = value; }
        public int BedAmount { get => _bedAmount; set => _bedAmount = value; }

        public Room()
        {
            id = Guid.NewGuid();
            city = "unknown";
            street = "unknown";
            numberHouse = "unknown";
            pricePerDay = 0;
            accessibility = true;
            name = "unknown";
            RoomNumber = 0;
            BedAmount = 1;
        }

        public Room(string city, string street, string number, int pricePerDay, string name, int roomNumber, int bedCount)
            : base(city, street, number, pricePerDay, name)
        {
            id = Guid.NewGuid();
            accessibility = true;
            RoomNumber = roomNumber;
            BedAmount = bedCount;
        }

        public void ShowRoomInformation()
        {
            Console.WriteLine($"Room information:");
            Console.WriteLine($"Room ID: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Adress: {city}, {street}, {numberHouse}");
            Console.WriteLine($"Room number: {RoomNumber}");
            Console.WriteLine($"Bed amount: {BedAmount}");
            Console.WriteLine($"Price per day: {pricePerDay} USD");
        }

    }
}

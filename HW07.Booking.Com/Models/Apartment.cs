using System;
using System.Collections.Generic;
using System.Text;

namespace HW07.Booking.Com
{
    class Apartment : Place
    {
        private int _area;

        public Apartment()
        {
            id = Guid.NewGuid();
            city = "unknown";
            street = "unknown";
            numberHouse = "unknown";
            pricePerDay = 0;
            accessibility = true;
            name = "unknown";
            _area = 0;
        }

        public Apartment(string city, string street, string number, int pricePerDay, string name, int area)
            : base(city, street, number, pricePerDay, name)
        {
            id = Guid.NewGuid();
            accessibility = true;
            _area = area;
        }

        public int Area { get => _area; set => _area = value; }

        public void ShowApartmentInformation()
        {
            Console.WriteLine($"Apartment information:");
            Console.WriteLine($"Apartment ID: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Adress: {city}, {street}, {numberHouse}");
            Console.WriteLine($"Apartment area: {_area}");
            Console.WriteLine($"Price per day: {pricePerDay} USD");
        }
    }
}

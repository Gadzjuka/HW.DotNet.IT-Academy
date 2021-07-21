using System;
using System.Collections.Generic;
using System.Text;

namespace HW07.Booking.Com
{
    class Place
    {
        protected Guid id;
        protected string city;
        protected string street;
        protected string numberHouse;
        protected int pricePerDay;
        protected bool accessibility;
        protected string name;

        public Place()
        {
            id = Guid.NewGuid();
            city = "unknown";
            street = "unknown";
            numberHouse = "unknown";
            pricePerDay = 0;
            accessibility = true;
            name = "unknown";
        }

        public Place(string city, string street, string number, int pricePerDay, string name)
        {
            this.id = Guid.NewGuid();
            this.city = city;
            this.street = street;
            this.numberHouse = number;
            this.pricePerDay = pricePerDay;
            this.accessibility = true;
            this.name = name;
        }

        public Guid Id { get => id; protected set => id = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public string NumgerHouse { get => numberHouse; set => numberHouse = value; }
        public int Price { get => pricePerDay; set => pricePerDay = value; }
        public bool Accessibility { get => accessibility; protected set => accessibility = value; }
        public string Name { get => name; set => name = value; }

        public void ChangeAccessibilityTrue()
        {
            accessibility = true;
        }
        public void ChangeAccessibilityFalse()
        {
            accessibility = true;
        }

        public int PricePerPeriod(int days)
        {
            return pricePerDay * days;
        }
    }
}

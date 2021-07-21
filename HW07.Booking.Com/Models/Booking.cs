using System;
using System.Collections.Generic;
using System.Text;

namespace HW07.Booking.Com
{
    class Booking
    {
        private Guid _placeID;
        private Guid _userID;
        private DateTime _startDate;
        private DateTime _endDate;
        private byte _perconAmount;

        public Booking(Guid placeID, Guid userID, DateTime startDate, DateTime endDate, byte perconAmount)
        {
            _placeID = placeID;
            _userID = userID;
            _startDate = startDate;
            _endDate = endDate;
            _perconAmount = perconAmount;
        }

        public Booking()
        {
            _placeID = Guid.Empty;
            _userID = Guid.Empty;
            _startDate = DateTime.Today;
            _endDate = DateTime.Today;
            _perconAmount = 0;
        }

        public Guid PlaceID { get => _placeID; set => _placeID = value; }
        public Guid UserID { get => _userID; set => _userID = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public DateTime EndDate { get => _endDate; set => _endDate = value; }
        public byte PerconAmount { get => _perconAmount; set => _perconAmount = value; }

        public void ShowInformation()
        {
            Console.WriteLine($"Booking information:");
            Console.WriteLine($"Place ID: {_placeID}");
            Console.WriteLine($"User ID: {_userID}");
            Console.WriteLine($"Start date: {_startDate}");
            Console.WriteLine($"End date: {_endDate}");
            Console.WriteLine($"Persons amount: {_perconAmount}");
        }
    }
}

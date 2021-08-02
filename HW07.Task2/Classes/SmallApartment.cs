using System;
using System.Collections.Generic;
using System.Text;

namespace HW07.Task2
{
    class SmallApartment : House
    {
        public SmallApartment()
        {
            _area = 50;
        }
        public SmallApartment(Door door)
        {
            _area = 50;
            _door = door;
        }

        public SmallApartment(Door door, int area) : base(door, area)
        {
            _area = area;
            _door = door;
        }        
    }
}

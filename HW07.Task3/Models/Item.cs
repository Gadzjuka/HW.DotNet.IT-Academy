using System;
using System.Collections.Generic;
using System.Text;

namespace HW07.Task3
{
    class Item
    {
        protected string _name;
        protected int _code;
        protected string _category;
        protected double _size;

        public string Name { get => _name; set => _name = value; }
        public int Code { get => _code; set => _code = value; }
        public string Category { get => _category; set => _category = value; }
        public double Size { get => _size; set => _size = value; }
    }
}

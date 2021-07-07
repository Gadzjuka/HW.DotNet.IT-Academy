using System;
using System.Collections.Generic;
using System.Text;

namespace Motorcycle
{
    internal class Motorcycle
    {
        public readonly Guid identifier;
        public string model { set; get; }
      

        public string manufacturer { set; get; }


        public DateTime modelYear { get; }
        public int run { set; get; }

        public Motorcycle()
        {
            this.identifier = Guid.NewGuid();           
            this.modelYear = DateTime.Today;
            this.model = "Не указан";
            this.manufacturer = "Не указан";
            this.run = 0;
        }


        internal class Engine
        {
            public short volume { set; get; }

            public short power { set; get; }

            public byte type;

            public Engine()
            {
                volume = 0;
                power = 0;
                type = 0;
            }
        }        
    }
}

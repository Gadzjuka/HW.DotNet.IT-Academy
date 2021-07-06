using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class Motorcycle
    {
        const ushort MaxSpeedPrivate = 20;        //он же private по умолчанию
        public const ushort MaxSpeedPublic = 30;
        protected const ushort MaxSpeedProtected = 40;
        internal const ushort MaxSpeedInternal = 50;
        protected internal const ushort MaxSpeedProtectedInternal = 60;
        private protected const ushort MaxSpeedPrivateProtected = 70;

        int odometer = 20_000;                  //он же private по умолчанию
        public int odometerPublic = 21000;
        protected int odometerProtected = 22000;
        internal int odometerInternal = 23000;
        protected internal int odometerProtectedInternal = 24000;
        private protected int odometerPrivateProtected = 25000;

        
        public int Odometer { get => odometer; set => odometer = value; }
        private int OdometerPrivate { get => odometerPublic; set => odometerPublic = value; }

        void StartEngine()                      //он же private по умолчанию
        {
            Console.WriteLine(Odometer);
        }

        public void StartEnginePublic() => Console.WriteLine(Odometer);
        protected void StartEngineProtected() => Console.WriteLine(Odometer);
        internal void StartEngineInternal() => Console.WriteLine(Odometer);
        protected internal void StartEngineProtectedInternal() => Console.WriteLine(Odometer);
        private protected void StartEnginePrivateProtected() => Console.WriteLine(Odometer);
    }

    class SportBike : Motorcycle 
    {
        public int OdometerPublic { get => odometerPublic; set => odometerPublic = value; }
        public int OdometerInternal { get => odometerInternal; set => odometerInternal = value; }
        //public int OdometerPrivate { get => odometer; set => odometer = value; }      Не доступен т.к. private
        public int Odometr { get => odometerProtected; set => odometerProtected = value; }

        
    }

    class MotorcycleInternal    //он же Internal по умолчанию
    {
        const ushort MaxSpeed = 123;
        public int odometer = 123_456;
    }

    /*private class MotorcyclePrivate    //Нельзя protected, private, protected internal and private protected
    {
        const ushort MaxSpeed = 300;
        int odometer = 20_000;
    }*/
}

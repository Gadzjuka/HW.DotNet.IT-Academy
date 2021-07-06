using System ;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle mt = new Motorcycle();
            Console.WriteLine(Motorcycle.MaxSpeedPublic);
            Console.WriteLine(Motorcycle.MaxSpeedInternal);
            //Console.WriteLine(Motorcycle.MaxSpeedProtected);          Ошибка, получить доступ нельзя
            //Console.WriteLine(Motorcycle.MaxSpeedPrivate);            Ошибка, получить доступ нельзя
            Console.WriteLine(Motorcycle.MaxSpeedProtectedInternal);
            //Console.WriteLine(Motorcycle.MaxSpeedPrivateProtected);   Ошибка, получить доступ нельзя

            mt.odometerPublic = 13;
            //mt.odometer = 13;                 Ошибка, получить доступ нельзя
            //mt.odometerProtected = 14;        Ошибка, получить доступ нельзя
            mt.odometerInternal = 15;
            mt.odometerProtectedInternal = 16;
            //mt.odometerPrivateProtected = 17; Ошибка, получить доступ нельзя

            mt.Odometer = 12;
            //mt.OdometerPrivate = 15;          Ошибка, получить доступ нельзя

            mt.StartEnginePublic();
            mt.StartEngineInternal();
            //mt.StartEngineProtected();        Ошибка, получить доступ нельзя
            //mt.StartEngine();                 Ошибка, получить доступ нельзя
            mt.StartEngineProtectedInternal();
            //mt.StartEnginePrivateProtected(); Ошибка, получить доступ нельзя

            Console.WriteLine("SportBike!");
            SportBike sb = new SportBike();
            Console.WriteLine(SportBike.MaxSpeedPublic);
            Console.WriteLine(SportBike.MaxSpeedInternal);
            //Console.WriteLine(SportBike.MaxSpeedProtected);          Ошибка, получить доступ нельзя
            //Console.WriteLine(SportBike.MaxSpeedPrivate);            Ошибка, получить доступ нельзя
            Console.WriteLine(SportBike.MaxSpeedProtectedInternal);
            //Console.WriteLine(SportBike.MaxSpeedPrivateProtected);   Ошибка, получить доступ нельзя

            sb.odometerPublic = 30;
            //sb.odometer = 13;                 Ошибка, получить доступ нельзя
            //sb.odometerProtected = 14;        Ошибка, получить доступ нельзя
            sb.odometerInternal = 15;
            sb.odometerProtectedInternal = 16;
            //sb.odometerPrivateProtected = 17; Ошибка, получить доступ нельзя

            sb.Odometer = 70;
            //sb.OdometerPrivate = 15;          Ошибка, получить доступ нельзя

            sb.StartEnginePublic();
            sb.StartEngineInternal();
            //sb.StartEngineProtected();        Ошибка, получить доступ нельзя
            //sb.StartEngine();                 Ошибка, получить доступ нельзя 
            sb.StartEngineProtectedInternal();
            //sb.StartEnginePrivateProtected();




            MotorcycleInternal mci = new MotorcycleInternal();
            mci.odometer = 654321;
        }
    }
}

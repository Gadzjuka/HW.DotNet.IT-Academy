using System;
using AssemblyOne;
namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle mt = new Motorcycle();
            Console.WriteLine(Motorcycle.MaxSpeedPublic);
            
            /*Console.WriteLine(Motorcycle.MaxSpeedInternal);           не та сборка
            Console.WriteLine(Motorcycle.MaxSpeedProtected);            только внутри типа          
            Console.WriteLine(Motorcycle.MaxSpeedPrivate);              не наследуется и только внутри типа
            Console.WriteLine(Motorcycle.MaxSpeedProtectedInternal);    только внутри типа и сборки
            Console.WriteLine(Motorcycle.MaxSpeedPrivateProtected);     только в определающем типе*/

            mt.odometerPublic = 13;
            /* mt.odometer = 13;                 только внутри типа т.к. по умолчанию private               
             mt.odometerProtected = 14;          только внтри типа
             mt.odometerInternal = 15;           не та сборка
             mt.odometerProtectedInternal = 16;  только внутри типа
             mt.odometerPrivateProtected = 17;   только внутри типа и не та сборка*/

            mt.Odometer = 12;
            //mt.OdometerPrivate = 15;          только внутри типа 

            mt.StartEnginePublic();
            /*mt.StartEngineInternal();           не та сборка
            mt.StartEngineProtected();          только внутри типа
            mt.StartEngine();                   только внутри типа т.к. по умолчанию private
            mt.StartEngineProtectedInternal();  не та сборка
            mt.StartEnginePrivateProtected();   только внутри типа и не та сборка*/

            Console.WriteLine("SportBike!");

            /* т.к. при создании класса по умолчанию internal
             * В этой сборке работать не будет!!!!!!!!!
             * SportBike sb = new SportBike();
            Console.WriteLine(SportBike.MaxSpeedPublic);
            Console.WriteLine(SportBike.MaxSpeedInternal);
            Console.WriteLine(SportBike.MaxSpeedProtected);          
            Console.WriteLine(SportBike.MaxSpeedPrivate);            
            Console.WriteLine(SportBike.MaxSpeedProtectedInternal);
            Console.WriteLine(SportBike.MaxSpeedPrivateProtected);   

            sb.odometerPublic = 30;
            sb.odometer = 13;                 
            sb.odometerProtected = 14;        
            sb.odometerInternal = 15;
            sb.odometerProtectedInternal = 16;
            sb.odometerPrivateProtected = 17; 

            sb.Odometer = 70;
            sb.OdometerPrivate = 15;          

            sb.StartEnginePublic();
            sb.StartEngineInternal();
            sb.StartEngineProtected();        
            sb.StartEngine();                 
            sb.StartEngineProtectedInternal();
            sb.StartEnginePrivateProtected();*/
            
        }
    }
}

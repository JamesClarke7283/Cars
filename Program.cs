using System;

namespace VehicleEngineLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars car = new Cars();
            Console.WriteLine(car.GetMakeName());
            Console.WriteLine("Hello World!");
        }
    }
}

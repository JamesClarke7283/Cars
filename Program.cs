using System;

namespace VehicleEngineLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int carNum = 0;

            Cars[] cars = new Cars[]
            {
                new Cars("Honda", "Civic", 55),
                new Cars("Ford", "Ka", 45),
                new Cars("Audio", "A4", 62),
            };
            int carIndex = 0;
            foreach (Cars carItem in cars)
            {
                Console.WriteLine($"{carIndex}.\s"+carItem);
                carIndex++;
            }

            Console.WriteLine("Enter car:  ");
            carNum = Console.ReadLine();
        }

    }
     

}

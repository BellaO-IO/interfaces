using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("carrrrsssss");

            var suv = new SUV();
            var car = new Cars();
            var truck = new Truck();

            suv.Model = "SuvCar";
            suv.Make = "SuvMake";
            suv.Year = 2090;
            suv.FourWheelDrive = false;

            car.Model = "CarModel";
            car.Make = "CarMake";
            car.Year = 2000;
            car.IsElectric = true;

            truck.BedSize = 90;
            truck.Model = "Truck";


        }
    }
}

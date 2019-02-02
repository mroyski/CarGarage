using System;
using System.Collections.Generic;

namespace CarGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            garage.TitleScreen();

            garage.AddCar("Chevrolet", "Corvette", "Car is off", 0, 100);
            garage.AddCar("Toyota", "Corolla", "Car is off", 0, 100);
            garage.AddCar("Lamborghini", "Centenario", "Car is off", 0, 100);

            garage.ListAllCars();


            //garage.GarageCars[0].Accelerate();
            //Console.WriteLine(garage.GarageCars[0].Fuel);
            Console.ReadKey();
        }
    }
}

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
            garage.AddCar("Lamborghini", "Centenario", "Car is off", 0, 100);
            garage.AddCar("Chevrolet", "Corvette", "Car is off", 0, 100);
            garage.AddCar("Toyota", "Corolla", "Car is off", 0, 100);

            garage.ListAllCars();

            Console.WriteLine("Type Id to select Car");
            int index = Convert.ToInt32(Console.ReadLine());
            garage.Select_Car(index);

            garage.TestDrive();
            
            Console.ReadKey();
        }

        
    }
}

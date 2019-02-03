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

            Console.WriteLine("Enter 1 for a list of cars");
            Console.WriteLine("Enter 2 to select car");
            bool flag = true;
            while (flag)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Type ID to select car");
                        int index = Convert.ToInt32(Console.ReadLine());
                        SubMenu(gar(index));
                        garage.Select_Car(index);
                        break;
                    case "2":
                        garage.ListAllCars();
                        Console.WriteLine("Type ID to select car");
                        break;
                    case "0":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Something went wrong");
                        break;
                }
            }
        }
        static void SubMenu(Garage garage)
        {
            bool flag = true;
            while (flag)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Type ID to select car");
                        int index = Convert.ToInt32(Console.ReadLine());
                        garage.Select_Car(index);
                        break;
                    case "2":
                        garage.ListAllCars();
                        Console.WriteLine("Type ID to select car");
                        break;
                    case "0":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Something went wrong");
                        break;
                }

            }
        }
    }
}
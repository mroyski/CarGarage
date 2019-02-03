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

            bool flag = true;
            while (flag)
            {
                Console.Clear();
                garage.GarageScreen();
                Console.WriteLine("1.Choose a car to drive\n2.Refuel all cars\n3.Add a car\n4.Remove a car\n5.List all cars\n0.Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        garage.ListAllCars();
                        Console.WriteLine("Type ID to select car");
                        int id = Convert.ToInt32(Console.ReadLine());
                        SubMenu(garage.Select_Car(id));
                        break;
                    case "2":
                        garage.FuelAllCars();
                        Console.WriteLine("All cars are fueled up and ready to go!");
                        Console.ReadKey();
                        break;
                    case "3":
                        garage.AddNewCar("{0}", "{1}", 0, 100);
                        break;
                    case "4":
                        garage.RemoveCar();
                        break;
                    case "5":
                        garage.ListAllCars();
                        Console.ReadKey();
                        break;
                    case "0":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Something went wrong.");
                        break;
                }
            }
        }
        static void SubMenu(Car oneCar)
        {
            Console.WriteLine("Selected Car is {0} {1}", oneCar.Make, oneCar.Model);
            Console.ReadKey();
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                TestDriveScreen();
                Console.WriteLine("1.Toggle engine\n2.Accelerate\n3.Brake\n4.Fill gas tank\n5.Car info\n0.Return to garage");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1": //start
                        oneCar.ToggleEngine();
                        Console.ReadKey();
                        break;
                    case "2"://accelerate
                        if (oneCar.Running == true)
                        {
                            oneCar.Accelerate();
                            Console.WriteLine("Speed is {0}", oneCar.Speed);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Your car is not running.");
                            Console.ReadKey();
                        }
                        break;
                    case "3"://brake
                        if (oneCar.Running == true)
                        {
                            oneCar.Brake();
                            Console.WriteLine("Speed is {0}", oneCar.Speed);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Your car is not running.");
                            Console.ReadKey();
                        }
                        break;
                    case "4"://AddFuel
                        if (oneCar.Running == false)
                        {
                            oneCar.AddFuel();
                            Console.WriteLine("Fuel tank is at " + oneCar.Fuel + "%");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Stop your car before refueling.");
                            Console.WriteLine("Fuel tank is at " + oneCar.Fuel + "%");
                            Console.ReadKey();
                        }
                        break;
                    case "5":
                        Console.WriteLine("{0} {1} \nSpeed : {2}mph\nFuel : {3}\n",oneCar.Make,oneCar.Model, oneCar.Speed, oneCar.Fuel);
                        Console.ReadKey();
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
        public static void TestDriveScreen()
        {
            Console.WriteLine(@" ____________________  ___  ___  _____   ______
/_  __/ __/ __/_  __/ / _ \/ _ \/  _/ | / / __/
 / / / _/_\ \  / /   / // / , _// / | |/ / _/  
/_/ /___/___/ /_/   /____/_/|_/___/ |___/___/  
                                               ");
        }
    }
}
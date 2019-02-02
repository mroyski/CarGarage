using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Garage
    {
        public List<Car> GarageCars { get; set; }
        public Car CurrentCar { get; set; }

        public Garage()
        {
            GarageCars = new List<Car>();
        }

        public void CarPick()
        {
            //Console.WriteLine("Choose your ride!");
            //Console.WriteLine("Type the number and press ENTER");
            //Car currentCar;
            //string carChoice = Console.ReadLine();

            //if (carChoice == "1")
            //{
            //    currentCar = GarageCars[0];
            //}
            //else if (carChoice == "2")
            //{
            //    currentCar = GarageCars[1];
            //}
            //else if (carChoice == "3")
            //{
            //    currentCar = GarageCars[2];
            //}
            //else currentCar = GarageCars[0];

        }

        public void TestDrive()
        {
            bool Driving = true;
            do
            {
                Console.WriteLine("1 Accelerate\n2 Brake\n3 Refuel\n4Turn On/Off\n5 Switch Car");
                string testDriveChoice = Console.ReadLine();
                switch (testDriveChoice)
                {
                    case "1":
                        CurrentCar.Accelerate();
                        break;
                    case "2":
                        CurrentCar.Brake();
                        break;
                    case "3":
                        CurrentCar.AddFuel();
                        break;
                    case "4":
                        CurrentCar.ToggleEngine();
                        break;
                    case "5":
                        TestDrive();
                        Driving = false;
                        break;
                    default:
                        TestDrive();
                        break;
                }
            } while (Driving == true);
        }

        public void ListAllCars()
        {
            //Console.Clear();
            //GarageScreen();
            //foreach (var Car in GarageCars)
            //{
            //    Console.WriteLine("{0} {1}\nStatus : {2}\nFuel : {3}\nSpeed : {4}\n", Car.Make, Car.Model, Car.Status, Car.Fuel, Car.Speed);
            //}

            for (int i = 0; i < GarageCars.Count; i++)
            {
                Console.WriteLine("{0} {1} {2} {3} ", i, 
                    GarageCars[i].Make,
                    GarageCars[i].Model,
                    GarageCars[i].Status);

            }
        }
        public Car Select_Car(int index)
        {
            return GarageCars[index];
        }

        public void FuelAllCars()
        {
            foreach(var Car in GarageCars)
            {
                Car.Fuel = 100;
            }
        }

        public void AddCar(string make, string model, string status, int speed, int fuel)
        {
            
            GarageCars.Add(new Car(make,model,status,speed,fuel));
        }

        public void TitleScreen()
        {
            Console.WriteLine(@"  ________   ___  ___  _________  ________   __  _______
 / ___/ _ | / _ \/ _ |/ ___/ __/ / ___/ _ | /  |/  / __/
/ (_ / __ |/ , _/ __ / (_ / _/  / (_ / __ |/ /|_/ / _/  
\___/_/ |_/_/|_/_/ |_\___/___/  \___/_/ |_/_/  /_/___/  
                                                        ");
            Console.WriteLine("press ENTER to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public void GarageScreen()
        {
            Console.WriteLine(@"  ________   ___  ____
 / ___/ _ | / _ \/ __/
/ /__/ __ |/ , _/\ \  
\___/_/ |_/_/|_/___/  
                      ");
        }
    }
}

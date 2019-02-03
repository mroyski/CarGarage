using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Garage
    {
        public List<Car> GarageCars { get; set; }


        public Garage()
        {
            GarageCars = new List<Car>();
            AddCar("Lamborghini", "Centenario", "Car is off", 0, 100);
            AddCar("Chevrolet", "Corvette", "Car is off", 0, 100);
            AddCar("Toyota", "Corolla", "Car is off", 0, 100);
        }

        public void ListAllCars()
        {
            for (int i = 0; i < GarageCars.Count; i++)
            {
                Console.WriteLine("{0} {1} {2}\nFuel : {3}\n", i, 
                    GarageCars[i].Make,
                    GarageCars[i].Model,
                    GarageCars[i].Fuel);
            }
        }

        public Car Select_Car(int index)
        {
            return GarageCars[index];
        }

        public void FuelAllCars()
        {
            for (int i = 0; i < GarageCars.Count; i++)
            {
                GarageCars[i].AddFuel();
            }
        }

        public void AddNewCar(string make, string model, int speed, int fuel)
        {
            Console.WriteLine("Make?");
            string carMake = Console.ReadLine();
            Console.WriteLine("Model?");
            string carModel = Console.ReadLine();
            GarageCars.Add(new Car(carMake, carModel, 0, 100));
        }

        public void AddCar(string make, string model, string status, int speed, int fuel)
        {
            GarageCars.Add(new Car(make, model, speed, fuel));
        }

        public void RemoveCar()
        {
            ListAllCars();
            Console.WriteLine("Select the car you wish to remove.");
            string removalcar = Convert.ToString(Console.ReadLine());
            int remove = Convert.ToInt32(removalcar);
            GarageCars.RemoveAt(remove);
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
            Console.WriteLine(@"  ________   ___  ___  _________
 / ___/ _ | / _ \/ _ |/ ___/ __/
/ (_ / __ |/ , _/ __ / (_ / _/  
\___/_/ |_/_/|_/_/ |_\___/___/  
                                ");
        }
    }
}


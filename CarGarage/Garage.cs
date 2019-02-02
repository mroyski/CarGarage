using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Garage
    {
        public List<Car> GarageCars { get; set; }
        public Car newCar;
        public Garage()
        {
            GarageCars = new List<Car>();

        }

        public void ListAllCars()
        {
            GarageCars.ForEach(Console.WriteLine);
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
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Status { get; set; }
        public int Speed { get; set; }
        public int Fuel { get; set; }

        // Constructor
        public Car() { }
        public Car(string make, string model, string status, int speed, int fuel)
        {
            Make = make;
            Model = model;
            Status = "Car is off";
            Speed = speed;
            Fuel = fuel;
        }

        public void ToggleEngine()
        {
            if (Status == "Car is off")
            {
                Status = "Car is running";
            }
            else
            {
                Status = "Car is off";
            }
        }
            
        public void Accelerate()
        {
            Speed += 10;
            Fuel -=5;
        }

        public void Brake()
        {
            Speed -= 10;
        }

        public void AddFuel()
        {
            Fuel = 100;
        }
    }
}

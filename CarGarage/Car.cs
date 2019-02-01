using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public int Speed { get; set; }
        public int Fuel { get; set; }
        public string Status { get; set; }

        // Constructor
        public Car()
        {
            Speed = 0;
            Fuel = 20;
            Status = "Car is off";
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
            Fuel--;
        }

        public void Brake()
        {
            Speed -= 10;
        }

        public void AddFuel()
        {
            Fuel = 25;
        }
    }
}

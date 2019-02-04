using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int Fuel { get; set; }

        // Constructor
        public Car()
        {
            Running = false;
            Speed = 0;
            Fuel = 100;
        }

        public Car(string make, string model, int speed, int fuel)
        {
            Running = false;
            Make = make;
            Model = model;
            Speed = speed;
            Fuel = fuel;
        }

        public bool Running { get; set; }
        public void ToggleEngine()
        {
            Speed = 0;
            if (Running == true)
            {
                Running = false;
                Console.WriteLine("Car is off");
            }
            else
            {
                Running = true;
                Console.WriteLine("Car is running");
            }
        }

        public void Accelerate()
        {
            if (Fuel > 0)
                {
                Speed += 10;
                Fuel -= 10;
            }
            else
            {
                Console.WriteLine("You're out of fuel!");
            }
        }

        public void Brake()
        {
            if (Speed >= 10)
            {
                Speed -= 10;
            }
            else
            {
                Console.WriteLine("You are not moving.");
            }
        }

        public void AddFuel()
        {
            Fuel = 100;
        }
    }
}

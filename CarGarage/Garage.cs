using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Garage
    {
        List<Car> CarGarage { get; set; }

        public void FuelAllCars()
        {
            foreach(var Car in CarGarage)
            {
                Car.Fuel = 25;
            }
        }
    }
}

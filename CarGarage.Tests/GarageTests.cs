using System;
using System.Collections.Generic;
using Xunit;

namespace CarGarage.Tests
{
    public class GarageTests
    {
        Garage garage = new Garage();
        //List<Car> CarGarage = new List<Car>();
        Car car = new Car("Toyota", "Corolla", 0, 90);
        Car truck = new Car("Ford", "Ranger", 0, 90);

        [Fact]
        public void shouldAddCarToGarage()
        {
            // Tests AddCar() method
            // Arrange
            Car car1 = new Car("Toyota", "Corolla", 0, 20);
            // Act
            List<Car> CarGarage = new List<Car>();
            CarGarage.Add(car);
            // Assert
            Assert.Equal(CarGarage[0], car);
        }

        [Fact]
        public void shouldRemoveCarFromGarage()
        {
            // Tests RemoveCar() method
            // Arrange
            List<Car> CarGarage = new List<Car>();

            Car car = new Car("Toyota", "Corolla", 0, 20);
            // Act
            CarGarage.Add(car);
            CarGarage.Remove(car);
            // Assert
            Assert.Empty(CarGarage);
        }

        [Fact]
        public void shouldFuelAllCars()
        {
            // Tests FuelAllCars() method
            // Arrange
            garage.AddCar("Toyota", "Corolla", "Car is off", 0, 90);
            garage.AddCar("Ford", "Ranger", "Car is off", 0, 90);
            // Act
            garage.FuelAllCars();
            // Assert
            Assert.Equal(100, garage.GarageCars[0].Fuel);
            Assert.Equal(100, garage.GarageCars[1].Fuel);
        }

        [Fact]
        public void shouldTestDriveOneCar()
        {
            // Use the Program class to let you select a single car
            // Program class should then let you choose what you want to do with that car
            // You do not need to test user input in the Program class
        }

        [Fact]
        public void youShouldNameThisTest()
        {
            // Should be able to list stats of all cars
            // Create necessary method(s)
            // Garage class should provide cars
            // Program class should list all stats
        }
    }
}

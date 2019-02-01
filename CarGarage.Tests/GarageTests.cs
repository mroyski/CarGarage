using System;
using System.Collections.Generic;
using Xunit;

namespace CarGarage.Tests
{
    public class GarageTests
    {
        List<Car> CarGarage = new List<Car>();
        Car car = new Car();
        Car truck = new Car();


        [Fact]
        public void shouldAddCarToGarage()
        {
            // Tests AddCar() method
            // Arrange
            Car car = new Car();
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
            Car car = new Car();
            // Act
            List<Car> CarGarage = new List<Car>();
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
            CarGarage.Add(car);
            CarGarage.Add(truck);
            // Act
            shouldFuelAllCars();
            // Assert
            Assert.Equal(25, car.Fuel);
            Assert.Equal(25, truck.Fuel);

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

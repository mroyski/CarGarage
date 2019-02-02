using System;
using System.Collections.Generic;
using Xunit;

namespace CarGarage.Tests
{
    public class CarTests
    {
        Garage carGarage = new Garage();
        List<Car> CarGarage = new List<Car>();
        Car car = new Car("Toyota", "Corolla", "Car is off", 0, 90);
        Car truck = new Car("Ford", "Ranger", "Car is off", 0, 90);
        [Fact]
        public void shouldAccelerate()
        {
            // Tests Accelerate() method in Car increases Speed
            // Arrange
            var car = new Car();
            // Act
            car.Accelerate();
            // Assert
            Assert.Equal(10, car.Speed);
        }

        [Fact]
        public void shouldConsumeFuel()
        {
            // Tests Accelerate() method reduces Fuel amount
            // Arrange
            // Act
            car.Accelerate();
            // Assert
            Assert.Equal(85, car.Fuel);
        }

        [Fact]
        public void shouldRefuel()
        {
            // Tests AddFuel() method increases Fuel amount
            // Arrange
            Car car = new Car("Toyota", "Corolla", "Car is off", 0, 20);
            car.Accelerate();
            // Act
            car.AddFuel();
            // Assert
            Assert.Equal(100, car.Fuel);
        }

        [Fact]
        public void shouldSlowDown()
        {
            // Tests Brake() method in Car reduces Speed amount
            // Arrange
            Car car = new Car("Toyota", "Corolla", "Car is off", 0, 20);
            // Act
            car.Accelerate();
            car.Accelerate();
            car.Brake();
            // Assert
            Assert.Equal(10, car.Speed);
        }

        [Fact]
        public void shouldStart()
        {
            // Tests ToggleEngine() method starts car when its off
            // Arrange
            Car car = new Car("Toyota", "Corolla", "Car is off", 0, 20);
            // Act
            car.ToggleEngine();
            // Assert
            Assert.Equal("Car is running", car.Status);
        }

        [Fact]
        public void shouldTurnOff()
        {
            // Tests ToggleEngine() method turns car off when its on
            // Arrange
            Car car = new Car("Toyota", "Corolla", "Car is off", 0, 20);
            // Act
            car.ToggleEngine();
            car.ToggleEngine();
            // Assert
            Assert.Equal("Car is off", car.Status);
        }
    }
}

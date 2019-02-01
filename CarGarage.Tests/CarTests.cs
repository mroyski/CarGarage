using System;
using Xunit;

namespace CarGarage.Tests
{
    public class CarTests
    {
        [Fact]
        public void shouldAccelerate()
        {
            // Tests Accelerate() method in Car increases Speed
            // Arrange
            Car car = new Car();
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
            Car car = new Car();
            // Act
            car.Accelerate();
            // Assert
            Assert.Equal(19, car.Fuel);
        }

        [Fact]
        public void shouldRefuel()
        {
            // Tests AddFuel() method increases Fuel amount
            // Arrange
            Car car = new Car();
            car.Accelerate();
            // Act
            car.AddFuel();
            // Assert
            Assert.Equal(20, car.Fuel);
        }

        [Fact]
        public void shouldSlowDown()
        {
            // Tests Brake() method in Car reduces Speed amount
            // Arrange
            Car car = new Car();
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
            Car car = new Car();
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
            Car car = new Car();
            // Act
            car.ToggleEngine();
            car.ToggleEngine();
            // Assert
            Assert.Equal("Car is off", car.Status);
        }
    }
}

using System;
using Xunit;

namespace Mindbox.TestTask.Test
{
    public class CircleTest
    {
        // Круг с радиусом 5
        [Fact]
        public void CircleWithRadiusFive()
        {
            // Arrange
            var circle = new Circle(5);
            
            // Act
            var area = circle.CalculateArea();
            
            // Assert
            Assert.Equal(78.53981633974483, area);
        }

        // Круг с радиусом 3.14 
        [Fact]
        public void CircleWithFloatRadius()
        {
            // Arrange
            var circle = new Circle(3.14);
            
            // Act
            var area = circle.CalculateArea();
            
            // Assert
            Assert.Equal(30.974846927333925, area);
        }

        // "Круг" с отрицательным радиусом
        [Fact]
        public void CircleWithNegativeRadius()
        {
            // Assert
            Assert.Throws<ArgumentException>(() => new Circle(-3));
        }

        // "Круг" с радиусом 0
        [Fact]
        public void CircleWithRadiusZero()
        {
            // Arrange
            var circle = new Circle(0);
            
            // Act
            var area = circle.CalculateArea();
            
            // Assert
            Assert.Equal(0, area);
        }
    }
}
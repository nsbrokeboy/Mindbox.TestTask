using System;
using Xunit;

namespace Mindbox.TestTask.Test
{
    public class TriangleTest
    {
        // Треугольник со сторонами 7, 10 и 15
        [Fact]
        public void TriangleWithGoodSides()
        {
            // Arrange
            var triangle = new Triangle(7, 10, 15);
            
            // Act
            var area = triangle.CalculateArea();
            
            // Assert
            Assert.Equal(29.393876913398138, area);
        }
        
        // Равносторонний треугольник
        [Fact]
        public void TriangleEqualAllSides()
        {
            // Arrange
            var triangle = new Triangle(11, 11, 11);
            
            // Act
            var area = triangle.CalculateArea();
            
            // Assert
            Assert.Equal(52.39453692895854, area);
        }
        
        // Равнобедренный треугольник
        [Fact]
        public void TriangleEqualTwoSides()
        {
            // Arrange
            var triangle = new Triangle(7, 7, 3);
            
            // Act
            var area = triangle.CalculateArea();
            
            // Assert
            Assert.Equal(10.256095748383007, area);
        }

        // "Треугольник" с отрицательной стороной
        [Fact]
        public void TriangleWithNegativeSide()
        {
            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(-13, 5, 9));
        }
        
        // "Треугольник", не выполняющий условие существования треугольника
        [Fact]
        public void TriangleNonExistent()
        {
            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(10, 5, 3));
        }
    }
}
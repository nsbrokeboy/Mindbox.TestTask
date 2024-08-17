using Mindbox.AreaCalculator.Common;
using Mindbox.AreaCalculator.Shapes;

namespace Mindbox.AreaCalculator.Test;

[TestFixture]
public class TriangleTests
{
    [Test]
    public void CalculateArea_ValidTriangle_ReturnsCorrectArea()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5); // Прямоугольный треугольник с известной площадью
        var expectedArea = 6.0;

        // Act
        var area = triangle.CalculateArea();

        // Assert
        Assert.That(area, Is.EqualTo(expectedArea), "Площадь треугольника вычисляется неверно.");
    }

    [Test]
    public void CalculateArea_EquilateralTriangle_ReturnsCorrectArea()
    {
        // Arrange
        var side = 5.0;
        var triangle = new Triangle(side, side, side);
        var expectedArea = Math.Sqrt(3) / 4 * Math.Pow(side, 2); // Формула площади равностороннего треугольника

        // Act
        var area = triangle.CalculateArea();

        // Assert
        Assert.That(area, Is.EqualTo(expectedArea), "Площадь равностороннего треугольника вычисляется неверно.");
    }

    [Test]
    public void Constructor_InvalidTriangle_ThrowsArgumentException()
    {
        // Arrange
        var a = 1.0;
        var b = 2.0;
        var c = 10.0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c), "Треугольник с некорректными сторонами должен выбрасывать исключение.");
    }

    [Test]
    public void Constructor_ZeroSides_ThrowsArgumentException()
    {
        // Arrange
        var a = 0.0;
        var b = 4.0;
        var c = 5.0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c), "Треугольник с нулевой стороной должен выбрасывать исключение.");
    }

    [Test]
    public void IsRight_RightTriangle_ReturnsTrue()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5); // Прямоугольный треугольник

        // Act
        var isRight = triangle.IsRight();

        // Assert
        Assert.That(isRight, Is.True, "Прямоугольный треугольник не распознан.");
    }

    [Test]
    public void IsRight_NotRightTriangle_ReturnsFalse()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 6); // Непрямоугольный треугольник

        // Act
        var isRight = triangle.IsRight();

        // Assert
        Assert.That(isRight, Is.False, "Непрямоугольный треугольник неправильно распознан как прямоугольный.");
    }
}
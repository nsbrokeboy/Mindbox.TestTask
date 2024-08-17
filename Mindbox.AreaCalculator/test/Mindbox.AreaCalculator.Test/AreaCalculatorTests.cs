using Mindbox.AreaCalculator.Shapes;

namespace Mindbox.AreaCalculator.Test;

[TestFixture]
public class AreaCalculatorTests
{
    [Test]
    public void CalculateArea_Circle_ReturnsCorrectArea()
    {
        // Arrange
        var circle = new Circle(5.0); // Радиус круга 5
        var expectedArea = Math.PI * Math.Pow(5.0, 2);

        // Act
        var area = AreaCalculator<Circle>.CalculateArea(circle);

        // Assert
        Assert.That(area, Is.EqualTo(expectedArea), "Площадь круга вычисляется неверно.");
    }

    [Test]
    public void CalculateArea_Triangle_ReturnsCorrectArea()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5); // Прямоугольный треугольник
        var expectedArea = 6.0;

        // Act
        var area = AreaCalculator<Triangle>.CalculateArea(triangle);

        // Assert
        Assert.That(area, Is.EqualTo(expectedArea), "Площадь треугольника вычисляется неверно.");
    }

    [Test]
    public void CalculateArea_ZeroRadiusCircle_ReturnsZero()
    {
        // Arrange
        var circle = new Circle(0.0);

        // Act
        var area = AreaCalculator<Circle>.CalculateArea(circle);

        // Assert
        Assert.That(area, Is.EqualTo(0.0), "Площадь круга с радиусом 0 должна быть 0.");
    }

    [Test]
    public void CalculateArea_EquilateralTriangle_ReturnsCorrectArea()
    {
        // Arrange
        var side = 5.0;
        var triangle = new Triangle(side, side, side);
        var expectedArea = Math.Sqrt(3) / 4 * Math.Pow(side, 2);

        // Act
        var area = AreaCalculator<Triangle>.CalculateArea(triangle);

        // Assert
        Assert.That(area, Is.EqualTo(expectedArea), "Площадь равностороннего треугольника вычисляется неверно.");
    }
}
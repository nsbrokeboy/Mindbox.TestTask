using Mindbox.AreaCalculator.Shapes;

namespace Mindbox.AreaCalculator.Test;

[TestFixture]
public class CircleTests
{
    [Test]
    public void CalculateArea_PositiveRadius_ReturnsCorrectArea()
    {
        // Arrange
        var radius = 5.0;
        var expectedArea = Math.PI * Math.Pow(radius, 2);
        var circle = new Circle(radius);

        // Act
        var area = circle.CalculateArea();

        // Assert
        Assert.That(area, Is.EqualTo(expectedArea), "Площадь круга вычисляется неверно.");
    }

    [Test]
    public void CalculateArea_RadiusIsZero_ReturnsZero()
    {
        // Arrange
        var radius = 0.0;
        var expectedArea = 0.0;
        var circle = new Circle(radius);
        
        // Act
        var area = circle.CalculateArea();

        // Assert
        Assert.That(area, Is.EqualTo(expectedArea), "Площадь круга с радиусом 0 должна быть 0.");
    }

    [Test]
    public void Constructor_NegativeRadius_ThrowsArgumentException()
    {
        // Arrange
        var radius = -5.0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Circle(radius), "Круг с отрицательным радиусом должен выбрасывать исключение.");
    }

    [Test]
    public void Constructor_ZeroRadius_DoesNotThrow()
    {
        // Arrange
        var radius = 0.0;

        // Act & Assert
        Assert.DoesNotThrow(() => new Circle(radius), "Круг с радиусом 0 должен корректно создаваться.");
    }
}
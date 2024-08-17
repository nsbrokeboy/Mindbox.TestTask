using Mindbox.AreaCalculator.Common;
using Mindbox.AreaCalculator.Interfaces;

namespace Mindbox.AreaCalculator.Shapes;

/// <summary>
/// Круг
/// </summary>
public record struct Circle : ICalculateArea
{
    /// <summary>
    /// Радиус
    /// </summary>
    public double Radius { get; }

    public Circle(double radius)
    {
        if (!ShapeValidators.IsValidLength(radius))
        {
            throw new ArgumentException("Radius of circle must have positive length");
        }

        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
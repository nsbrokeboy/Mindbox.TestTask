using Mindbox.AreaCalculator.Common;
using Mindbox.AreaCalculator.Interfaces;

namespace Mindbox.AreaCalculator.Shapes;

/// <summary>
/// Треугольник
/// </summary>
public record struct Triangle : ICalculateArea
{
    /// <summary>
    /// Первая сторона треугольника
    /// </summary>
    public double ASide { get; }
    
    /// <summary>
    /// Вторая сторона треугольника
    /// </summary>
    public double BSide { get; }
    
    /// <summary>
    /// Третья сторона треугольника
    /// </summary>
    public double CSide { get; }

    public Triangle(double aSide, double bSide, double cSide)
    {
        if (!ShapeValidators.IsValidTriangleSides(aSide, bSide, cSide))
        {
            throw new ArgumentException($"Cannot create triangle with sides: {aSide}, {bSide}, {cSide}");
        }

        ASide = aSide;
        BSide = bSide;
        CSide = cSide;
    }
    
    public double CalculateArea()
    {
        var semiPerimeter = (ASide + BSide + CSide) / 2;
        
        return Math.Sqrt(semiPerimeter * (semiPerimeter - ASide) * (semiPerimeter - BSide) * (semiPerimeter - CSide));
    }
}
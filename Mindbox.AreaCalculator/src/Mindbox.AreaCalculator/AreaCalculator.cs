using Mindbox.AreaCalculator.Interfaces;

namespace Mindbox.AreaCalculator;

/// <summary>
/// Кальклуятор площади фигуры в рантайме
/// </summary>
public static class AreaCalculator<T> where T : ICalculateArea
{
    /// <inheritdoc cref="ICalculateArea.CalculateArea"/>
    public static double CalculateArea(T shape)
    {
        return shape.CalculateArea();
    }
}
using Mindbox.AreaCalculator.Shapes;

namespace Mindbox.AreaCalculator.Common;

public static class TriangleExtensions
{
    public static bool IsRight(this Triangle triangle)
    {
        var sides = new[] { triangle.ASide, triangle.BSide, triangle.CSide };
        Array.Sort(sides); // Если треугольник прямоугольный, то последний элемент массива - гипотенуза, а первые два - катеты
        
        return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 1E-15;
    }
}
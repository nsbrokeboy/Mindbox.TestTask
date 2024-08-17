namespace Mindbox.AreaCalculator.Common;

/// <summary>
/// Валидаторы для фигур
/// </summary>
public static class ShapeValidators
{
    /// <summary>
    /// Проверка, существует ли сторона/радиус/отрезок
    /// </summary>
    public static bool IsValidLength(double length)
    {
        return length >= 0; // отрезок с длиной 0 математически может существовать, пусть и сводится к точке
    }

    /// <summary>
    /// Проверка на правило существования треугольника
    /// </summary>
    public static bool IsValidTriangleSides(double first, double second, double third)
    {
        return IsValidLength(first) &&
               IsValidLength(second) &&
               IsValidLength(third) &&
               first + second > third &&
               first + third > second &&
               second + third > first;
    }
}
using System;

namespace Mindbox.TestTask
{
    /// <summary>
    /// Абстрактный класс для удобства добавления новых фигур.
    /// Наследники должны иметь поля (длина стороны, радиус и т. п.) и переопределить метод CalculateArea.
    /// </summary>
    public abstract class Figure
    {   
        public abstract double CalculateArea();
    }
}
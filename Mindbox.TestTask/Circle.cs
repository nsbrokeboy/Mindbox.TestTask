using System;

namespace Mindbox.TestTask
{
    /// <summary>
    /// Класс круга
    /// </summary>
    public class Circle : Figure
    {
        private double radius;
        
        public double Radius
        {
            get => radius;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Радиус не может быть отрицательной длинны");
                }

                radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
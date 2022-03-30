using System;
using System.Linq;
using System.Reflection;

namespace Mindbox.TestTask
{
    /// <summary>
    /// Класс треугольника
    /// </summary>
    public class Triangle : Figure
    {
        private double aSide;
        public double ASide
        {
            get => aSide;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона не может быть меньше либо равна нулю.");
                }

                aSide = value;
            }
        }


        private double bSide;
        public double BSide 
        { 
            get => bSide;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона не может быть меньше либо равна нулю.");
                }

                bSide = value;
            }
        }

        private double cSide;

        public double CSide
        {
            get => cSide;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона не может быть меньше либо равна нулю.");
                }

                cSide = value;
            }
        }
        
        public Triangle(double aSide, double bSide, double cSide)
        {
            // Условие существования треугольника: сумма любых двух сторон треугольника должна быть больше третьей его стороны.
            if (!(aSide + bSide > cSide && aSide + cSide > bSide && bSide + cSide > aSide))
            {
                throw new ArgumentException("Не выполняется условие существования треугольника.");
            }
            
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
        }

        public override double CalculateArea()
        {
            var sides = new[] {ASide, BSide, CSide};
            Array.Sort(sides);  // Если треугольник прямоугольный, то последний элемент массива - гипотенуза, а первые два - катеты 
            
            // Проверка, является ли треугольнник прямоугольным
            if (Math.Abs(Math.Pow(sides[2], 2) - Math.Pow(sides[0], 2) * Math.Pow(sides[1], 2)) <= 1E-15)
            {
                // Рассчет площади для прямоугольного треугольника
                return sides[0] * sides[1] / 2.0;
            }

            // По формуле Герона
            double p = sides.Sum() / 2.0;
            return Math.Sqrt(p * (p - ASide) * (p - BSide) * (p - CSide));
        }
    }
}
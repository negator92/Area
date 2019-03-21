using System;

namespace Area
{
    public class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double sideA = 5, double sideB = 6, double sideC = 7)
        {
            A = sideA;
            B = sideB;
            C = sideC;
        }

        private double GetPerimeter()
        {
            double result;
            result = 0.5 * (A + B + C);
            return result;
        }

        public double GetArea()
        {
            double result = GetPerimeter();
            result = (A * B * C) / (4 * Math.Sqrt(result * (result - A) * (result - B) * (result - C)));
            return result;
        }
    }
}
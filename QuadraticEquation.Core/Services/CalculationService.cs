using System;

namespace QuadraticEquation.Core.Services
{
    public class CalculationService : ICalculationService
    {
        public double GetQuadratic(double x1, double x2, double a, double b, double c)
        {
            x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            x2 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

            return GetQuadratic(x1,x2,a,b,c);
        }
    }
}

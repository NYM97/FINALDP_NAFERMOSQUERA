using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquation.Core.Services
{
    public interface ICalculationService
    {
        double GetQuadratic(double x1, double x2, double a, double b, double c);
    }

}

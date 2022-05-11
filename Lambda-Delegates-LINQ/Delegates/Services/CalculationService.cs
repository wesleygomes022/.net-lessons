using System;

namespace Studies.Services
{
    class CalculationService
    {
        public static double Soma(double a, double b)
        {
            return a + b;
        }

        public static double Max(double a, double b)
        {
            return a > b ? a : b;
        }

        public static double Square(double x)
        {
            return x * x;
        }
    }
}

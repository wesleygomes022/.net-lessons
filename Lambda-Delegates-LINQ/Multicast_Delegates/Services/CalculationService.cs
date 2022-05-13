using System;

namespace Studies.Services
{
    class CalculationService
    {
        public static void ShowMax(double x, double y)
        {
            double max = (x > y) ? x : y;
            Console.WriteLine(max);
        }

        public static void ShowSum(double x, double y)
        {
            double res = x + y;
            Console.WriteLine(res.ToString("F2"));
        }
    }
}

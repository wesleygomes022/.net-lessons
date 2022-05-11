using System;
using Studies.Services;

namespace Studies
{
    delegate double NumericOperation(double a1, double a2);
    delegate double SquareOperation(double n);
    delegate double SumOperation(double a1, double a2);
    class Program
    {
        static void Main(string[] args)
        {
            NumericOperation operation = CalculationService.Max;
            SquareOperation op = CalculationService.Square;
            SumOperation sumOp = CalculationService.Soma;

            double result = operation(13, 17);
            double res = op(9);
            double resul = sumOp(14, 26);

            Console.WriteLine(result);
            Console.WriteLine(res);
            Console.WriteLine(resul);
        }
    }
}

using System;
using Studies.Services;

namespace Studies
{
    delegate void Operation(double x, double y);
    class Program
    {
        static void Main(string[] args)
        {
            //referencing more than one function with a delegate. 
            //it calls Multicast Delegate
            Operation op = CalculationService.ShowMax;
            op += CalculationService.ShowSum;

            //invoking all functions in other of declaration
            //op.Invoke(10, 20);
            op(20, 25);
        }
    }
}

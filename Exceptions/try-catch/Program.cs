using System;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int n3 = n1 / 0;
                Console.WriteLine(n3);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Por favor, insira apenas números!");
                Console.Write("N: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(n);
            }
        }
    }
}

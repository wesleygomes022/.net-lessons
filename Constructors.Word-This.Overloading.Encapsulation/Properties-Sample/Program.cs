using System;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();

            c1.modelo = "Civic";
            c1.ano = 2018;
            c1.marca = "Honda";

            Console.WriteLine(c1);
        }
    }
}

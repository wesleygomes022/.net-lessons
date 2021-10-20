using System;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();

            c1.setModelo("Civic");
            c1.Ano = 2018;
            c1.Marca = "Honda";

            Console.WriteLine(c1);
        }
    }
}

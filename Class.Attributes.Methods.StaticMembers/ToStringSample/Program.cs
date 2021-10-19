using System;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            
            Console.Write("Entre os dados do produto: ");
            p.Nome = Console.ReadLine();

            Console.Write("Insira o preço: ");
            p.Preco = double.Parse(Console.ReadLine());

            Console.Write("Insira a quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(p);
        }
    }
}

using System;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<double> x = null;
            //outra forma de escrita
            //double? x = null;

            //Console.WriteLine(x.GetValueOrDefault());
            // retorna o valor padrão do tipo primitivo


            //Console.WriteLine(x.HasValue);
            // retorna true/false se a variável possui valor válido ou não
             

            Console.WriteLine(x.Value);
            // retorna o valor da variável ou excessão se a mesma estiver com valor null
        }
    }
}

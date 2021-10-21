using System;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco c1;

            Console.Write("Insira o número da conta: ");
            int Conta = int.Parse(Console.ReadLine());

            Console.Write("Insira o títular da conta: ");
            string Titular = Console.ReadLine();

            Console.Write("Deseja efetuar um novo depósito? (Digite true para SIM ou false para NÃO): ");
            bool Temp = bool.Parse(Console.ReadLine());

            if (Temp)
            {
                Console.Write("Insira o valor do depósito inicial: ");
                double depInicial = double.Parse(Console.ReadLine());
                c1 = new Banco(Conta, Titular, depInicial);
            }
            else
            {
                c1 = new Banco(Conta, Titular, 0.0);
            }

            Console.WriteLine("\nExtrato da conta:\n----------------------\n" + c1);

            Console.Write("\nDeseja efetuar um novo depósito? (Digite true para SIM ou false para NÃO): ");
            Temp = bool.Parse(Console.ReadLine());
                        
            while (Temp)
            {
                Console.Write("Insira o valor do depósito: ");
                double Valor = double.Parse(Console.ReadLine());
                c1.deposito(Valor);

                Console.WriteLine("\nExtrato da conta:\n----------------------\n" + c1);

                Console.Write("\nDeseja efetuar um novo depósito? (Digite true para SIM ou false para NÃO): ");
                Temp = bool.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nDados da conta atualizados!");
            Console.WriteLine("Extrato da conta:\n----------------------\n" + c1);

            Console.Write("\nDeseja efetuar um saque? (Digite true para SIM ou false para NÃO): ");
            Temp = bool.Parse(Console.ReadLine());

            if (Temp)
            {
                Console.Write("Insira o valor do saque: ");
                double Valor = double.Parse(Console.ReadLine());
                c1.saque(Valor);

                Console.WriteLine("\nDados da conta atualizados!");
                Console.WriteLine("Extrato da conta:\n----------------------\n" + c1);
            }

            Console.Write("Deseja efetuar um novo saque? (Digite true para SIM ou false para NÃO): ");
            Temp = bool.Parse(Console.ReadLine());

            while (Temp)
            {
                Console.Write("Insira o valor do saque: ");
                double Valor = double.Parse(Console.ReadLine());
                c1.saque(Valor);

                Console.WriteLine("\nExtrato da conta:\n----------------------\n" + c1);

                Console.Write("Deseja efetuar um novo saque? (Digite true para SIM ou false para NÃO): ");
                Temp = bool.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nDados da conta atualizados!");
            Console.WriteLine("Extrato da conta:\n----------------------\n" + c1);
        }
    }
}

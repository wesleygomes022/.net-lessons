using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    class Banco
    {
        public int Conta { get; private set; }
        public string TitularNome { get; set; }
        public double Saldo { get; private set; }


        public Banco(double depositoInicial) 
        {
            Saldo = depositoInicial;
        }

        public Banco(int conta, string titular, double depositoInicial) : this(depositoInicial)
        {
            Conta = conta;
            TitularNome = titular;
        }

        public void deposito(double valor)
        {
            Saldo += valor;
        }

        public void saque(double valor)
        {
            Saldo -= valor;
            taxaSaque();
        }

        public void taxaSaque()
        {
            Saldo -= 5;
        }

        public override string ToString()
        {
            return "Conta: " + Conta
                + "; \nTitular: " + TitularNome
                + "; \nSaldo: " + Saldo;
        }
    }
}

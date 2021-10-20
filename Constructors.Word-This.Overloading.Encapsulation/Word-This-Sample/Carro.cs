using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    class Carro
    {
        string Modelo, Marca;
        int Ano;
        double Preco;

        public Carro(string modelo, string marca)
        {
            Modelo = modelo;
            Marca = marca;
        }

        public Carro(int ano, string modelo, string marca) : this()
        {
            Ano = ano;
            Modelo = modelo;
            Marca = marca;
        }

        public Carro()
        {
            Preco = 40000.00;
        }

        public override string ToString()
        {
            return Modelo + "; "
                + Marca + "; "
                + Ano + "; "
                + Preco.ToString("F2");
        }
    }
}

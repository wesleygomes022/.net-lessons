using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    class Carro
    {
        private string Modelo, Marca;
        private int Ano;
        private double Preco;

        public Carro()
        {
            Preco = 40000.00;
        }

        public string modelo
        {
            get
            {
                return Modelo;
            }

            set
            {
                Modelo = value;
            }
        }

        public string marca
        {
            get
            {
                return Marca;
            }
            set
            {
                Marca = value;
            }
        }

         public int ano 
        {
            get
            {
                return Ano;
            }

            set
            {
                Ano = value;
            }
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

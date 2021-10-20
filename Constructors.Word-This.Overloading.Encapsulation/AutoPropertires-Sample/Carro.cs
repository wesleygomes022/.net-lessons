using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; private set; }
        public int Ano { get; set; }
        public double Preco { get; set; }

        public Carro()
        {
            Preco = 40000.00;
        }

        public void setModelo(string modelo) 
        {
            Modelo = modelo;
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

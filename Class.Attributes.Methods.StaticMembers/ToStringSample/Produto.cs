using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            return this.Preco * this.Quantidade;
        }

        public override string ToString()
        {
            return "Produto: " + this.Nome
                + "\nPreço: $" + Preco
                + "\nQuantidade: " + this.Quantidade
                + "\nQuantidade em estoque: " + ValorTotalEstoque().ToString("F2");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    struct Pessoa
    {
        public string Nome;
        public int Idade;

        public override string ToString()
        {
            return Nome + ", " + Idade + ".";
        }
    }
}

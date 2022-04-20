using System;

namespace TestProj
{
    class Aluno
    {
        public int RA { get; set; }
        public char Curso { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Aluno))
            {
                return false;
            }
            Aluno temp = obj as Aluno;
            return RA.Equals(temp.RA);
        }

        public override int GetHashCode()
        {
            return RA.GetHashCode();
        }
    }
}

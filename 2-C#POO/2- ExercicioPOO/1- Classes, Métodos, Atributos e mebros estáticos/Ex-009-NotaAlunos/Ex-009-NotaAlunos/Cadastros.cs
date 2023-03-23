using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_009_NotaAlunos
{
    internal class Cadastros
    {
        public string Nome;
        public int Nota1;
        public int Nota2;
        public int Nota3;

        public double CalculoNota()
        {
            double nf = Nota1 + Nota2 + Nota3;

            return nf;
        }
    }
}

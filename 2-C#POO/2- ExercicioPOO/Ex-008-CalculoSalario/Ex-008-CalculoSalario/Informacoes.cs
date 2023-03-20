using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_008_CalculoSalario
{
    internal class Informacoes
    {
        public string Nome;

        public double Salario;

        public double Imposto;

        public double adicionar;

        public double SomaSalarioImposto()
        {
            return Salario - Imposto;
        }

        public double Calculo()
        {
            var sal = Salario;
            Salario = (Salario * adicionar) / 100;
            return sal + Salario;
        }

        public override string ToString()
        {
            return Nome + ", $" + SomaSalarioImposto();
        }
    }
}

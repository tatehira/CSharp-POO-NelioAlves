using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_005
{
    internal class Triangulo
    {
        public double A; // Public: Pode ser acessado de outro arquivo
        public double B;
        public double C;

        public Double CalculoArea() // Não há parametros, poís os dados já estão na mesma classe
        {
            double P = (A + B + C) / 2.0;

            double Raiz = Math.Sqrt(P * (P - A) * (P - B) * (P - C));

            return Raiz;
        }
    }
}

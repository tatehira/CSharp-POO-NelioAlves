using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_007_CalculoRetangulo
{
    internal class DadosRetagulo
    {
        public double Largura;

        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura + Altura) * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt((Largura * 2) + (Altura * 2));
        }

        public override string ToString() // Faz com que a classe atual (DadosRetangulo), quando é chamada sozinha, vire esse retorno abaixo
        {
            return $"Areá do triangulo:{Area()} ;"
                + $"Prerimetro:{Perimetro()} ;"
                + $"Diagonal: {Diagonal()}";
        }
    }
}

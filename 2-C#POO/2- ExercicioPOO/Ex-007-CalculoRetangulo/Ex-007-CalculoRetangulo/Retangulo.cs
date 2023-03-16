using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_007_CalculoRetangulo
{
    internal class Retangulo
    {
        public void Entrada()
        {
            Console.WriteLine("--- RETANGULOS ---");
            Console.ReadKey();
            Console.Clear();

            DadosRetagulo retangulo = new DadosRetagulo();

            Console.Write("Digite a ALTURA do retangulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a LARGURA do retangulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("DADOS DO RETANGULO: ");
            Console.WriteLine($"Area: {retangulo.Area}");
            Console.WriteLine($"Perimetro: {retangulo.Perimetro}");
            Console.WriteLine($"Diagonal: {retangulo.Diagonal}");
            Console.ReadKey();
        }
    }
}

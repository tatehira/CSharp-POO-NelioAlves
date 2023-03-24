using System.Formats.Asn1;

namespace Curso
{
   internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("CALCULO DO VALOR DA AREA DO TERRENO! ");
            Console.WriteLine("PRESS 'ENTER' PARA CONTINUAR! ");
            Console.WriteLine("========================================");
            Console.ReadLine();

            Console.WriteLine("Digite a LARGURA do terreno em metros: ");
            int Metros = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o COMPRIMENTO do terreno em metros: ");
            int Comprimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o VALOR DO M² do terreo: ");
            int ValorM = int.Parse(Console.ReadLine());

            double area = Metros * Comprimento;
            double ValorTerreno = ValorM * area;

            Console.WriteLine("O valor total do seu terreno é: " + ValorTerreno.ToString("F2"));
        }
    }
}
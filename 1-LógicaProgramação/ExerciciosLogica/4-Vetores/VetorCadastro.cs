using System.ComponentModel;
using System.Runtime.Serialization.Formatters;
using System.Globalization;

namespace AulasSharp{
    internal class Program {
        private static void Main(string[] args) {
            Console.WriteLine("PROGRAMA CALCULADOR! ");

            Console.Write("Digite a quantidade de pessoa que irá cadastrar: ");
            int quantidade = int.Parse(Console.ReadLine());

            string[] nomes = new string[quantidade];
            int[] idades = new int[quantidade];
            double[] alturas = new double[quantidade];

            //Organização dos dados
            for (int i = 0; i < quantidade; i++) { 
                Console.Write("Digite: Nome, Idade e altura (sem pontos): ");
                string[] ponte = Console.ReadLine().Split(' ');

                nomes[i] = ponte[0];
                idades[i] = int.Parse(ponte[1], CultureInfo.InvariantCulture);
                alturas[i] = double.Parse(ponte[2], CultureInfo.InvariantCulture);
            }

            //Calculo altura
            double soma = 0.0;
            for (int i = 0; i < quantidade; i++) { 
                soma = soma + alturas[i];
            }
            double media = soma / quantidade;
            Console.WriteLine("A média da altura das pessoas: " + media.ToString("F2", CultureInfo.InvariantCulture));

            //% de menor de idade 
            double menor = 0.0;
            for (int i=0; i< quantidade; i++) { 
                if (idades[i] < 18)
                {
                    menor++;
                }
            }
            Console.WriteLine("A quantidade de menor de idade que tem na lista é: " + menor.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
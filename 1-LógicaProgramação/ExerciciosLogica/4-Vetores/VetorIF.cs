using System.ComponentModel;
using System.Runtime.Serialization.Formatters;
using System.Globalization;

namespace AulasSharp{
    internal class Program {
        private static void Main(string[] args) {

            int quant = 5;
            int[] vet = new int[quant];

            int par = 0;
            int impar = 0;

            for (int i= 0; i < vet.Length; i++)
            {
                Console.Write("Digite um número: ");
                vet[i] = int.Parse(Console.ReadLine());

                if (vet[i] % 2 == 0)
                {
                    par = vet[i] / 2;
                }
                else 
                {
                    impar = vet[i] * 3;
                }
            }
            Console.WriteLine("Numeros total PAR divido por 2 a cada recebido: " + par);
            Console.WriteLine("Numeros total IMPAR multiplicado por 3 a cada recebido: " + impar);
        }
    }
}
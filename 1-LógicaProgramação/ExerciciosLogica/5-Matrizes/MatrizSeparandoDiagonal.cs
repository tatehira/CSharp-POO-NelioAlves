using System.ComponentModel;
using System.Runtime.Serialization.Formatters;
using System.Globalization;

namespace ExCSharp{
    internal class Program {
        private static void Main(string[] args) {

            Console.Write("Digite o numero para matriz: ");
            int numero = int.Parse(Console.ReadLine());

            int[,] matriz = new int[numero, numero];

            for (int i = 0; i < numero; i++ )
            {
                string[] vetor = Console.ReadLine().Split();

                for (int j = 0; j < numero; j++)
                {
                    matriz[i, j] = int.Parse(vetor[j]); 
                }
            }

            for (int i = 0; i < numero; i++)
            {
                for (int j = 0; j < numero; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("Diagonal principal: ");
            for (int i = 0; i < numero; i++)
            {
                Console.Write(matriz[i, i] + ". ");
            }
            Console.WriteLine();
        }
    }
}
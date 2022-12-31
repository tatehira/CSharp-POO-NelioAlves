using System.ComponentModel;
using System.Runtime.Serialization.Formatters;
using System.Globalization;
using System;

namespace ExCSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.Write("Quantos números digitar no vetor: ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();

            int[] vetor1 = new int[n];
            int[] vetor2 = new int[n];
            int[] diferenca = new int[n];
            int[] soma = new int[n];
            int[] multiplicacao = new int[n];
            int c = 0;
            int cont = 0;
            int varsoma = 0;    
            int multi = 1;
            int dif = 0;

            //Captando os indices do Primeiro vetor
            for (int i = 0; i < vetor1.Length; i++)
            {
                c++;
                Console.Write("Digite o " + c + " indice do 1 vetor: ");
                vetor1[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            //Captando os indices do Segundo vetor
            for (int k = 0; k < vetor2.Length; k++)
            {
                cont++;
                Console.Write("Digite o " + cont + " indice do 2 vetor: ");
                vetor2[k] = int.Parse(Console.ReadLine());
                Console.Clear();
            }


            //Diferença entre vetores
            for (int contador = 0; contador < n; contador++)
            {
                diferenca[contador] = vetor1[contador] - vetor2[contador];
                dif = dif - diferenca[contador];
            }
            Console.WriteLine("Diferença: " + dif);

            //Somando os dois vetores
            for (int i = 0; i < n; i++ )
            {
                soma[i] = vetor1[i] + vetor2[i];
                varsoma = varsoma + soma[i];
            }
            Console.WriteLine("Soma: " + varsoma);

            for (int i = 0; i < n; i++)
            {
                multiplicacao[i] = vetor1[i] * vetor2[i];
                multi = multi * multiplicacao[i];
            }
            Console.WriteLine("Multiplicacao: " + multi);
        }
    }
}
using System.Runtime.Serialization.Formatters;

namespace AulasSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("! AulaVetor !");       
            
            int[] Vetor; //CriandoVetor + nome dele

            Console.Write("Digite o final do vetor: ");
            int final = int.Parse(Console.ReadLine());
            Vetor = new int[final]; //Adicionando o final do vetor
            Console.Clear();

            int negativo = 0;
            double media;
            int contador = 0;
            int soma = 0;

            for (int i=0; i < final; i++)
            {
                Console.Write("Digite um número para o programa somar: ");
                Vetor[i] = int.Parse(Console.ReadLine());
                Console.Clear() ;
                
                soma = soma + Vetor[i];
                contador++;

                if (Vetor[i] < 0)
                {
                    negativo++; 
                }
            }

            for (int i = 0; i < final; i++)
            {
                Console.WriteLine("Você digitou o número: "+ Vetor[i]);
            }

            media = (soma / contador);

            Console.WriteLine("Você digitou " + negativo + " números negativos! ");
            Console.WriteLine("A soma dos números digitados: " + soma);
            Console.WriteLine("A média dos números digitados! " + media.ToString("F2"));
        }
    }
}
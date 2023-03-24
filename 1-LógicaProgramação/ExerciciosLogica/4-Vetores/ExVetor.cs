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
            
            for (int i=0; i < final; i++)
            {
                Console.Write("Digite um número para exibir e arma. no vetor: ");
                Vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < final; i++)
            {
                Console.WriteLine("Os numeros digitados são: "+ Vetor[i]);
            }
        }
    }
}
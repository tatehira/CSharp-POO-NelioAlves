
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

            for (int i=0; i < final; i++)
            {
                Console.Write("Digite um número para exibir e armazenar no vetor: ");
                Vetor[i] = int.Parse(Console.ReadLine());
                Console.Clear() ;

                if (Vetor[i] < 0)
                {
                    negativo++; 
                }
            }

            for (int i = 0; i < final; i++)
            {
                Console.WriteLine("Você digitou o número: "+ Vetor[i]);
            }

            Console.WriteLine("Você digitou " + negativo + " números negativos! ");
        }
    }
}
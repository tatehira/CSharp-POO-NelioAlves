namespace ExCSharp{
    internal class Program {
        private static void Main(string[] args) {

            Console.Write("Digite a quantidade de linhas e conlunas: ");
            int quant = int.Parse(Console.ReadLine());
            Console.Clear();

            int[,] math = new int[quant, quant];
            int soma = 0;

            for (int i = 0; i < quant; i++)
            {
                Console.Write("Digite a numeracao da matriz: ");
                string[] vetor = Console.ReadLine().Split();

                for (int j = 0; j < quant; j++)
                {
                    math[i, j] = int.Parse(vetor[j]);
                    soma = soma + math[i, j];
                }
            }
            Console.WriteLine("A soma " + soma);
            
            for (int i = 0; i < quant; i++)
            {
                for (int j = 0; j < quant; j++)
                {
                    Console.Write(math[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
namespace Ex_020_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arranjo
            /*
             * VETORES:
             * - em programacao, vetor é o nome dado a arranjos unidimensional
             * - É uma estrutura de dados homogenea (do mesmo tipo)
             * - Alocada de uma vez só em um bloco contiguo de memoria
             * 
             * vanatagens:
             *  - acesso imediato
             * 
             * Desvantagens:
             *  - Tamanho fixo
             *  - dificuldade para se realizar inserções e deleções
             */
            #endregion Arranjo

            Console.Write("Digite um número de quantidade do vetor: ");
            int Quantidade = int.Parse(Console.ReadLine());
            Console.Clear();

            double[] Vetor = new double[Quantidade];

            for(int i = 0; i < Quantidade; i++)
            {
                Console.Write($"Digite a {i+1} altura: ");
                Vetor[i] = double.Parse(Console.ReadLine());
                Console.Clear();
            }

            double Soma = 0.0;

            for(int i = 0; i < Quantidade; i++)
            {
                Soma += Vetor[i];
            }
            double Media = Soma / Quantidade;
            Console.Clear();
            Console.WriteLine($"A MÉDIA DAS ALTURAS É {Media.ToString("F2")}");
            Console.ReadKey();
        }
    }
}
namespace AulasSharp{
    internal class Program {
        private static void Main(string[] args) {

            String[,] Matriz = new string[2, 2];

            for (int linha = 0; linha < 2; linha++)
            {
                string[] vetor = Console.ReadLine().Split(' ');

                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Matriz[linha, coluna] = vetor[coluna];
                }
            }

            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write(Matriz[linha, coluna] + " ");
                }   
                Console.WriteLine();
            }
        }
    }
}
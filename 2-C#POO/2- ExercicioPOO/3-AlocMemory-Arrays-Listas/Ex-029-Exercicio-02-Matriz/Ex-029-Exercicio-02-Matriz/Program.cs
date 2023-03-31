namespace Ex_029_Exercicio_02_Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Construção da matriz
            Console.Write("Digite o numero de Linhas da matriz: ");
            int Linhas = int.Parse(Console.ReadLine());

            Console.Write("Digite o numero de Colunas da matriz: ");
            int Colunas = int.Parse(Console.ReadLine());

            int[,] Matriz = new int[Linhas, Colunas];

            int equal = 0;
            Console.Write("Digite os numeros: ");
            for(int i = 0; i < Matriz.GetLength(0); i++)
            {
                string[] VetorMatriz = Console.ReadLine().Split(' ');

                for(int j = 0; j < Matriz.GetLength(1); j ++)
                {
                    Matriz[i, j] = int.Parse(VetorMatriz[j]);
                    if (i == j)
                    {
                        equal = i;
                    }
                }
            }

            Console.Clear();
            Console.WriteLine("Segue a matriz abaixo: ");
            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Console.Write(Matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            #endregion Construção da matriz

            #region Selecionando Posições

            //Console.Write("Selecione uma posição da LINHA para consulta: ");
            //int PosicaoLinha = int.Parse(Console.ReadLine());

            //Console.Write("Selecione uma posição da COLUNA para consulta: ");
            //int PosicaoColuna = int.Parse(Console.ReadLine());

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    //if( )
                    //{

                    //}
                }
            }

            #endregion
        }
    }
}
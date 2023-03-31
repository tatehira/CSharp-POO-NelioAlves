namespace Ex_028_ExercicioMatriz
{
    internal class Program
    {
        /*                                          EXERCICIO
         * Fazer um exercicio para  ler um número inteiro N e uma matriz de ordem N contendo numeros inteiros.
         * Em seguida, mostrar a diagonal principal e a quantiadede de valores negativos da matriz;
         */
        static void Main(string[] args)
        {

            #region Criação da matriz
            Console.Write("Digite o numero de linhas e colunas da matriz: ");
            int num = int.Parse(Console.ReadLine());

            int[,] matriz = new int[num, num];

            for(int i = 0; i< num; i++)
            {
                string[] VetorMatriz = Console.ReadLine().Split(' ');

                for(int j = 0; j < num; j++)
                {
                    matriz[i, j] = int.Parse(VetorMatriz[j]);
                }
            }
            #endregion Criação da matriz

            #region Calculando Numero negativo

            double CalculoNegativo = 0;

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (matriz[i,j] < 0)
                    CalculoNegativo ++;
                }
            }

            Console.WriteLine($"Possui {CalculoNegativo} números negativos!");

            #endregion Calculando Numero negativo

            #region Mostrar na tela os dados da matriz

            Console.WriteLine("Os números da matriz são: ");
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            #endregion Mostrar na tela os dados da matriz

        }
    }
}
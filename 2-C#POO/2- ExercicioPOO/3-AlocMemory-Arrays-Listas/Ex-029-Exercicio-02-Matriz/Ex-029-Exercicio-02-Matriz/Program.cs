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

            int[,] Matriz = new int[Linhas, Colunas]; // criando matriz

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
            Console.WriteLine();
            Console.WriteLine("Busque um elemento: ");
            Console.Write("Selecione um número para buscar: ");
            int FindNumber = int.Parse(Console.ReadLine());

            int PosicaoLinha = 0;
            int PosicaoColuna = 0;
            int Acima = 0;
            int Abaixo = 0;
            int Esquerda = 0;
            int Direita = 0;

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    if (Matriz[i, j] == FindNumber)
                    {
                        PosicaoLinha = i + 1;
                        PosicaoColuna = j + 1;
                        Console.WriteLine($"O numero {FindNumber} está em [{PosicaoLinha}, {PosicaoColuna}] ");
                        
                        Direita = Matriz[i, j + 1];
                        if (Direita >= 0)
                        { 
                            Console.WriteLine("Direita: " + Direita);
                        }

                        Esquerda = Matriz[i, j - 1];
                        if (Esquerda >= 0)
                        {
                            Console.WriteLine("Esquerda: " + Esquerda);
                        }

                        Acima = Matriz[i - 1, j];
                        if (Acima>= 0)
                        {
                            Console.WriteLine("Acima: " + Acima);
                        }

                        Abaixo = Matriz[i + 1, j];
                        if (Abaixo >= 0)
                        {
                            Console.WriteLine("Abaixo: " + Abaixo);
                        }
                    }

                    if (Matriz[i, j] == FindNumber)
                    {
                        PosicaoLinha = i + 1;
                        PosicaoColuna = j + 1;
                        Console.WriteLine($"O numero {FindNumber} está em [{PosicaoLinha}, {PosicaoColuna}] ");

                        Direita = Matriz[i, j + 1];
                        if (Direita >= 0)
                        {
                            Console.WriteLine("Direita: " + Direita);
                        }

                        Esquerda = Matriz[i, j - 1];
                        if (Esquerda >= 0)
                        {
                            Console.WriteLine("Esquerda: " + Esquerda);
                        }

                        Acima = Matriz[i - 1, j];
                        if (Acima >= 0)
                        {
                            Console.WriteLine("Acima: " + Acima);
                        }

                        Abaixo = Matriz[i + 1, j];
                        if (Abaixo >= 0)
                        {
                            Console.WriteLine("Abaixo: " + Abaixo);
                        }
                    }
                }
            }           

            #endregion
        }
    }
}
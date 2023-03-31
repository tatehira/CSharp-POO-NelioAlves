namespace Ex_028_Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Explication
            /*
            Matriz ou arranjos são bidimensional
            - Homogenea (do mesmo tipo)
            - Ordenada (elementos acessados por posições)
            - Alocada de uma vez só em bloco contiguo de memoria

            Vantagens:
                - Acesso imediato aos elementos pela sua posição

            Desvantagens:
                - Tamanho fixo
                - Dificuldade para se realizar inserções e deleções
            ============================================================================================
                Como cria uma matriz?
                    - TipoPrimitivo[,] NomeMatriz mew TipoPrimitivo[linhas, colunas];
            */
            #endregion Explication

            double[,] Matriz = new double[2, 5];

            Console.WriteLine(Matriz.Length); // Quantidade de elementos

            Console.WriteLine(Matriz.Rank); // Quantidade de linhas

            Console.WriteLine(Matriz.GetLength(0)); // busca o que está na primeira dimenssão

            Console.WriteLine(Matriz.GetLength(1)); // busca o que está na segunda dimenssão
        }
    }
}
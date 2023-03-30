namespace Ex_025_Listas
{
    internal class Program
    {
        #region Listas
        /*
         * - estrutura homogenea (do mesmo tipo)
         * - Ordenada (elementos acessados por meio de posições)
         * - Inicia vazia e seus elementos são alocads sob demanda
         * - Cada elemento ocupa um "nó" (ou nodo) da lista
         * -> Pertence a class List
         *  - Namespace: System.Collections.Generic
         * 
         * ->Vantagens:
         *  - tamanho variavel
         *  - Facilidade para se realizar inservções e deleções
         * 
         * -> desvantagens:
         *  - Acesso sequencial aos elementos
         *  
         *   List<string> NomeLista = new List<string>();
         */
        #endregion Listas
        static void Main(string[] args)
        {
            List<string> myList = new List<string>(); 

            myList.Add("Maria"); 
            myList.Add("Jose"); // Adiciona um elemento no final da lista
            myList.Add("Mariano");

            myList.Insert(2, "Marcos"); // Insere elemento em qualquer indice, mesmo se estiver ocupado (indice, elemento)

            Console.WriteLine("List Count: " + myList.Count); // Exibe a quantidade

            string s1 = myList.Find(x => x[0] == 'A'); // Recebe como argumento, uma função ou exmpressão lambda que retorna algum argumento

            int pos1 = myList.FindIndex(x => x[0] == 'A'); // Busca a primeira posição com a letra A

            int pos2 = myList.FindLastIndex(x => x[0] == 'A'); // Busca a ultima posição com a letra A

            List<string> list2 = myList.FindAll(x => x.Length == 5); // criamos uma lista que recebe um elemento de tamanho 5

            myList.Remove("Jose");
            myList.RemoveAll(x => x[0] == 'M');

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
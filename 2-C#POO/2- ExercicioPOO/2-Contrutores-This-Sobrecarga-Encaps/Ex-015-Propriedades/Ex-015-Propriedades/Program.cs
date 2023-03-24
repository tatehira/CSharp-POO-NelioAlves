using System.Globalization;

namespace Ex_014_Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Explicação
            /* 1- São definições de métodos encapsulados, porém expondo uma sintaxe similar á de atributos e não de métodos
               2- uma propriedade é um membro que podemos: Gravar, ler ou calcular o valor de um campo
               3- Podem ser usadas como se fossem atributos publicos. Más são métodos epeciais chamados de Acessadores
               4- Ela permite que dados sejam acessados e possui segurança e flexibilidade*/ 
            #endregion Explicação

            string produto = "TV";
            double valor = 500.00;
            int qnt = 10;

            Produto p = new Produto(produto, valor, qnt);

            // setando valores na instancia privada encapsulada
            p.Nome = "TV";

            // Chamandos os campos
            Console.WriteLine(p.Nome);

            Console.WriteLine(p.preco);

            Console.WriteLine(p.Quantidade);
        }
    }
}
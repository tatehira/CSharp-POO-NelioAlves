using System.Globalization;

namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade) // CONSTRUTOR QUE RECEBE OBRIGATORIO OS VALORES DOS PARAMETROS.
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) // Adicionado sobrecarga que alem de receber o parametro obrigatorio, seta o valor quantidade default.
        { 
            Nome = nome;
            Preco = preco;
            Quantidade = 10;
        }

        public Produto() // terceira opção para sobrecarga sem obrigatoriedade nos valores - tendo 3 opções, podendo usar as 3 simultaneas
        {

        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
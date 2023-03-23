using System.Globalization;

namespace Ex_014_Encapsulamento
{
    class Produto
    { // Exemplo de encapsulamento. Quando faço isso, não é possível enxergar ele de outra classe.
      // Deve-se criar um método para inserir os valores
        private string _nome;
        private double _preco;
        private int _quantidade;

        #region Sobrecarga
        // CONSTRUTOR QUE RECEBE OBRIGATORIO OS VALORES DOS PARAMETROS. Os parametros poderão ser de outra tela
        public Produto(string nome, double preco, int quantidade) 
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        // Adicionado sobrecarga que além de receber o parametro obrigatório, seta o valor de quantidade default.
        public Produto(string nome, double preco) 
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 10;
        }

        // terceira opção: Sobrecarga sem obrigatoriedade nos valores - tendo 3 opções, podendo usar as 3 simultaneas
        public Produto() 
        {

        }
        #endregion Sobrecarga

        #region Métodos para setor valores na propriedade privada
        // Método para BUSCAR valores do método que foi
        public string GetNome() 
        {
            return _nome;
        }

        // Método para SETAR valores do método que foi
        public void SetNome(string nome)
        {
            if (_nome != null && nome.Length > 4)
                _nome = nome;
            else
                Console.WriteLine("Insira mais que 4 caracteres por favor!");
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        #endregion Métodos para setor valores na propriedade privada

        #region Calculo produtos
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        #endregion Calculo produtos

        // Método que quando chamada a classe Produto, ele retorna esses valores
        public override string ToString() 
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
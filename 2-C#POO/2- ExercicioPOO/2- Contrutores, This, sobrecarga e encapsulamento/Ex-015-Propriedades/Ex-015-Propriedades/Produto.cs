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
        #endregion Sobrecarga

        #region Propriedades usando { Get; Set; }
        //Com esse método, podemos acessar atravez da instancia da classe
        // Assim, estamos ordenando o que pode ser buscando. Pois está sendo passado dentro do get e set
        public string Nome 
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 4) // O value é o valor que está sendo setado no set
                    _nome = value;
            }
        }

        public double preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }
        #endregion Propriedades
    }
}
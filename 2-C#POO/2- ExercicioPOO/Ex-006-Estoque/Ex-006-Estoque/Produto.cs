

namespace Ex_006_Estoque
{
    internal class AdicionarProdutos
    {
        public void Produto()
        {
            Console.WriteLine("===== ESTOQUE SUPER MERCADO ======");
            Console.WriteLine("===== Y - CONTINUAR ======");
            Console.ReadKey();
            Console.Clear();

            Estoque Produtos = new Estoque();
            Console.WriteLine("Entre com as Informações do produto!");
            Console.WriteLine();

            Console.Write("Nome: ");
            Produtos.Nome = Console.ReadLine();

            Console.Write("Valor: ");
            Produtos.Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade em estoque: ");
            Produtos.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {Produtos}");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Digite a quantidade a ser Acrescentada no estoque: ");
            int quant = int.Parse(Console.ReadLine());

            Produtos.AddProtudos(quant);

            Console.WriteLine($"Dados atualizados: {Produtos}");

            Console.Write("Digite a quantidade a ser Removida no estoque: ");
            int Remover = int.Parse(Console.ReadLine());

            Produtos.RemoverProtudos(Remover);

            Console.WriteLine($"Dados atualizados: {Produtos}");
        }
    }
}

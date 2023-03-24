internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Escreva seu nome completo: ");
        string NomeCompleto = Console.ReadLine();
        Console.Write("Digite sua idade : ");
        int IdadeCompleta = int.Parse(Console.ReadLine());
        Console.WriteLine("Informações Pré Digitadas: ");
        Console.WriteLine("=====================================");
        Console.WriteLine(NomeCompleto + " e ");
        Console.WriteLine(IdadeCompleta +  ". ");
        Console.WriteLine("=====================================");

        Console.Write("Entre com: 'Nome, Idade e Estado-Civil'na mesma linha: ");
        string[] Cadastro = Console.ReadLine().Split(' ');
        string Nome = Cadastro[0];
        string Idade = Cadastro[1];
        string StatusCivil = Cadastro[2];

        Console.WriteLine("=====================================");
        Console.WriteLine("Informações do seu cadastro: ");
        Console.WriteLine("=====================================");
        Console.WriteLine("Seu nome é: " + Nome + " Sua idade é: " + Idade + " e seu status Civil é: " + StatusCivil);
        Console.WriteLine("=====================================");
        Console.WriteLine("Obrigado por participar! ");
    }
}
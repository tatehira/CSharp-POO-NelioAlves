namespace Ex_003_MediaSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InformacoesFuncionarios Funcionario1 = new InformacoesFuncionarios();

            InformacoesFuncionarios Funcionario2 = new InformacoesFuncionarios();

            Console.Write("Digite o nome do primeiro funcionario: ");
            Funcionario1.Nome = Console.ReadLine();

            Console.Write("Digite o salario: ");
            Funcionario1.Salario = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Digite o nome do Segundo funcionario: ");
            Funcionario2.Nome = Console.ReadLine();

            Console.Write("Digite o salario: ");
            Funcionario2.Salario = double.Parse(Console.ReadLine());
            Console.Clear();

            var media = (Funcionario1.Salario + Funcionario2.Salario) / 2;

            Console.WriteLine($"A média de salario entre {Funcionario1.Nome} e {Funcionario2.Nome} é {media}! ");
        }
    }
}
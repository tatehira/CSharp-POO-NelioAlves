namespace Ex_001_Pessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InformacoesPessoais Mulher = new InformacoesPessoais();
            InformacoesPessoais Homem = new InformacoesPessoais();

            Console.Write($"Digite o nome do homem: ");
            Homem.Name = Console.ReadLine();

            Console.Write($"Digite a idade do homem: ");
            Homem.Idade = int.Parse(Console.ReadLine());

            Console.Write($"Digite a Altura do homem: ");
            Homem.Altura = Double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write($"Digite o nome da Mulher: ");
            Mulher.Name = Console.ReadLine();

            Console.Write($"Digite a idade da Mulher: ");
            Mulher.Idade = int.Parse(Console.ReadLine());

            Console.Write($"Digite a Altura da Mulher: ");
            Mulher.Altura = Double.Parse(Console.ReadLine());
            Console.Clear();

            if (Homem.Idade > Mulher.Idade)
            {
                Console.WriteLine($"O {Homem.Name} é mais velho que a {Mulher.Name}. Ele possui {Homem.Idade} anos e ela {Mulher.Idade}.");
            }
            else if (Homem.Idade == Mulher.Idade)
            {
                Console.WriteLine($"{Mulher.Name} e {Homem.Name} possuem a mesma idade, tendo {Homem.Idade} anos. ");
            }
            else
            {
                Console.WriteLine($"A {Mulher.Name} é mais velha que o {Homem.Name}. Ela possui {Mulher.Idade} anos e ele {Homem.Idade}.");
            }

        }
    }
}
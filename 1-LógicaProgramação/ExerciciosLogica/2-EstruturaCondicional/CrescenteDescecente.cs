internal class Exercicio
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Numeros: Descrescente e Crescente! ");
        Console.WriteLine("");
        Console.ReadLine();
        Console.Clear();
        int n1, n2;

        Console.Write("Digite o primeiro numero: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo numero: ");
        n2 = int.Parse(Console.ReadLine());

        while (n1 != n2)
        {
            if (n1 < n2)
            {
                Console.Write("Numeros em ordem CRESCENTE! ");
            }
            else if (n2 < n1)
            {
                Console.Write("Numeros em ordem DESCRECENTE! ");
            }
            else
            {
                Console.Write("Numeros Iguais! ");
            }
            break;
        }
    }
}

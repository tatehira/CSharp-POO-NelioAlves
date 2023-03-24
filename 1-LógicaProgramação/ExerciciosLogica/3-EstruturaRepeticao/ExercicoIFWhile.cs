internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Exercicios dia 27/12/22! ");

        int n2 = 3;
        int numero;

        Console.Write("Digite um numero de 1 a 3: ");
        numero = int.Parse(Console.ReadLine());
        Console.Clear();
        
        while (numero != n2)
        {
            Console.WriteLine("Voce errou o numero! Tente novamente.");
            Console.Write("Digite um numero de 1 a 3: ");

            numero = int.Parse(Console.ReadLine());
            Console.Clear();
        }

        if (numero == n2)
        {
            Console.WriteLine("parabens, o numero secredo era: " + n2);
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calculo de notas! Primeira e Segunda prova.");
        Console.ReadLine();
        Console.Clear();
        
        int n1, n2, Media;
        
        Console.Write("Digite a nota da primeira prova: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota da segunda prova: ");
        n2 = int.Parse(Console.ReadLine());

        Media = (n1 + n2) / 2;

        if (Media >= 7)
        {
            Console.WriteLine("A sua média foi: " + Media);
            Console.WriteLine("Voce está Aprovado");
        }
        else if (Media < 7 )
        {
            Console.WriteLine("A sua média foi: " + Media);
            Console.WriteLine("Voce está Reprovado");
        }
     
    }
}
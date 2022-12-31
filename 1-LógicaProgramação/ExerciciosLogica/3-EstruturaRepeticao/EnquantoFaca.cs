internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Conversor de Celsius para Fahrenheit");

        double C, F;
        char continuar;
        
        do 
        {
            Console.Write("Digite a temperatura em Celsius: ");
            C = int.Parse(Console.ReadLine());

            F = 9.0 * C / 5.0 + 32.0;

            Console.WriteLine("Convertendo em F, Celsius fica: " + F);
            
            Console.WriteLine("Deseja continuar a conversão? ");
            continuar = char.Parse(Console.ReadLine());

        } while (continuar == 's');
    }
}
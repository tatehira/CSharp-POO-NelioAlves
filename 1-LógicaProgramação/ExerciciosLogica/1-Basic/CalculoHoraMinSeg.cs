internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("CONVERSOR DE SEGUNDOS PARA HORAS/MINUTOS/SEGUNDOS! ");
        Console.Write("Press 'ENTER' para continuar! ");
        Console.ReadLine();
        Console.Clear();

        Console.Write("Digite o tempo em segundos: ");
        int N = int.Parse(Console.ReadLine());
        Console.Clear();
        
        int CalculoHora = N / 3600;
        int resto = N % 3600;

        int CalculoMinuto = resto / 60;
        int segundo = resto % 60;

        Console.WriteLine(CalculoHora + ":" +CalculoMinuto+ ":" + segundo);
}
}
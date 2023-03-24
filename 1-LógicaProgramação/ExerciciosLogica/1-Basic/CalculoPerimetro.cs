using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double basee, altura, area, diagonal, perimetro;

        Console.Write("Digite a Base: ");
        basee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite a altura: ");
        altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        area = basee * altura;
        perimetro = 2 * (basee + altura);
        diagonal = Math.Sqrt(Math.Pow(basee, 2.0) + Math.Pow(altura, 2.0));

        Console.WriteLine("Area: " + area.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Perimetro: " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Digonal: " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
    }
}
namespace Ex_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double xA, xB, xC, yA, yB, yC; 

            Triangulo x, y = new Triangulo();

            Console.Write("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Entre com as medidas do triangulo y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"Medida do triangulo X: {x.A}, {x.B} E {x.C}");
            Console.WriteLine($"Medida do triangulo y: {y.A}, {y.B} E {y.C}");
        }
    }
}
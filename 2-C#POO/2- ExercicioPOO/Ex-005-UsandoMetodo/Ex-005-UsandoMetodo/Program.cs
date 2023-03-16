namespace Ex_005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("========== PROGRAMA PARA CALCULAR AREA DO TRIANGULO ==========");
            Console.ReadKey();

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

            double areaX = x.CalculoArea();
            double areaY = y.CalculoArea();

            Console.WriteLine($"Area de X = {areaX}");
            Console.WriteLine($"Area de Y = {areaY}");

            if (areaX > areaY)
                Console.WriteLine("Areá de X é maior!");
            else
                Console.WriteLine("Areá de Y é maior!");
        }
    }
}
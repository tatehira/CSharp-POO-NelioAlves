internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calculo Média Idade Aluno! ");
        int cont, media, soma, idade;
        
        soma = 0;
        cont = 0;

        for (int i=1; i <= 3; i++)
        {
            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            cont++;
            soma = idade * i;
        }

        media = soma / cont;

        Console.WriteLine("A soma das idades é: "+ soma);
        Console.WriteLine("A média das idades é: " + media);
    }
}
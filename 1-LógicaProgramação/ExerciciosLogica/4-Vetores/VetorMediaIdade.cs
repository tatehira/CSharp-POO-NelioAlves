using System.Net.Http.Headers;
using System.Runtime.InteropServices;

Console.WriteLine("Média de idade! ");
int numero, somador, contador;
somador = 0;
contador = 0;

Console.Write("Digite um número inteiro. Negativo encerra: ");
numero = int.Parse(Console.ReadLine());

while (numero >= 0)
{
    somador = somador + numero;
    contador++;
    Console.Write("Digite um número inteiro. Negativo encerra: ");
    numero = int.Parse(Console.ReadLine());
    Console.Clear();
}

Console.WriteLine("Programa encerrado! ");

double Media = somador / contador;

Console.WriteLine("A média de " + contador + " idades digitadas, é: " + Media.ToString("F2"));

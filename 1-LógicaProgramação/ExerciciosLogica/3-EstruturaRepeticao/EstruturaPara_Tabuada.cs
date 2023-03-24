using System.Net.Security;
using System.Runtime.Serialization.Formatters;

Console.WriteLine("Testando a estrutura de repetição PARA! ");

Console.Write("Qual tabuada deseja ver? ");
int num = int.Parse(Console.ReadLine());
Console.Clear();

int contador, multiplicador;
contador = 0;
multiplicador= 1;

for (int i = 0; i < 10; i++)
{
    contador ++;
    multiplicador = num * contador;

    Console.WriteLine(+ contador + " X " + num + " = " + multiplicador);
}
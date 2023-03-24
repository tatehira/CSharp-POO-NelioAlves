int a, b, c;

Console.Write("Digite 3 numeros inteiros PRESS ENTER APOS DIGITAR: ");
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());

if (a > b && b < c)
{
    Console.Write("O menor numero é o " + c);
}
else if (a > c && c < b )
{
    Console.Write("O menor numero é o " + b);
}
else if (b > a && a < c)
{
    Console.Write("O menor numero é o " + a);
}
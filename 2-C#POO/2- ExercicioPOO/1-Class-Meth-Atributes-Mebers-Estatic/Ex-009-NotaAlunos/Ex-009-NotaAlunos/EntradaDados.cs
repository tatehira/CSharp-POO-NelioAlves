using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_009_NotaAlunos
{
    internal class EntradaDados
    {
        public void input()
        {
            Cadastros cadastros = new Cadastros();
            Console.Write("Digite seu nome: ");
            cadastros.Nome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("CALCULO - Digite a nota do: ");
            Console.Write("Primeiro bimentre: ");
            cadastros.Nota1 = int.Parse(Console.ReadLine());
            Console.Clear();
            
            Console.Write("Segundo bimentre: ");
            cadastros.Nota2 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Terceiro bimentre: ");
            cadastros.Nota3 = int.Parse(Console.ReadLine());
            Console.Clear();

            var NotaFinal = cadastros.CalculoNota();

            if (NotaFinal > 15)
                Console.Write($"A sua nota é: {NotaFinal} e voce está Aprovado! {NotaFinal - 15} pontos acima da média! ");
            else
                Console.Write($"A sua nota é: {NotaFinal} e voce está Reprovado! {15 - NotaFinal} pontos abaixo da média!  ");

            Console.ReadKey();

            Console.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_008_CalculoSalario
{
    internal class EntradadaDados
    {
        public void input()
        {
            Informacoes informacoes = new Informacoes();

            Console.Write("INFORMAÇÕES USUARIO");
            Console.ReadKey();
            Console.Clear();
            
            Console.Write("Nome: ");
            informacoes.Nome = Console.ReadLine();
            Console.Clear();

            Console.Write("Salario bruto: ");
            informacoes.Salario = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Imposto: ");
            informacoes.Imposto = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"Funcionario: {informacoes}");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Digite o numero da porcentagem para aumento do salario: "); 
            informacoes.adicionar = double.Parse(Console.ReadLine());

            var teste = informacoes.Calculo();

            Console.WriteLine($"O novo salario é: {teste}");
            Console.ReadKey();
            Console.Clear();
       }
    }
}

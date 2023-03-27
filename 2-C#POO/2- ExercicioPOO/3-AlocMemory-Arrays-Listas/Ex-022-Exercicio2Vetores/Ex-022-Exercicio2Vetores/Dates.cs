using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_022_Exercicio2Vetores
{
    internal class Dates
    {
        public void dates()
        {
            Informations informations = new Informations();

            Console.Write("Quantos quartos voce deseja Alugar? ");
            int Quantity = int.Parse(Console.ReadLine());

            Informations[] vetor = new Informations[Quantity];
            for (int i = 1; i <= Quantity; i++)
            {
                if ()
                int Rent =+ i;

                Console.WriteLine($"# {Rent}");
                Console.Write($"{i} Nome: ");
                informations.Name = Console.ReadLine();

                Console.Write($"{i} Email: ");
                informations.Email = Console.ReadLine();

                Console.Write($"{i} Número do quarto: ");
                informations.Rooms = int.Parse(Console.ReadLine());

                Console.Clear();
            }
        }
    }
}

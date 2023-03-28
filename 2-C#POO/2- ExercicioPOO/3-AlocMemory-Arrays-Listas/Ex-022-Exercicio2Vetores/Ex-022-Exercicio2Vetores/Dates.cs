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
            Console.Write("Quantos quartos serão alugados? ");
            int Quantity = int.Parse(Console.ReadLine());
            Console.Clear();

            Informations[] Rooms = new Informations[11];

            for (int i = 1; i <= Quantity; i++)
            {
                Informations informations = new Informations();
                int Rent = +i;

                Console.WriteLine($"#{Rent}");
              
                Console.Write("Nome: ");
                informations.Name = Console.ReadLine();

                Console.Write("E-Mail: ");
                informations.Email = Console.ReadLine();

                Console.Write("Número do quarto: ");
                int numberRooms = int.Parse(Console.ReadLine());
                informations.quarto(numberRooms);

                Rooms[numberRooms - 1] = informations;

                Console.Clear();
            }

            Console.WriteLine("OS QUARTOS ALUGADOS SÃO:");
            for (int i = 1; i <= 11; i++)
            {
                if (Rooms[i] != null)
                {
                    Console.WriteLine(Rooms[i]);
                }
            }
            Console.ReadKey();
            Console.Clear();

        }

    }
}

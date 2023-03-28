using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_022_Exercicio2Vetores
{
    internal class Informations
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int NumberRooms { get; private set; }

        public void quarto(int numberRooms)
        {
            NumberRooms = numberRooms;

        }

        public override string ToString()
        {
            return $"Nome : {Name}, E-Mail: {Email}, Quarto: {NumberRooms}";
        }
    }
}
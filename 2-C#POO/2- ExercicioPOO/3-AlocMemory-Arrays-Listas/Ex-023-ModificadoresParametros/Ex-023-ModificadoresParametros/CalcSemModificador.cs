using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_023_ModificadoresParametros
{
    internal class CalculoSemModificador
    {
        //MÉTODO LIMITADO. POIS SE O USUARIO QUISER SOMAR 10 VALORES NÃO PODERÁ

        public static int SomaSemModificador2Numeros(int N1, int N2) // para somar 2 valores
        {
            return N1 + N2;
        }

        public static int SomaSemModificador4Numeros(int N1, int N2, int N3, int N4) // para somar 4 valores
        {
            return N1 + N2 + N3 + N4;
        }
    }
}

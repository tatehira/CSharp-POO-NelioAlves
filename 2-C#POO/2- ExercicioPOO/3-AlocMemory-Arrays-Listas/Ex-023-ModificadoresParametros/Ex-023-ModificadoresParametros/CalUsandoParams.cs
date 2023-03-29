using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_023_ModificadoresParametros
{
    internal class CalcUsandoParams
    {
                                    //RECEBE UM VETOR NUMERO E FAZ A SOMA DOS NUMEROS
        public static int SomaVetorParams(params int[] numero)
        {
            int soma = 0;

            for (int i = 0; i < numero.Length; i++)
            {
                soma += numero[i];
            }

            return soma;
        }
    }
}

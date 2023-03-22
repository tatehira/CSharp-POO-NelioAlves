using System.Security.Cryptography.X509Certificates;

namespace Ex_016_PropriedadeAutoimplementadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EXPLICAÇÃO
            /*
            - É uma forma simplificada de se declarar propriedades
            - Não necessetam de lógica particulares para as operações get e set

            public int MyProperty {get; set;}
            */
            #endregion EXPLICAÇÃO

            public int Quantiade { get; set; }
            
        }
    }
}
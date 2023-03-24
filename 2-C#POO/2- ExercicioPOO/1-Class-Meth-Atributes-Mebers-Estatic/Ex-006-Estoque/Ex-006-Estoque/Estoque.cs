using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex_006_Estoque
{
    internal class Estoque
    {
        public string Nome;

        public double Preco;
        
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AddProtudos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProtudos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString() // Converte a classe Estoque no retorno
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex_021_ExVetores
{
    internal class EntradaDados
    {
        public void InputDate()
        {
            Console.Write("Digite a quantidade de produtos que deseja cadastrar: ");
            int Quantidade = int.Parse(Console.ReadLine());

            Store[] Vetor = new Store[Quantidade];
            for (int i = 0; i < Quantidade; i++)
            {
                Console.Write($"Digite o nome do {i + 1} produto: ");
                string nome = Console.ReadLine();

                Console.Write($"Digite o valor do {i + 1} produto: ");
                double valor = double.Parse(Console.ReadLine());
                Console.Clear();

                Vetor[i] = new Store { Produto = nome, Valor = valor };
            }

            double Soma = 0.0;

            for (int i = 0; i < Quantidade; i++)
            {
                Soma += Vetor[i].Valor; // ACESSANDO APENAS OS INDICES DE 'VALOR'
            }

            double Media = Soma / Quantidade;
            
            Console.WriteLine($"A média do valor dos produtos deu: {Media}");
        }
    }
}

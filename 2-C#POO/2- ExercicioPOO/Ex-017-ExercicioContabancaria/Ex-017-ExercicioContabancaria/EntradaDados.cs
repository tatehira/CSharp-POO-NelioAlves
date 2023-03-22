using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_017_ExercicioContabancaria
{
    internal class EntradaDados
    {
        public void input()
        {
            DadosBancarios dadosBancarios = new DadosBancarios();

            dadosBancarios.Cabecario();

            Console.Write("DESEJA INICIAR O CADASTRO? { S / N }: ");
            string option = Console.ReadLine().ToUpper();
            Console.Clear();
            dadosBancarios.Cabecario();

            if (option == "S")
            {
                Console.Write("DIGITE O NÚMERO DA CONTA: ");
                int numeroConta = int.Parse(Console.ReadLine());
                dadosBancarios.SetNumeroConta(numeroConta);
                Console.Clear();
                dadosBancarios.Cabecario();

                Console.Write("DIGITE O NOME COMPLETO: ");
                dadosBancarios.NomeConta = Console.ReadLine();
                Console.Clear();
                dadosBancarios.Cabecario();

                Console.Write("DESEJA INICIAR COM ALGUM DEPOSITO? { S / N }: ");
                option = Console.ReadLine().ToUpper();
                Console.Clear();
                dadosBancarios.Cabecario();

                if (option == "S")
                {
                    Console.Write("ENTRE COM UM VALOR PARA DEPÓSITO: ");
                    double deposito = double.Parse(Console.ReadLine());
                    dadosBancarios.SetDeposito(deposito);
                    Console.Clear();
                    dadosBancarios.Cabecario();

                    Console.WriteLine("DADOS ATUALIZADOS!");
                    Console.WriteLine(dadosBancarios);
                    Console.ReadKey();
                    Console.Clear();
                    dadosBancarios.Cabecario();
                }
                else
                {
                    Console.WriteLine("DADOS DA CONTA!");
                    Console.WriteLine(dadosBancarios);
                    Console.ReadKey();
                    Console.Clear();
                    dadosBancarios.Cabecario();
                }

                Console.Write("DESEJA EFETUAR ALGUM SAQUE? { S / N }: ");
                option = Console.ReadLine().ToUpper();
                Console.WriteLine();

                if (option == "S")
                {
                    Console.Write("VALOR DE SAQUE: ");
                    double saque = double.Parse(Console.ReadLine());
                    dadosBancarios.Saque(saque);

                    Console.WriteLine("DADOS ATUALIZADOS: ");
                    Console.WriteLine(dadosBancarios);  
                }
                else
                    dadosBancarios.VolteSempre();
            }
            else
                dadosBancarios.VolteSempre();
        }
    }
}

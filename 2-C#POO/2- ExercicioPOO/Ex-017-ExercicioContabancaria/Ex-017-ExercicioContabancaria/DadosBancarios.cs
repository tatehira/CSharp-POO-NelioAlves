using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_017_ExercicioContabancaria
{
    internal class DadosBancarios
    {
        public int NumeroConta { get; private set; }
        public string NomeConta{ get; set; }
        public double Deposito { get; private set; }


        public void ConsoleClear()
        {
            Console.Write("Deseja limpar a interface? { S / N }: ");
            string limpar = Console.ReadLine().ToUpper();

            if (limpar == "S")
                Console.Clear();
        }

        public DadosBancarios()
        {
            Deposito = 0;
        }

        public int SetNumeroConta(int numeroConta)
        {
            NumeroConta = numeroConta;

            return NumeroConta;
        }

        public double SetDeposito(double deposito)
        {
            Deposito = deposito;

            return Deposito;
        }

        public double Saque(double saque)
        {
            Deposito = Deposito - saque - 5;

            return Deposito;
        }

        public void VolteSempre()
        {
            Console.Clear();
            Console.WriteLine("OBRIGADO PELA VISITA E VOLTE SEMPRE!");
            Console.ReadKey();
            Console.Clear();
        }

        public void Cabecario()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("======= CADASTRO BANCARIO =======");
            Console.WriteLine("=================================");
        }

        public override string ToString()
        {
            return $"Conta: {NumeroConta}, Titular: {NomeConta}, Saldo: {Deposito} R$ (TAXA SAQUE: 5 R$)";
        }
    }
}

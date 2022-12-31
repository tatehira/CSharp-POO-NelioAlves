using System.ComponentModel;
using System.Runtime.Serialization.Formatters;
using System.Globalization;

namespace AulasSharp{
    internal class Program {
        private static void Main(string[] args) {

            string[] vetorstr = { "Nick", "Júlia"};

            for (int i = 0; i < vetorstr.Length; i++) {
                Console.Write("Digite um nome: ");
                string nome = Console.ReadLine();
                Console.Clear();

                if (nome == vetorstr[i])
                {
                    Console.WriteLine("O nome: " + nome + " está no vetor! ");
                }
                else
                {
                    Console.WriteLine("O nome: " + nome + " NÂO está no vetor! ");
                }
            }
        }
    }
}
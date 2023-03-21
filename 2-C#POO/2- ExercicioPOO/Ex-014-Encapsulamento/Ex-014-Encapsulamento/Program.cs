using System.Globalization;

namespace Ex_014_Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Explicação
            /*É um piar que esconde detalhes de implementação de um componente, exponto apenas
                operação segura e qe tenha um estado consistente

            regra de ouro: O Obj deve sempre estar em um estado consistente e a própria classe deve garantir isso.

            Opção 1: Implementação manual
                - Todo atribulo é definido como private
                - Implementa-se métodos Get-Set para cada atributo, conforme regras de negocio
                
            Não é usual na plataforma c#
            
             Ex: Um atribulo com nome publico, pode ser alterado por qualquer classe. No encapsulamento, colocamos ele privado e com '_' antes do nome 
            assim, ele não poderá ser acessado por outra classe, evitando alteração indevida*/
            #endregion Explicação

           Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("TV QLED"); // setando valores na instancia privada encapsulada

            // Chamandos os campos
            Console.WriteLine(p.GetNome()); 

            Console.WriteLine(p.GetPreco());

            Console.WriteLine(p.GetQuantidade());
        }
    }
}
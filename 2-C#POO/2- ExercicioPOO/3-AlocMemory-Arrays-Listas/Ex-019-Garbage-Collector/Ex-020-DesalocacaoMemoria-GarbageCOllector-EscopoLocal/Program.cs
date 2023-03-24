namespace Ex_020_DesalocacaoMemoria_GarbageCOllector_EscopoLocal;
class Program
{
    static void Main(string[] args)
    {
        #region Explicação Garbage Collector
        /*
         * Garbage Collector:
         *  -> é um processo que automatiza o gerenciamento de memoria de um programa em execuçao
         *  -> monitora os obj alocados dinamicamente pelo programa na heap, desalocando aqueles que não estão mais sendo utilizados
         *  
         *  EX: Produto p1, p2;
         *  
         *  p1 = new Produto("TV", 500);
         *  p2 = new Produto("Mouse", 50);
         *  
         *  p1 = p2; 
         *      - automaticamente, p1 passará a apontar para p2 e as informacoes que p1 apontava serão desalocadas
         */
        #endregion Explicação

        #region Explicação Desalocação por escopo
        /*EXMPLO DE NÃO GARBAGE COLLECTOR
         * int x = 10;
         * if (x > 0)
         *  int y = 20;
         *  Console.Write(x); 
         *  = 10
         */
        #endregion Explicação Desalocação por escopo

        #region Resumo
        /*OBJETOS ALOCADOS DINAMICAMENTE QUANDO NÃO POSSUEM MAIS REFERENCIA PRA ELES, SERÃO DESALOCADOS PELO GARBAGE
         * 
         * VARIAVEIS LOCAIS, SÃO DESALOCADAS IMEDIATAMENTE ASSIM QUE SEU ESCOPO LOCAL SAI DA EXECUÇÃO
         */
        #endregion Resumo

    }
}

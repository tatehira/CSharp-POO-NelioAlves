namespace Ex_023_ModificadoresParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Params
            /*
             * O modificador de parametros, permite que voce crie um método para receber valores variaveis. No lugar de ex:
             *  public int Calculo (int a1, int a2)
             *  
             *  desta forma, ele recebe os valores de parametro direto do vetor 
             */
            #endregion Params

            #region Exemplo sem Modificador de parametros
            int s1 = CalculoSemModificador.SomaSemModificador2Numeros(2, 3);

            int s2 = CalculoSemModificador.SomaSemModificador4Numeros(1, 2, 3, 4);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            #endregion Exemplo sem Modificador de parametros

            #region Calculo com vetor simples
            int vetor1 = CalcUsandoVetor.SomaVetor(new int[] { 2, 4 });
            int vetor1 = CalcUsandoVetor.SomaVetor(new int[] { 2, 4, 5, 6 });
            #endregion Calculo com vetor simples

            #region Exemplo COM Modificador de parametros
            int vetor1 = CalcUsandoParams.SomaVetorParams( 2, 4 );
            int vetor1 = CalcUsandoParams.SomaVetorParams(2, 4, 5, 6 );
            #endregion Exemplo COM Modificador de parametros

            // RESUMINDO: O MODIFICADOR DE PARAMETROS, É UM MÉTODO COMUM USANDO VETORES POREM QUANDO ADICIONAMOS 'PARAMS'
            // ANTES DO VETOR NO MÉTODO, NO ATO DA INSTANCIAÇÃO, NÃO PRECISA DE COLCHETES
            // SOMENTE COM PARENTESES DÁ DE FAZER A INSTANCIAÇÃO
        }
    }
}
namespace Ex_024_Modificador_Ref_Out
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            int a = 10; 

            Calculator.RefTriplicar(ref a); // REF

            int triple; // O valor de saída deixou nessa variavel
            Calculator.OutTriplicar(a, out triple);
            Console.WriteLine(triple);
        }

        class Calculator
        {
            #region Modoficador Ref
            // O MODIFICADOR REF - OUT, FAZ COM QUE VOCE REFERENCIE A VARIAVEL ORIGINAL NA INSTANCIA
            // A REFERENCIA OCORRE ATRAVEZ DO PARAMETRO
            public static void RefTriplicar(ref int x)
            {
                x = x * 3;
            }
            #endregion Ref


            #region Modificador out
            // Faz com que voce entre com valor inicial e quarde o resultado em outra variavel
            public static void OutTriplicar(int origin, out int resultado)
            {
                resultado = origin * 3;
            }
            // Modificador out e similar ao ref(faz o parametro ser uma referencia para a var original), más nao exige que a var original serja iniciada
            #endregion Modificador out
        }
    }
}
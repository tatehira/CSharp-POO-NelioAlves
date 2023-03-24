namespace Ex_020_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Nullable
            /*
            É um recurso de C# para que dados de tipos de valor (structs) possam receber o valor null

            Uso comum:
                - Campos de banco de dados possa valor nulo(data nascimento, algum valor númerico etc)
                - Dados e parametros opcionais
            Resumindo: nullable da valor nulo ao struct. Pois os structs nao aceitam nulo por padrão

                        TIPOS PARA USAR NULLABLE
                double x = null;
                Nullable<double> x = null;
                double? x = null;

            METODOS:
                - GetValueOrDefault ("Busque o valo x, se nao existir, traga o default")
                - HasValue (informa se existe ou não um valor)
                - Value (LANÇA UM ERRO SE NÃO TIVER VALOR)
            */
            #endregion Nullable

            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            #region Operador de coalescencia nula
            /*
             double y = x ?? 0.0 //Se o x for nulo, retorne essevalor
             */
            #endregion
            Console.WriteLine("===============================");
            double? a = null;
            double? b = 10;

            double i = a ?? 10;
            double j = b ?? 5;

            Console.WriteLine(i);
            Console.WriteLine(j);
        }
    }
}

using System;
using System.Drawing;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Explicacao struck
            /*
             Tipos de memoria: STACK e HEAP
            STACK: Quando x = y, ela funciona como ponteiro para a heap
            HEAP: Usada para dar referencia
            =========================
            struct
                : São caixas, não ponteiros
                -> quadno x = y, ela copia o valor do Y
             */
            #endregion Explicacao

            Point p;
            p.X = 10;
            p.Y = 10;
            Console.WriteLine(p);
        }
    }
}
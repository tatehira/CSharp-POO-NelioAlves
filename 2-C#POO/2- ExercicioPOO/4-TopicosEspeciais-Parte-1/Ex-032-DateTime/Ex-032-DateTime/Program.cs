using System.Diagnostics.Tracing;
using System.IO.Pipes;
using System.Globalization;

namespace Ex_032_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Um obj datetime internamente armazena
            //        - Object numero de "ticks"(100 nanosegundos)desde a meia noite do DiagnosticCounter 1 de jan do ano 1 
            
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            #region Instanciação
            /*
                DateTime d1 = new DateTime();
            - Construtores
                DateTime(ano, mes, dia)
                dateTime(ano, mes, dia, hora, min, seg) opcional
                dateTime(ano, mes, dia, hora, min, seg, mili) opcional

            - Builders
                DateTime.Now
                DateTime.UtcNow
                DateTime.Today
                DateTime.Parse(string)
                DateTime.ParseExact(string, string)
            */
            #endregion Instanciação

            DateTime dateTime = DateTime.Parse("25/07/2000");
            DateTime dateTime2 = DateTime.Parse("25/07/2000 10:02:34");

            DateTime dateTime3 = DateTime.ParseExact("15/08/2000 13:00:03", " dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        }
    }
}
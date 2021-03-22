using System;
using System.Globalization;

namespace Aula30_POO_DateTime {
    class Program {
        static void Main(string[] args) {
            //Captura a data e hora atual do sistema
            DateTime d1 = DateTime.Now;

            Console.WriteLine("Data completa: " + d1);
            Console.WriteLine("Data completa: " + d1.Date);//desconsiderando a hora
            //Imprimindo dia
            Console.WriteLine("Data separada: " + d1.Day + ":" + d1.Month + ":" + d1.Year);
            //Imprimindo hora completa
            Console.WriteLine("Hora completa: " + d1.Hour + ":" + d1.Minute + ":" + d1.Second);
            Console.WriteLine("Dia da semana: " + d1.DayOfWeek);
            Console.WriteLine("Dia do ano: " + d1.DayOfYear);
            //Imprimindo a data de forma mais completa
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToShortDateString());
            Console.WriteLine(d1.ToLongTimeString());
            Console.WriteLine(d1.ToShortTimeString());
            Console.WriteLine(d1.ToString());
            //Criando formatação
            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}

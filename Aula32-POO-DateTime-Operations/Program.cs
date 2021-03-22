using System;

namespace Aula32_POO_DateTime_Operations {
    class Program {
        static void Main(string[] args) {
            DateTime dataGerarBoleto = DateTime.Now;
            Console.WriteLine(dataGerarBoleto);
            //Acrescentando Dias
            DateTime dataVencimentoBoleto = dataGerarBoleto.AddDays(2);
            Console.WriteLine("Data geração boleto: " + dataGerarBoleto);
            Console.WriteLine("Data vencimento boleto: " + dataVencimentoBoleto);
            //Acrescentando Horas
            Console.WriteLine("Acrescentando 2 horas: " + dataGerarBoleto.AddHours(2));
        }
    }
}

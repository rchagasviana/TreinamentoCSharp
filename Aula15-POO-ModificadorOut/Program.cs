using System;

namespace Aula15_POO_ModificadorOut {

    /*
     O modificador out é similar ao ref, mas não exige que a variável original seja iniciada.
     
     */
    class Program {
        static void Main(string[] args) {

            int a = 10;
            int destino;
            Calculadora.Triplo(a, out destino);
            Console.WriteLine(destino);
        }
    }
}

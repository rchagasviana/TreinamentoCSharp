using System;

namespace Aula29_POO_Inferencia_PalavraVar {

    /*
     A palavra reserva var permite que o tipo da variável seja inferido
    conforme o tipo usado para iniciar a variável
     */
    class Program {
        static void Main(string[] args) {
            var a = 10; // por inferência será considerada int
            var b = 2.3; // será considerada tipo double
            var nome = "palavra"; // será considerada string

        }
    }
}

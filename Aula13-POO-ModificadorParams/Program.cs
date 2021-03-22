using System;

namespace Aula13_POO_ModificadorParams {

    /*
     O modificador params permite receber uma quantidade variável
     de parâmetros sem precisar usar a sobrecarga como desmonstrados no exemplo abaixo
     */
    class Program {
        static void Main(string[] args) {
            //Sem usar o params
            int soma1 = Calculadora.SomaModelo01(new int[] { 2, 3 });
            Console.WriteLine("Função em usar params: " + soma1);
            //Usando params
            int soma2 = Calculadora.SomaModelo02(2, 3);
            Console.WriteLine("Usando params: " + soma2);
        }
    }
}

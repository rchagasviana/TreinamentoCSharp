using System;
using System.Collections.Generic;
using System.Text;

namespace Aula13_POO_ModificadorParams {
    class Calculadora {

        //Implementação sem usar o params
        public static int SomaModelo01(int[] numeros) {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++) {
                soma += numeros[i]; // equivale a soma=soma+numeros[i]
            }
            return soma;
        }
        //Implementação usando o params
        public static int SomaModelo02(params int[] numeros) {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++) {
                soma += numeros[i];
            }
            return soma;
        }

    }
}

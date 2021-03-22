using System;
using System.Collections.Generic;

namespace Aula20_POO_Listas_Count__ {
    class Program {
        static void Main(string[] args) {
            List<int> numeros = new List<int>();
            for (int i = 0; i < 30; i++) {
                numeros.Add(i + 1);
            }
            //Verificando os elementos da lista
            Console.WriteLine("Possui " + numeros.Count + " elementos");
        }
    }
}

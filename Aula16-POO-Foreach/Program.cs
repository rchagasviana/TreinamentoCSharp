using System;

namespace Aula16_POO_Foreach {

    /*
     Laço foreach é utilizado para percorrer coleções
     Leitura: para cada objeto 'obj' contido em vect, faça:
     */
    class Program {
        static void Main(string[] args) {
            //Preencher assim:
            int[] numeros = new int[3];
            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            //Ou preencher assim:
            int[] idades = new int[] { 20, 30, 40 };

            //Percorrer com o foreach
            foreach (int receber in numeros) {
                Console.WriteLine(receber);
            }
        }
    }
}

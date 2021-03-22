using System;
using System.Collections.Generic;
namespace Aula19_POO_Listas_Insert__ {
    class Program {
        static void Main(string[] args) {
            
            List<string> listaLivrosBiblia = new List<string>();

            listaLivrosBiblia.Add("Gênesis");
            listaLivrosBiblia.Add("Levítico");
            listaLivrosBiblia.Add("Números");

            foreach (string receber in listaLivrosBiblia ) {
                Console.WriteLine(receber);
            }
            Console.WriteLine("---------------------------------------");
            //Inserindo um elemento na segund posição da lista
            listaLivrosBiblia.Insert(1,"Êxodo");
            foreach (string receber in listaLivrosBiblia) {
                Console.WriteLine(receber);
            }

        }
    }
}

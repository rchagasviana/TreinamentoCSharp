using System;
using System.Collections.Generic;

namespace Aula21_POO_Listas_Find__ {
    class Program {
        static void Main(string[] args) {

            List<string> listaCidades = new List<string>();
            //Adicionando elementos
            listaCidades.Add("Imperatriz");
            listaCidades.Add("São Luís");
            listaCidades.Add("Barreirinhas");
            listaCidades.Add("Bacabal");
            listaCidades.Add("Caxias");
            listaCidades.Add("São Bento");
            //Imprimindo lista
            Console.WriteLine("Elemento da lista");
            Console.WriteLine("------------------------------");
            int contador = 0;
            foreach (string receber in listaCidades) {
                Console.WriteLine("Posição: " + contador + "-" + receber);
                contador++;
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Imprimindo busca:");
            Console.WriteLine("------------------------------");
            /*
             * Buscando por um elemento conforme determinadas condições
            */
            //Primeira ocorrência de quem começa com a letra A
            string resultadoBusca01 = listaCidades.Find(elemento => elemento[0] == 'S');
            Console.WriteLine("Primeiro elemento que começa com a letra S: " + resultadoBusca01);
            //Última ocorrência de quem começa com a letra B
            string resultadoBusca02 = listaCidades.FindLast(elemento => elemento[0] == 'B');
            Console.WriteLine("Último elemento que começa com a letra B: " + resultadoBusca02);
            //Descobrir a posição do primeiro elemento que começa com B
            int resultadoBusca03 = listaCidades.FindIndex(elemento => elemento[0] == 'B');
            Console.WriteLine("Índice do primeiro elemento que começa com B: " + resultadoBusca03);
            //Descobrir a posição do último elemento que começa com B
            int resultadoBusca04 = listaCidades.FindLastIndex(elemento => elemento[0] == 'B');
            Console.WriteLine("Índice do último elemento que começa com B: " + resultadoBusca04);


        }
    }
}

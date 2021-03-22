using System;
using System.Collections.Generic;

namespace Aula17_POO_Listas_Parte01 {
    /*
    *Lista é uma estrutura de dados:
        -Homogêna (dados do mesmo tipo);
        -Ordenada (os elementos são acessados por meio de posição)
        -Inicia vazia e seus elementos são alocados sob demanda
        -Cada elemento ocupa um "nó" (nodo) da lista
    *Classe: List
    *Namespace: System.Collections.Generic
    *Vantagens:
        -Tamanho variável
        -Facilidade para se relizar inserções e deleções
    *Desvantagens:
        -Acesso sequencial aos elementos
     */
    class Program {
        static void Main(string[] args) {
            //Criando e Adicinando elementos
            List<int> numeros = new List<int>();
            numeros.Add(1);
            numeros.Add(40);
            numeros.Add(50);
            numeros.Add(200);
            //Outra forma de criar e adicionar elementos
            List<string> estados = new List<string> {"MA","RJ","SP"};

        }
    }
}

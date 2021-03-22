using System;
using System.Collections.Generic;

namespace Aula18_POO_Listas_Parte02 {
    /*
    -Inserir elemento na Lista: Add, Insert
    -Tamanho da Lista: Count
    -Encontrar o primeiro ou último elementos da lista que satisfaça um
    predicado: list.Find, list.FindLast
    -Encontrar primeira ou última posição de elemento da lista que 
    satisfaça um predicado: list.FindIndex, list.FindLastIndex
    -Filtrar a lista com base em um predicado: list.FindAll
    -Remover elementos da lista: Remove, RemoveAll, RemoveAt,RemoveRange
     */
    class Program {
        static void Main(string[] args) {
            //O método Add() adiciona elemento sempre ao final da Lista
            List<string> listaDeEstados = new List<string>();
            listaDeEstados.Add("Maranhão");
            listaDeEstados.Add("Pará");
            listaDeEstados.Add("São Paulo");
            foreach (string receberDados in listaDeEstados ) {
                Console.WriteLine(receberDados);
            }
        }
    }
}

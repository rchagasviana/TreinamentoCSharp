using System;
using System.Collections.Generic;
namespace Aula25_POO_Listas_RemoveAt__ {
    class Program {
        static void Main(string[] args) {
            List<string> listaEstados = new List<string>();
            listaEstados.Add("Acre");
            listaEstados.Add("Alagoas");
            listaEstados.Add("Ceará");
            listaEstados.Add("Maranhão");
            listaEstados.Add("Paraná");
            listaEstados.Add("Santa Catarina");
            //Impressão antes da remoção
            Console.WriteLine("ANTES DA REMOÇÃO");
            int contador = 0;
            foreach (string receberDados in listaEstados) {
                Console.WriteLine(contador + "-" + receberDados);
                contador++;
            }
            Console.WriteLine("TAMANHO: " + listaEstados.Count + " elementos");
            //Impressão após a remoção
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("APÓS A REMOÇÃO");
            //Remover o elemento que está em um posição específica
            listaEstados.RemoveAt(4);
            int contador02 = 0;
            foreach (string receberDados in listaEstados) {
                Console.WriteLine(contador02 + "-" + receberDados);
                contador02++;
            }
            Console.WriteLine();
            Console.WriteLine("TAMANHO: " + listaEstados.Count + " elementos");
        }
    }
}

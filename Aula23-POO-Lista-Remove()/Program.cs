using System;
using System.Collections.Generic;

namespace Aula23_POO_Lista_Remove__ {
    class Program {
        static void Main(string[] args) {
            List<string> listaEstados = new List<string>();
            listaEstados.Add("Acre");
            listaEstados.Add("Alagoas");
            listaEstados.Add("Amapá");
            listaEstados.Add("Amazonas");
            listaEstados.Add("Ceará");
            listaEstados.Add("Maranhão");
            listaEstados.Add("Mato Grosso");
            listaEstados.Add("Pará");
            listaEstados.Add("Paraná");
            listaEstados.Add("Santa Catarina");
            //Impressão antes da remoção
            Console.WriteLine("ANTES DA REMOÇÃO");
            int contador = 0;
            foreach (string receberDados in listaEstados) {
                Console.WriteLine(contador + "-" + receberDados);
                contador++;
            }
            Console.WriteLine();
            Console.WriteLine("TAMANHO: " + listaEstados.Count + " elementos");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            //Impressão após a remoção
            Console.WriteLine("APÓS A REMOÇÃO");
            listaEstados.Remove("Acre");
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

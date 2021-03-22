using System;
using System.Collections.Generic;

namespace Aula22_POO_Lista_FindAll__ {
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

            //Criando uma nova lista com base em uma condição
            List<string> listaResultado = new List<string>();
            listaResultado = listaEstados.FindAll(elemento => elemento[0] == 'A');
            foreach (string receberDados in listaResultado) {
                Console.WriteLine(receberDados);
            }



        }
    }
}

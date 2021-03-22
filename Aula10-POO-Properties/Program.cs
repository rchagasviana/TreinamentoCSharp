using System;

namespace Aula10_POO_Properties {
    class Program {
        /*
         Propriedades
            -São definições de métodos encapsulados,porém expondo uma
            sintaxe similar à de atributos e não a de métodos.
         */
        static void Main(string[] args) {
            Produto p1 = new Produto();
            p1.Nome = "Máquina de Lavar";
            p1.Preco = 1300.00;
            p1.Quantidade = 1;
            Console.WriteLine(p1.Nome + ", " + p1.Preco + ", " + p1.Quantidade);
        }
    }
}

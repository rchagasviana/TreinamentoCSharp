using System;

namespace Aula10_POO_AutoProperties {

    /*
     Auto Properties ou Propriedades autoimplementadas
        -É uma forma simplificada de declarar propriedades que não necessitam
        de lógicas particulares para as operações get e set;
        -No exemplo anterior foi necessária a verificação do preço antes de
        efetuar a atribuição, logo para a variável de instância _preco
        a autopropetites não é recomendada.
        -Em outras palavras, o get e set são definidos diretamente na declaração
        do atributo. Deixando, dessa forma, o código menos verboso;
     */
    class Program {
        static void Main(string[] args) {
            Produto p1 = new Produto();
            p1.Nome = "Geladeira";
            Console.WriteLine(p1.Nome);
        }
    }
}

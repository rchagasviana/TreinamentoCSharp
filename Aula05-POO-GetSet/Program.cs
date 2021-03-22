using System;

namespace Aula05_POO_GetSet {
    class Program {
        static void Main(string[] args) {
            //TESTANDO CONSTRUTOR VAZIO
            Produto produto01 = new Produto();
            produto01.Nome = "Monitor LG";
            produto01.Preco = 1.200;
            produto01.Quantidade = 1;
            Console.WriteLine("CONSTRUTOR VAZIO");
            Console.WriteLine(produto01);

            //TESTANDO CONSTRUTOR COM PARÂMETROS
            Console.WriteLine();
            Produto produto02 = new Produto("Alienware 17",2.500,2);
            Console.WriteLine("CONSTRUTOR COM PARÂMETROS");
            Console.WriteLine(produto02);
        }
    }
}

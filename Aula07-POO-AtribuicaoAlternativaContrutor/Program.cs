using System;

namespace Aula07_POO_AtribuicaoAlternativaContrutor {
    class Program {
        static void Main(string[] args) {

            Produto p1 = new Produto { 
                Nome = "TV", 
                Preco = 2.000, 
                Quantidade = 10 
            };
            Console.WriteLine(p1);


        }
    }
}

using System;

namespace Aula06_POO_Sobrecarga {
    class Program {
        static void Main(string[] args) {

            //CHMANDO O CONSTRUTOR PADRÃO
            Produto p1 = new Produto();
            //ACESSANDO OS ATRIBUTOS DE INSTÂNCIA DIRETAMENTE -get e set ainda não implementados
            p1.Nome = "Notebook";
            p1.Preco = 2.500;
            p1.Quantidade = 2;
            Console.WriteLine(p1);
            //CHAMANDO O CONSTRUTOR COM DOIS PARÂMETROS
            Produto p2 = new Produto("Monitor LG-29'-UltraWide", 2.200);
            Console.WriteLine(p2);
            //CHAMANDO O CONSTRUTOR COM TRÊS PARÂMETROS
            Produto p3 = new Produto("Placa de Vídeo",10.000,2);
            Console.WriteLine(p3);

        }
    }
}

using System;

namespace Aula08_POO_PalavraThis {
    /*
     A Palavra "this"
    -É uma referência para o próprio objeto
    -Usos comuns:
        -Diferenciar atributos de variáveis locais(java).
         Não é comum em C# devido o padrão usado para nomear as variáveis de classe em C#
        -Referenciar outro construtor em um construtor;
        -Passar o próprio objeto cmo argumento na chamada de um método ou construtor;    
     */
    class Program {
        static void Main(string[] args) {
            Produto p1 = new Produto("Carro",60.000,1);
            Console.WriteLine(p1);
        }
    }
}
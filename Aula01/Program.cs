using System;

namespace Aula01 {
    class Program {
        static void Main(string[] args) {
            int opcao = 0;
            do {
                Console.WriteLine("1-Soma");
                Console.WriteLine("2-Subtração");
                Console.WriteLine("3-Multiplicação");
                Console.WriteLine("4-Divisão");
                Console.WriteLine("5-Equação do Segundo Grau");
                Console.WriteLine();
                try {
                    Console.Write("Digite sua opção: ");
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException e) {
                    Console.WriteLine("A exceção -> " + e.Message + " <- ocorreu");
                    Console.WriteLine("Digite um valor entre o intervalor 1-5");
                }
                //Console.WriteLine("CONDIÇÃO: " + ((opcao == 1) || (opcao == 2)));
            } while ((opcao != 1) && (opcao != 2) && (opcao != 3) && (opcao != 4) && (opcao != 5));
            Console.WriteLine("O valor da opção fora: ");
        }
    }
}

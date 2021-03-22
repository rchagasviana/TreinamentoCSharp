using System;

namespace Aula28_POO_Matriz_Problema {
    /*
     Solicitar ao usuário que escolha a ordem da matriz. preencha os valores.
     Após o preenchimento dos valores, efetuar a impressão da diagonal principal
     e da quantidade de números negativos.
     */

    class Program {
        static void Main(string[] args) {

            Console.Write("Digite a ordem da Matrix: ");
            int ordemMatriz = int.Parse(Console.ReadLine());
            //Criando um Matriz com tamanho definido pelo usuário
            int[,] matriz = new int[ordemMatriz, ordemMatriz];

            for (int linha = 0; linha < ordemMatriz; linha++) {
                Console.WriteLine();
                for (int coluna = 0; coluna < ordemMatriz; coluna++) {
                    Console.Write("Linha: " + linha);
                    Console.Write(", Coluna: " + coluna);
                    Console.WriteLine();
                    Console.Write("Elemento: ");
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }
            //Impressão da Matriz
            Console.WriteLine("Matriz construída");
            for (int linha = 0; linha < ordemMatriz; linha++) {
                Console.WriteLine();
                for (int coluna = 0; coluna < ordemMatriz; coluna++) {
                    Console.Write(matriz[linha, coluna]);
                }
            }
            Console.WriteLine();
            //Impressão de valores
            Console.Write("Diagonal Principal: ");
            int contadorNegativo = 0;
            for (int linha = 0; linha < ordemMatriz; linha++) {
                for (int coluna = 0; coluna < ordemMatriz; coluna++) {
                    if (matriz[linha, coluna] < 0) {
                        contadorNegativo++;
                    }
                    if (linha == coluna) {
                        Console.Write(matriz[linha, coluna] + " ");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Quantidade de números negativos: " + contadorNegativo);
        }
    }
}

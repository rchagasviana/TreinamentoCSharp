using System;

namespace Aula27_POO_Matrizes_Conceito {
    class Program {
        /*
         *Matriz é o nome dado a arranjos muldimensionais
         *Arranjo é uma estutura de dados:
         *  -Homogênea (dados do mesmo tipo)
         *  -Ordenada (Elementos são acessados por meio de posições)
         *  -Alocada de uma vez só, em um bloco contíguo de memória
         *Vantagens:
         *  -Acesso imediato aos elementos pela sua posição
         *Desvantagens:
         *  -Tamanho fixo;
         *  -Dificuldade para se realizar inserções e deleções
         *Sintaxe:
         *   tipo[,] nomeVariavel = new tipo[numeroLinha, numeroColuna];
         */
        static void Main(string[] args) {
            int[,] tabela = new int[5, 5];

            //Preenchendo Matriz
            for (int linha = 0; linha < 5; linha++) {
                for (int coluna = 0; coluna < 5; coluna++) {
                    if ((linha == 0) || (coluna == 0)) {
                        tabela[linha, coluna] = 10;
                    }
                    else {
                        tabela[linha, coluna] = (linha + 9) * coluna;
                    }
                }
            }
            //Imprimindo Matriz
            for (int linha = 0; linha < 5; linha++) {
                for (int coluna = 0; coluna < 5; coluna++) {
                    Console.Write(" " + tabela[linha, coluna]);
                }
                Console.WriteLine();
            }

        }
    }
}

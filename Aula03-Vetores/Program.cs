using System;

namespace Aula03_Vetores {
    class Program {
        static void Main(string[] args) {
            /*
             tipo [] nomeDoVetor = new tipo[tamanho];
             */

            int[] vetor;
            vetor = new int[10];
            vetor[0] = 0;
            //LENDO VALORES
            for (int i = 0; i < 10; i++) {
                Console.WriteLine();
                Console.Write("Digite o " + $"{i + 1}" + " valor: ");
                vetor[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("O valor digitado foi: " + vetor[i]);
            }
        }
    }
}

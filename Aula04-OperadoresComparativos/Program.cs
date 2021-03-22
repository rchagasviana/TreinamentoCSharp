using System;

namespace Aula04_OperadoresComparativos {
    class Program {
        static void Main(string[] args) {
            /*
             > (maior)
             < (menor)
             >= (maior igual)
             <= (menor igual)
             == (igual)
             != (diferente)  
             */
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            if (idade < 18) {
                Console.WriteLine("Você é menor de idade!");
            }
            else if (idade == 18) {
                Console.WriteLine("Você já tem 18 anos!");
            }
            else {
                Console.WriteLine("Você possui mais de 18 anos!");
            }
        }
    }
}

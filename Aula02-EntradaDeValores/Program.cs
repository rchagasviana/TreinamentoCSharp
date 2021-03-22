using System;
using System.Globalization;

namespace Aula02_EntradaDeValores {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("String: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Letra: ");
            char letra = char.Parse(Console.ReadLine());
            Console.WriteLine("Inteiro: ");
            int numeroInteiro = int.Parse(Console.ReadLine());
            Console.WriteLine("Double com vírgula: ");
            double numeroDecimal01 = double.Parse(Console.ReadLine());
            Console.WriteLine("Double com ponto: ");
            double numeroDecimal02 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Float: ");
            double numeroDecimal03 = float.Parse(Console.ReadLine());

        }
    }
}

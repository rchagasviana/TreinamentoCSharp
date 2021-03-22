using System;
using System.Globalization;

namespace Aula09_POO_Encapsulamento_SetGet {
    /*
     Implementação manual
        -Todo atributo é definido como private;
        -Implementa-se métodos Get e Set para cada atributo, conforme
        as regras de negócio;
        -Nota: Métodos ge e set não são usuais na plataforma C# devido ao uso
        das propetities     
     */
    class Program {
        static void Main(string[] args) {
            Produto p1 = new Produto();
            p1.SetNome("Televisão");
            p1.SetPreco(5000.00);
            p1.SetQuantidade(5);
            Console.WriteLine(p1.GetNome() +","
                + p1.GetPreco().ToString("F2",CultureInfo.InvariantCulture)
                +", "+ p1.GetQuantidade());
        }
    }
}

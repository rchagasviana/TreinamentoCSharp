using System;

namespace Aula14_POO_ModificadorRef {

    /*
     O modificador "ref" permite a passagem e recebimento do endereço. A inicialização
     da variável não é obrigatória, ou seja, pode ser apenas declarada.     
     */


    class Program {
        static void Main(string[] args) {
            //Sem a implementação do ref
            int a = 10;
            Calculadora.TriplicarModelo01(a);
            Console.WriteLine(a);

            //Com a implementação do ref
            int b = 10;
            Calculadora.TriplicarModelo02(ref b);//neste caso passa a referência (endereço)
            Console.WriteLine(b);
        }
    }
}

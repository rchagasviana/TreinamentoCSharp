using System;
using System.Collections.Generic;
using System.Text;

namespace Aula14_POO_ModificadorRef {
    class Calculadora {

        //Sem a implementação do ref
        public static void TriplicarModelo01(int x) {
            x = x * 3;
        }

        //Com a implementação do ref
        public static void TriplicarModelo02(ref int x) { //recebe a referência (endereço)
            x = x * 3;        
        }
    }
}

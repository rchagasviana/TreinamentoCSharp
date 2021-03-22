using System;
using System.Collections.Generic;
using System.Text;

namespace Aula15_POO_ModificadorOut {
    class Calculadora {

        public static void Triplo(int origem, out int destino) {
            destino = origem * 3;
        }
    }
}

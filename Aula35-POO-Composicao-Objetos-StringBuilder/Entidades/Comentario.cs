using System;
using System.Collections.Generic;
using System.Text;

namespace Aula35_POO_Composicao_Objetos_StringBuilder.Entidades {
    class Comentario {

        public string Texto { get; set; }

        public Comentario() { }
        public Comentario(string texto) {
            Texto = texto;
        }
    }
}

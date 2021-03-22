using System;
using System.Collections.Generic;
using System.Text;

namespace Aula40_POO_ClassesAbstratas.Entidades {
    abstract class ContaPessoaJuridica : Conta {

        public string Cnpj { get; set; }

        protected ContaPessoaJuridica() {
        }
        protected ContaPessoaJuridica(string cnpj) {
            Cnpj = cnpj;
        }
    }



}

using System;
using System.Collections.Generic;
using System.Text;
using Aula40_POO_ClassesAbstratas.Entidades.Enums;

namespace Aula40_POO_ClassesAbstratas.Entidades {
    abstract class ContaPessoaFisica:Conta {
        public int Cpf { get; set; }
        public Sexo Sexo { get; set; }

        protected ContaPessoaFisica() {
        }

        protected ContaPessoaFisica(int cpf, Sexo sexo) {
            Cpf = cpf;
            Sexo = sexo;
        }
    }
}

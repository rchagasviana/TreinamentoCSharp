using System;
using System.Collections.Generic;
using System.Text;

namespace Aula40_POO_ClassesAbstratas.Entidades {
    class ContaPoupanca : ContaPessoaFisica {

        /*
         Uma regra de negócio criada para diferenciar uma poupança
         de outras contas e tornar o exemplo mais didático   
         */
        public double BeneficioMensal { get; set; }


        public override void Emprestimo() {
            throw new NotImplementedException();
        }
    }
}

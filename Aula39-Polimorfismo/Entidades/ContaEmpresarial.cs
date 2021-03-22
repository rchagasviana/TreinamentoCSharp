using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aula39_Polimorfismo.Entidades {
    class ContaEmpresarial : Conta {

        public double LimiteEmprestimo { get; set; }
        public string Cnpj { get; set; }

        public ContaEmpresarial() { }

        //Reaproveitando o construtor da superclasse
        public ContaEmpresarial(int numero, string titular,
            double saldo, double limiteEmprestimo, string cnpj) : base(numero, titular, saldo) {
            LimiteEmprestimo = limiteEmprestimo;
            Cnpj = cnpj;
        }
        //Reaproveitando Método EfeturarSaque e adicionando mudanças
        public override void EfetuarSaque(double valorSaque) {
            base.EfetuarSaque(valorSaque); //Aproveita a implementação anterior
            Saldo = Saldo - 10; // Adiciona uma especificidade da classe ContaEmpresarial
        }


        /*
          "A palavra reservada sealed" só ser usada em duas situações:
            1)Em classes para evitar que estas sejam herdadas
            2)Em métodos que já foram sobresposto (exemplo abaixo) para que estes não
              possam ser mais modificados por subclasses  
         */

        public sealed override string Mensagem() { // neste caso as classes filhas de ContaEmpresarial não poderão sobrescrever este método
            return base.Mensagem() + " -> " + Titular;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            //Adicionando os valores inerentes somente à classe ContaEmpresarial

            sb.AppendLine(Mensagem());
            sb.AppendLine("CNPJ:" + Cnpj);
            sb.AppendLine("Empresa: " + Titular);
            sb.AppendLine("Número da Conta: " + Numero);
            sb.AppendLine("Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture)); ;
            return sb.ToString();
        }


    }
}

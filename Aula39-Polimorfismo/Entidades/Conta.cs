using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aula39_Polimorfismo.Entidades {
    class Conta {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public string MensagemAoCliente { get; private set; }

        public Conta() {
        }

        public Conta(int numero, string titular, double saldo) {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        /*
            A palavra reserva "virtual" permite que o método possa
            ser sobrescrito pela classe-filha
         */
        public virtual void EfetuarSaque(double valorSaque) {
            Saldo = Saldo - valorSaque;
        }

        /*
         Sem a notação virtual o método não pode ser sobrescrito
         na classe filha   
         */
        public void EfetuarDeposito(double valorDepositar) {
            Saldo = Saldo + valorDepositar;
        }


        public virtual string Mensagem() {
            MensagemAoCliente = "Seja Bem-Vindo(a) ao nosso Banco";
            return MensagemAoCliente;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Mensagem());
            sb.AppendLine("");
            sb.AppendLine("Número: " + Numero);
            sb.AppendLine("Titular: " + Titular);
            sb.AppendLine("Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}

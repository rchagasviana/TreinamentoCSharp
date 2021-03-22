using System;
using System.Collections.Generic;
using System.Text;
using Aula40_POO_ClassesAbstratas.Entidades.Enums;

namespace Aula40_POO_ClassesAbstratas.Entidades {
    abstract class Conta {
        public string Numero { get; set; }
        public string Agencia { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public Status Status { get; set; }

        protected Conta() {
        }

        protected Conta(string numero, string agencia, string titular,
            double saldo, Status status) {
            Numero = numero;
            Agencia = agencia;
            Titular = titular;
            Saldo = saldo;
            Status = status;
        }

        public void Depositar(double valorDepositar) {
            Saldo = Saldo + valorDepositar;
        }

        public void Sacar(double valorSacar) {
            Saldo = Saldo - valorSacar;
        }

        //Implementação obrigatória nas clases concretas que herdarem esta classe
        public abstract void Emprestimo();


    }
}

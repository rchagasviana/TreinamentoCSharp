using System;
using Aula39_Polimorfismo.Entidades;

namespace Aula39_Polimorfismo {
    class Program {
        static void Main(string[] args) {
            Conta conta01 = new Conta();
            Conta conta02 = new ContaEmpresarial();

            /*Polimorfismo em tempo de execução. O compilador só saberá qual método
             * ser chamado em tempo de execução
             */
            conta01.EfetuarDeposito(5000.00);
            conta02.EfetuarDeposito(20000.00);

        }
    }
}

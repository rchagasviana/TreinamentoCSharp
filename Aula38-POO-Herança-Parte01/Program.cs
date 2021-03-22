using System;

using Aula38_POO_Herança_Parte01.Entidades;

namespace Aula38_POO_Herança_Parte01 {

    /*É um tipo de associação que permite que uma classe herde dados
     * e comportamentos de outra classe
     * Vantagens: Reuso, Polimorfismo
     * Sintaxe: Classe:ClasseHerdar
     *          base -> é usada para referenciar a superclasse    
     */
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("CONTA PADRÃO");
            Conta conta = new Conta(1234,"Rafael",3000.00);
            Console.WriteLine(conta);
            Console.WriteLine("Depositando - R$ 500,00");
            conta.EfetuarDeposito(500.00);
            Console.WriteLine(conta);
            Console.WriteLine("Sacando - R$ 1000,00");
            conta.EfetuarSaque(1000.00);
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.WriteLine("CONTA EMPRESARIAL");
            Conta contaEmpresarial =  // ou ContaEmpresarial contaEmpresarial
                new ContaEmpresarial(102030,"Empresa de TI",50000.00,10000.00,"44.103.106/0001-96");
            Console.WriteLine(contaEmpresarial);
            Console.WriteLine("__________________________");
            Console.WriteLine("Depositando - R$ 5000,00");
            Console.WriteLine("__________________________");
            contaEmpresarial.EfetuarDeposito(5000.00);
            Console.WriteLine(contaEmpresarial);
            Console.WriteLine("__________________________");
            Console.WriteLine("Sacando - R$ 2000,00");
            Console.WriteLine("__________________________");
            contaEmpresarial.EfetuarSaque(2000.00);
            Console.WriteLine(contaEmpresarial);

        }
    }
}

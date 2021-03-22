using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aula06_POO_Sobrecarga {
    class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() { }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public override string ToString() {
            return "NOME: "+Nome
                + ",PREÇO: R$" + Preco.ToString("F3", CultureInfo.InvariantCulture)
                + ",QUANTIDADE: " + Quantidade + " em estoque";
        }
    }
}

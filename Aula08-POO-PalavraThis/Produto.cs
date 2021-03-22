using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Aula08_POO_PalavraThis {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() {
            Quantidade = 1; //iniciando a quantidade com 1 em estoque já
        }
        //Neste caso a implementação do construtor vazio é aproveitada
        public Produto(string nome, double preco) : this() {
            Nome = nome;
            Preco = preco;
        }
        //A implementação do Construtor com o parâmetro "nome" e "preço" é aproveitada
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            Quantidade = quantidade;
        }
        public override string ToString() {
            return "NOME: " + Nome
                + ",PREÇO: R$" + Preco.ToString("F3", CultureInfo.InvariantCulture)
                + ",QUANTIDADE: " + Quantidade + " em estoque";
        }
    }
}

using System.Globalization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05_POO_GetSet {
    class Produto {

        //Seguindo a convenção C# para criação de nome de atributos com letra maíuscula
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() { }
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public override string ToString() {
            return Nome
                + ",R$" + Preco.ToString("F3",CultureInfo.InvariantCulture) 
                + "," + Quantidade+ " em estoque";
        }
    }
}

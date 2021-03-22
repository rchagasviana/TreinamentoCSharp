using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Aula09_POO_Encapsulamento_SetGet {
    class Produto {

        /*
         * Observação:
         Quando o atributo tem o modificador "private". Usa-se o _ na frente do
         nome dele e a primeira letra minúscula.
         */
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto() {
            _quantidade = 0;
        }
        public Produto(string nome, double preco) : this() {
            _nome = nome;
            _preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            _quantidade = quantidade;
        }
        public String GetNome() {
            return _nome;
        }
        public void SetNome(string nome) {
            _nome = nome;
        }
        public double GetPreco() {
            return _preco;
        }
        public void SetPreco(double preco) {
            _preco = preco;
        }
        public int GetQuantidade() {
            return _quantidade;
        }
        public void SetQuantidade(int quantidade) {
            _quantidade = quantidade;
        }
        public override string ToString() {
            return "NOME: " + _nome
                + ",PREÇO: R$" + _preco.ToString("F3", CultureInfo.InvariantCulture)
                + ",QUANTIDADE: " + _quantidade + " em estoque";
        }
    }
}

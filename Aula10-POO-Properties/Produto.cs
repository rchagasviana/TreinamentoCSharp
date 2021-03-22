using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Aula10_POO_Properties {
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
        /*
         Usando properties para substirui o get e set. O nome utilizado
         na definição da propriedade é que será usado para acessar em outra
         classe.
         */
        public string Nome {
            get { return _nome; }
            set {
                _nome = value; // o nome "value" representa o parâmetro que é passado implicitamente
            }
        }
        public double Preco {
            get { return _preco; }
            set {
                if (value > 0) {
                    _preco = value;
                }
                else {
                    _preco = 0;
                }

            }
        }
        public int Quantidade {
            get { return _quantidade; }
            set { _quantidade = value; }
        }
        public override string ToString() {
            return "NOME: " + _nome
                + ",PREÇO: R$" + _preco.ToString("F3", CultureInfo.InvariantCulture)
                + ",QUANTIDADE: " + _quantidade + " em estoque";
        }
    }
}

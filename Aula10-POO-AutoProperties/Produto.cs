using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Aula10_POO_AutoProperties {
    class Produto {

        /*
         * Observação:
         Quando o atributo tem o modificador "private". Usa-se o _ na frente do
         nome dele e a primeira letra minúscula.
         Macete: digitar "props" e pressionar tab x 2 para autocompletar
         */
        //Implementando AutoPropertites
        public string Nome { get; set; }
        //Implementando AutoPropertites
        public int Quantidade { get; set; }
        private double _preco;

        public Produto() {
            Quantidade = 0;
        }
        public Produto(string nome, double preco) : this() {
            Nome = nome;
            _preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            Quantidade = quantidade;
        }
        /*
         Usando properties para substitui o get e set. O nome utilizado
         na definição da propriedade é que será usado para acessar em outra
         classe.
         */
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

        public override string ToString() {
            return "NOME: " + Nome
                + ",PREÇO: R$" + _preco.ToString("F3", CultureInfo.InvariantCulture)
                + ",QUANTIDADE: " + Quantidade + " em estoque";
        }
    }
}

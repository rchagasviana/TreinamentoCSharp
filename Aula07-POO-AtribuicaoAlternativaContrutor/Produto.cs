using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aula07_POO_AtribuicaoAlternativaContrutor {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        
        public override string ToString() {
            return "NOME: " + Nome
                + ",PREÇO: R$" + Preco.ToString("F3", CultureInfo.InvariantCulture)
                + ",QUANTIDADE: " + Quantidade + " em estoque";
        }
    }





}

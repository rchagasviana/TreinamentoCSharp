using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aula36_POO_ComposicaoEnum.Entidades {
    class ItemPedido {

        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public ItemPedido() {
        }

        //Composição - Associar Item Pedido ao Pedido
        public Produto Produto { get; set; }

                

        public ItemPedido(int quantidade, double preco, Produto produto) {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal() {
            return Quantidade * Preco;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DADOS DO PEDIDO:");
            sb.AppendLine("Produdo: " + Produto.Nome);
            sb.AppendLine("Quantidade: " + Quantidade);
            sb.AppendLine("Preço: " + Preco.ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("Subtotal: " + SubTotal().ToString());

            return sb.ToString();
        }

    }
}

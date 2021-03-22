using System;
using System.Collections.Generic;
using System.Text;
using Aula36_POO_ComposicaoEnum.Entidades.Enums;
using System.Globalization;

namespace Aula36_POO_ComposicaoEnum.Entidades {
    class Pedido {

        public DateTime DataPedido { get; set; }
        public SituacaoPedido StatusPedido { get; set; }

        //Composição - Associar Pedido ao Cliente
        public Cliente Cliente { get; set; }

        //Composição - Associar Peido ao Item pedido
        public List<ItemPedido> ListaItemPedido { get; set; } = new List<ItemPedido>();

        public Pedido() {
        }

        public Pedido(DateTime dataPedido, SituacaoPedido statusPedido, Cliente cliente) {
            DataPedido = dataPedido;
            StatusPedido = statusPedido;
            Cliente = cliente;
        }


        //Adicionando pedidos
        public void AdicionarItemPedido(ItemPedido itemPedido) {
            ListaItemPedido.Add(itemPedido);
        }
        //Removendo ítens pedidos
        public void RemoverItemPedido(ItemPedido itemPedido) {
            ListaItemPedido.Remove(itemPedido);
        }

        //Calculando o Total da compra
        public double Total() {
            double soma = 0;
            foreach (ItemPedido item in ListaItemPedido) {
                soma += item.SubTotal();
            }
            return soma;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DADOS DO PEDIDO:");
            sb.AppendLine("Data do Pedido: " + DataPedido);
            sb.AppendLine("Situação: " + StatusPedido);
            sb.Append(Cliente);
            foreach (ItemPedido itens in ListaItemPedido) {
                sb.AppendLine(itens.ToString());
            }

            sb.AppendLine("TOTAL: R$" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }







    }
}

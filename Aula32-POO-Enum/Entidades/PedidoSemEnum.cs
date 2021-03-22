using System;
using System.Collections.Generic;
using System.Text;

namespace Aula32_POO_Enum.Entidades {
    class PedidoSemEnum {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }

        /*
         PagamentoPendente = 0,
         Processando = 1,
         Enviado = 2,
         Entregue = 3
         */
        public int SituacaoPedido { get; set; }


        public override string ToString() {
            return Id + ", "
                + DataPedido + ","
                + SituacaoPedido;
        }

    }
}

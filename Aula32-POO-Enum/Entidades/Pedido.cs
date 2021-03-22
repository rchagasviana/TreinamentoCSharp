using System;
using System.Collections.Generic;
using System.Text;
using Aula32_POO_Enum.Entidades.Enums; //Importação para utilziação do enum criado

namespace Aula32_POO_Enum.Entidades {
    class Pedido {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public StatusPedido SituacaoPedido { get; set; } //usando Enum

        public override string ToString() {
            return Id + ", "
                + DataPedido + ","
                + SituacaoPedido;
        }
    }
}

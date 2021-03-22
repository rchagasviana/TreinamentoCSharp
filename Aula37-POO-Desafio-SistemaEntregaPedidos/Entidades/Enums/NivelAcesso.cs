using System;
using System.Collections.Generic;
using System.Text;

namespace Aula37_POO_Desafio_SistemaEntregaPedidos.Entidades.Enums {
    enum NivelAcesso:int {

        /*-Cadastra outros usuários
         *-Consulta pedidos
         *-Cancela pedidos
         *-Muda status do pedido
         *-Modifica preço dos produtos
        */
        Administrador = 0,
        //Consulta pedido dos clientes
        Consultor = 1
    }
}

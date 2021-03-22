using System;
using System.Collections.Generic;
using System.Text;

namespace Aula32_POO_Enum.Entidades.Enums {
    enum StatusPedido : int { //Nomeclatura ':' usada em herança em C#
        PagamentoPendente = 0,
        Processando = 1,
        Enviado = 2,
        Entregue = 3
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Aula36_POO_ComposicaoEnum.Entidades.Enums {
    enum SituacaoPedido : int {
        AguardandoPagamento = 0,
        Processando = 1,
        Enviado = 2,
        Entregue = 3
    }
}

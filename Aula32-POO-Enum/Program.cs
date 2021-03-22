using System;
using Aula32_POO_Enum.Entidades; // Importação para classe pedido
using Aula32_POO_Enum.Entidades.Enums;

namespace Aula32_POO_Enum {
    class Program {
        static void Main(string[] args) {
            Pedido p1 = new Pedido();
            p1.Id = 1;
            p1.DataPedido = DateTime.Now;
            p1.SituacaoPedido = StatusPedido.PagamentoPendente; //Acessando Enum e escolhendo valor
            Console.WriteLine(p1);

            //Convertendo de Enum para String
            Console.WriteLine("Enum-String: ");
            Console.WriteLine(StatusPedido.PagamentoPendente.ToString());
            //Convertendo de String para Enum
            Console.WriteLine("String-Enum: ");
            StatusPedido st01 = Enum.Parse<StatusPedido>("Entregue");
            Console.WriteLine(st01);

            //Convertendo para inteiro
            int pendente = (int ) StatusPedido.PagamentoPendente;
            Console.WriteLine(pendente);
        
        }
    }
}

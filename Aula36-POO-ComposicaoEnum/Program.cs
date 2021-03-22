using System;
using Aula36_POO_ComposicaoEnum.Entidades;
using Aula36_POO_ComposicaoEnum.Entidades.Enums;
using System.Globalization;

namespace Aula36_POO_ComposicaoEnum {
    class Program {
        static void Main(string[] args) {
            //Dados do Cliente
            Console.WriteLine("DADOS DO CLIENTE");
            Console.Write("Nome: ");
            string nomeCliente = Console.ReadLine();
            Console.Write("E-mail: ");
            string emailCliente = Console.ReadLine();
            Console.Write("Data de Nascimentos: ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("DADOS DO PEDIDO");
            Console.Write("Situação: ");
            SituacaoPedido status = Enum.Parse<SituacaoPedido>(Console.ReadLine());

            Cliente cliente = new Cliente(nomeCliente, emailCliente, dataNascimento);
            Pedido pedido = new Pedido(DateTime.Now, status, cliente);

            //Escolhendo a quantidade de Item que deseja comprar
            Console.WriteLine("Quantos item você deseja comprar?");
            int numeroItens = int.Parse(Console.ReadLine());
            for (int i = 0; i < numeroItens; i++) {
                Console.WriteLine($"Dados do item {i + 1} da lista ");
                Console.Write("Nome do Produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço do Produto: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Produto produto = new Produto(nomeProduto, precoProduto);
                Console.Write("Quantidade de Produto: ");
                int quantidadeProduto = int.Parse(Console.ReadLine());
                ItemPedido itens = new ItemPedido(quantidadeProduto, precoProduto, produto);

                pedido.AdicionarItemPedido(itens);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("IMPRESSÃO");
            Console.WriteLine(pedido);


        }
    }
}

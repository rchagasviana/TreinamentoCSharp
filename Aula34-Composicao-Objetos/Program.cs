using System;
using Aula34_Composicao_Objetos.Enums;
using System.Globalization;
using Aula34_Composicao_Objetos.Entidades;

namespace Aula34_Composicao_Objetos {
    class Program {
        static void Main(string[] args) {
            //Dados do Departamento de trabalho
            Console.Write("DEPARTAMENTO: ");
            string nomeDepartamento = Console.ReadLine();
            //Dados do Trabalhador
            Console.WriteLine("DADOS DO TRABALHADOR");
            Console.Write("Nome: ");
            string nomeTrabalhador = Console.ReadLine();
            //Converter string para o tipo de Enum criado
            Console.Write("Nível: ");
            NivelTrabalhador nivelTrabalhador = Enum.Parse<NivelTrabalhador>(Console.ReadLine());
            Console.Write("Salário-base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instanciação de objetos para preenchimento dos dados
            Departamento departamento = new Departamento(nomeDepartamento);
            Trabalhador trabalhador = new Trabalhador(nomeTrabalhador, nivelTrabalhador,
                salarioBase, departamento);

            //Adicionando contratos
            Console.Write("Quantos contratos deseja cadastrar para o trabalhador? ");
            int numeroContratos = int.Parse(Console.ReadLine());
            Console.WriteLine("DADOS DO CONTRATO");
            for (int i = 0; i < numeroContratos; i++) {
                Console.WriteLine();
                Console.Write($"Contrato número #{i + 1}: ");
                Console.Write("Data(DD/MM/YYYY): ");
                DateTime dataContrato = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor cobrado  por Hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração em horas do contrato: ");
                int duracaoContrato = int.Parse(Console.ReadLine());
                HoraContratada contrato = new HoraContratada(dataContrato, valorPorHora, duracaoContrato);
                //Adicionando o contrato aos contratos do Trabalhador em questão
                trabalhador.AdicionarContrato(contrato);

            }

            Console.WriteLine();
            Console.WriteLine("CÁLCULO DE GANHO DO TRABALHADOR EM UM DADO MÊS E ANO");
            Console.Write("Data(MM/YYYY): ");
            string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0, 2));//recorta da posição 0 dois caracteres. No caso a posição 0 e 1 (mês)
            int ano = int.Parse(mesAno.Substring(3)); //corta da posição 3 em diante (ano)
            Console.WriteLine();
            Console.WriteLine("Resultado: ");
            Console.WriteLine("Nome: " + trabalhador.Nome);
            Console.WriteLine("Departamento: " + trabalhador.Departamento.Nome);
            Console.WriteLine("Ganho " + "no mês e ano " + mesAno
                + ": "
                + "R$ " + trabalhador.GanhoAnoMes(mes, ano).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

using Aula34_Composicao_Objetos.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula34_Composicao_Objetos.Entidades {
    class Trabalhador {
        public string Nome { get; set; }
        public NivelTrabalhador Nivel { get; set; }
        public double SalarioBase { get; set; }
        //Composição
        /*
         No momento da instanciação do objeto Trabalhador haverá, também,
        a instanciação de um objeto do tipo Departamento associado a ele
         */
        //Associação para a classe departamento
        public Departamento Departamento { get; set; }
        //Associação para a classe HoraContratada
        public List<HoraContratada> ListaDeContratos { get; set; } = new List<HoraContratada>();
        public Trabalhador() { }

        /*
         Obs: A associação para muitos (contratos) não deve ser inserida
              no construtor, uma vez que não faz sentido associar de imediato 
              um trabalhador aos contratos. Essa operação será executada
              por um método que adicionára contratos ao trabalhador.
              Diferentemente do que ocorre com associação para um, ou seja, 
              todas as vezes que um trabalhador for inserido, será associado
              a um departamento.  
         */
        public Trabalhador(string nome, NivelTrabalhador nivel, double salarioBase, Departamento departamento) {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }
        //Adicionar contratatos à lista de contratos
        public void AdicionarContrato(HoraContratada contratos) {
            ListaDeContratos.Add(contratos);
        }
        //Remover contratos à lista
        public void RemoverContrato(HoraContratada contratos) {
            ListaDeContratos.Remove(contratos);
        }

        public double GanhoAnoMes(int mes, int ano) {

            double soma = SalarioBase;
            /*
             * Percorrer a lista de contratos para buscar o ano
             * e mês informado e efetuar a soma
            */
            foreach (HoraContratada contrato in ListaDeContratos) {
                if (contrato.DataContrato.Year == ano && 
                    contrato.DataContrato.Month == mes) {
                    soma += contrato.ValorTotalContrato();
                }
            }
            return soma;
        }
    }
}

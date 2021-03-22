using System;
using System.Collections.Generic;
using System.Text;

namespace Aula34_Composicao_Objetos.Entidades {
    class HoraContratada {
        public DateTime DataContrato { get; set; }
        public double ValorPorHora { get; set; }
        public int DuracaoHorasContrato { get; set; }

        public HoraContratada() { }
        public HoraContratada(DateTime dataContrato, double valorPorHora, int duracaoHorasContrato) {
            DataContrato = dataContrato;
            ValorPorHora = valorPorHora;
            DuracaoHorasContrato = duracaoHorasContrato;
        }
        public double ValorTotalContrato() {
            return ValorPorHora * DuracaoHorasContrato;
        }

    }
}

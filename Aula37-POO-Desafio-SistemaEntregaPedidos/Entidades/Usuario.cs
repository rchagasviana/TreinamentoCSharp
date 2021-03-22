using Aula37_POO_Desafio_SistemaEntregaPedidos.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula37_POO_Desafio_SistemaEntregaPedidos.Entidades {
    class Usuario {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Sexo Sexo { get; set; }
        public NivelAcesso NivelAcesso { get; set; }
        public EstadoNoSistema EstadoNoSistema { get; set; }

        public Usuario() {
        }

        public Usuario(string nome, string email, Sexo sexo,
            NivelAcesso nivelAcesso, EstadoNoSistema estadoNoSistema) {
            Nome = nome;
            Email = email;
            Sexo = sexo;
            NivelAcesso = nivelAcesso;
            EstadoNoSistema = estadoNoSistema;
        }

        //Método para Ativar e Inativar um usuário no sistema
        public void AtivarDesativar(EstadoNoSistema estadoNoSistema) {
            EstadoNoSistema = estadoNoSistema;
        }



    }
}

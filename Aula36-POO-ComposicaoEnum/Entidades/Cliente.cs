using System;
using System.Collections.Generic;
using System.Text;

namespace Aula36_POO_ComposicaoEnum.Entidades {
    class Cliente {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public Cliente() {
        }

        public Cliente(string nome, string email, DateTime dataNascimento) {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DADOS DO CLIENTE");
            sb.AppendLine("Nome: " + Nome);
            sb.AppendLine("E-mail: " + Email);
            return sb.ToString();
        }
    }
}

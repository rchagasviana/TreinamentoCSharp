using System;
using System.Collections.Generic;
using System.Text;

namespace Aula35_POO_Composicao_Objetos_StringBuilder.Entidades {
    class Postagem {
        public DateTime DataPostagem { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        //Composição para associar Postagem aos comentários
        public List<Comentario> ListaDeComentarios { get; set; } = new List<Comentario>();

        public Postagem() {
        }

        public Postagem(DateTime dataPostagem, string titulo, string conteudo, int likes) {
            DataPostagem = dataPostagem;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }

        public void AdicionarComentario(Comentario comentario) {
            ListaDeComentarios.Add(comentario);
        }

        public void RemoverComentario(Comentario comentario) {
            ListaDeComentarios.Remove(comentario);
        }

        //Usando a Classe StringBuilder para montar um ToString formatado e flexível
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(Titulo);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(DataPostagem.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Conteudo);
            sb.AppendLine("Comentários: ");
            foreach (Comentario c in ListaDeComentarios) {
                sb.AppendLine(c.Texto);
            }
            return sb.ToString();
        }
    }
}

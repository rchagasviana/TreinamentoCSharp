using Aula35_POO_Composicao_Objetos_StringBuilder.Entidades;
using System;

namespace Aula35_POO_Composicao_Objetos_StringBuilder {
    class Program {
        static void Main(string[] args) {
            //Maneira 01 de inserir valores
            Postagem p1 = new Postagem(
                DateTime.Parse("17/08/2020 14:48:00"),
                "Aula 35-CSharp",
                "Funcionamento do StringBuilder",
                10
                );
            Comentario c1 = new Comentario("Esta aula tá show!");
            Comentario c2 = new Comentario("Que aula massa!");
            //Comentários adicionados à postagem
            p1.AdicionarComentario(c1);
            p1.AdicionarComentario(c2);

            //Criando um novo Pos e adicionando os valores de maneira diferente
            Postagem p2 = new Postagem();
            p2.DataPostagem = DateTime.Parse("19/03/2021 16:06:00");
            p2.Titulo = "Aula36-String Builder";
            p2.Conteudo = "Resolução do excercício de Stringbuilder";
            p2.Likes = 20;

            Comentario c3 = new Comentario();
            Comentario c4 = new Comentario();
            c3.Texto = "A resolução tá bem didática!";
            c4.Texto = "A resolução desse excercício ficou show!";

            p2.AdicionarComentario(c3);
            p2.AdicionarComentario(c4);

            //Imprimindo os posts
            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}

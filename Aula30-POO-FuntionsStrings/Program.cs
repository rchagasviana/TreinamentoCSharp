using System;

namespace Aula30_POO_FuntionsStrings {
    /*
     Formatar:
        -ToLower(), ToUpper(), Trim()
     Buscar:
        -IndexOf, LastIndexOf
     Recortar:
        -Substring(inicio), Substring(inicio,tamanho)
     Substituir:
        -Replace(char,char), Replace(string,string)
     Outras:
        -String.IsNullOrEmpty(str), String.IsNullOrWhiteSpace(str)
        -str.Split('')
     Coñversão para números:
        -int x = int.Parse(str)
        -int x = Convert.ToInt32(str)
    Conversão de números:
        -str=x.ToString()
        -str=x.ToString("C")
        -str=x.ToString("C3")
        -str=x.ToString("F2")
     */
    class Program {
        static void Main(string[] args) {
            //Converter string para maíuscula
            string frase = "DEUS é bom! ";
            string frase02 = "abcDFCGhiJka   ";
            Console.WriteLine("Frase original: " + frase + "-");
            Console.WriteLine("Frase convertida: " + frase.ToUpper() + "-");
            //Converter para minúsculo
            Console.WriteLine();
            Console.WriteLine("Frase original: " + frase);
            Console.WriteLine("Frase convertida: " + frase.ToLower() + "-");
            //Remover os espaços em branco antes e depois da string
            Console.WriteLine("Frase original: -" + frase02);
            Console.WriteLine("Frase sem espaço: -" + frase02.Trim());
            //Buscar um valor dentro da string
            Console.WriteLine("Buscando pelo índice onde 'a' aparece primeiro: " + frase02.IndexOf("a"));//começa na posição 5
            Console.WriteLine("Buscando pelo índice ondeo 'a' aparece por último : " + frase02.LastIndexOf("a"));
            //Cortar a string a partir de certo ponto
            Console.WriteLine("Cortando string a partir da posição 3: " + frase02.Substring(3));
            Console.WriteLine("Cortando string, a partir da posição 3, 5 caracteres: " + frase02.Substring(3, 5));
            //Substiuir um caracter de uma string
            Console.WriteLine("Substituir um caracter de uma estring por outro: " + frase02.Replace('a', 'x'));
            //Testar se a string é vazia
            string vazia01 = "conteúdo";
            Console.WriteLine(String.IsNullOrEmpty(vazia01));
            //Testar se a string possui espaços em branco em vez de ter um texto.
            string espacoEmBranco = "   ";
            Console.WriteLine(String.IsNullOrWhiteSpace(espacoEmBranco));


        }
    }
}

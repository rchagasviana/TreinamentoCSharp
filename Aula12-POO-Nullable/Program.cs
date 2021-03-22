using System;

namespace Aula12_POO_Nullable {

    /*
     -É um recurso de C# para que dados de tipo valor(structs) posssam receber o valor null
     -Uso comum:
        -Campos de banco de dados que podem valor nulo (data de nascimento, algum valor numérico, etc)
        -Dados e parâmetros opcionais
     */
    class Program {
        static void Main(string[] args) {
            //double x = null; -> operação não aceita em C#, uma vez que valores números não podem iniciar como null
            //Solução
            Nullable<double> a = null; //uma das maneiras de usar o Nillable
            double? b = 10;
            double? c = null; //maneira menos verbosa 
            //Função GetValueOrDefault()-captura o valor atribuído, caso não tenha imprime 0
            Console.WriteLine(b.GetValueOrDefault());
            Console.WriteLine(c.GetValueOrDefault());
            //Função HasValue- retorna True/False (Possui valor/Não possui valor)
            Console.WriteLine(b.HasValue);
            Console.WriteLine(c.HasValue);
            //Função Value- retorna o valor diretamente, no entando gera uma exceção quando não há valor
            if (b.HasValue) {
                Console.WriteLine(b.Value);
            }
            else {
                Console.WriteLine("Não possui valor atribuído!");
            }

            if (c.HasValue) {
                Console.WriteLine(c.Value);
            }
            else {
                Console.WriteLine("Não possui valor atribuído!");
            }


        }
    }
}

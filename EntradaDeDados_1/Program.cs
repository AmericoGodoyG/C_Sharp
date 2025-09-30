using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Entrada de dados em C# - inputs 

              Comando: Console.ReadLine();
              - Lê da entreada padrão até a quebra de linha
              - Retorna os dados lidos em forma de string
            */

            // Retona o valor lido com o tipo string
            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();

            //Console.WriteLine("Você digitou:");
            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            Console.WriteLine("================Split==============");

            /*
               Split (dividir)
                 Retorna uma matriz de cadeia de caracteres
                 que contém as subcadeias de caracteres nesta 
                 instância delimitadas por elementos de uma 
                 cadeia de caracteres especificada ou matriz de caracteres Unicode.
            */
            string s = Console.ReadLine();
            string[] vet = s.Split(" ");


            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);


        }
    }
}
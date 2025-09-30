using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Metadata;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Simples
            int x = 10;
            
            Console.WriteLine("Bom dia!");
            if (x < 5)
            {
                Console.WriteLine("Bom tarde!");
            }
            Console.WriteLine("Bom noite!");



            // Composta
            Console.Write("Entre com um número inteiro: ");
            int? numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} é par!");

            }
            else
            {
                Console.WriteLine($"{numero} é impar");
            }


            // Encadeada
            Console.Write("Qual é a hora atual: ");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
                Console.WriteLine("Bom dia!");
            else if (hora < 18)
                Console.WriteLine("Boa tarde!");
            else
                Console.WriteLine("Boa noite!");


            /*
                OBS: Se o bloco de comandos possuir apenas
                um comando, as chaves são opcionais.
            */
        }
    }
}

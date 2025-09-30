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
            /*
                Escopo e inicialização
            
                - Escopo de uma variável: É a região do programa onde
                  a variável é válida, ou seja, onde ela pode ser referenciada.
                
                - Uma variável não pode ser usada se não ela for inciada
             */

            double preco = double.Parse(Console.ReadLine());

            double desconto = 0.0;

            if (preco > 100)
            {
                desconto = preco * 0.1;
            }
            Console.WriteLine(desconto);

        }
    }
}


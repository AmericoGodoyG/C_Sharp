using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Metadata;

namespace Course
{
    class Program
    {
        static void Main(string[] args) // Entry point
        {
            /*  Funções  

                Representam um processamento que possui um significado
                - Math.Srqt(double)
                - Console.WriteLine()
                
                Principais vantagens: modularização, delegação e reaproveitamento
                
                Dados de entrada e saída
                - Funções podem receber dados de entrada (parâmetros ou argumententos)
                - Funções podem ou não retornar uma saída
               
               Em orientação a objetos, funções em classes recebem o nome de "métodos" */

            Console.WriteLine("Digite três números: ");
            int n1 = int.Parse(Console.ReadLine()); 
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());


            double resultado = Maior(n1, n2, n3);

            Console.WriteLine($"Maior = {resultado}");
        }

        // Função
        static int Maior(int a, int b, int c)
        {
            int m;

            if (a > b && a > c)
                m = a;
            else if (b > c)
                m = b;
            else
                m = c;

            return m;
        }
    }
}


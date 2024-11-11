using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exer02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Soma dos elementos de um array
            
            
            int[] numeros = new int[10];
            
            Console.WriteLine("Insira 10 valores em um array");
            int soma = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i+1}º valor: ");
                numeros[i] = int.Parse(Console.ReadLine());
                soma += numeros[i];
            }

            Console.WriteLine("Soma dos elementos = " + soma);

        }
    }
}

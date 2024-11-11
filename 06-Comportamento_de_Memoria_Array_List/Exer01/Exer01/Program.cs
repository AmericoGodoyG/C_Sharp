using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando um array com 5 posicoes
            int[] numeros = new int[5];


            // Atribuindo valores ao array
            Console.WriteLine("Insira 5 valores inteiros: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Insira o {i+1}º valor: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            // Exibindo os valoes do array numeros;
            for (int i =0; i < 5; i++)
            {
                Console.WriteLine($"{i+1}º valor = " + numeros[i]);
            }
        }
    }
}

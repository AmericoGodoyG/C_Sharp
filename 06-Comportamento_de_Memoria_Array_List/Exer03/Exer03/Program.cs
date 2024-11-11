using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Exer03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Maior e menor valor em um array

            int[] numero = new int[10];

            Console.WriteLine("Insira 10 valores: ");
            for (int i = 1; i < numero.Length; i++)
            {
                numero[i] = int.Parse(Console.ReadLine());
            }

            int maior = numero[0];
            for (int i = 1; i < numero.Length; i++)
            {
                if (numero[i] > maior)
                {
                    maior = numero[i];
                }
                
            }
            Console.WriteLine("Maior: " + maior);
        }
    }
}

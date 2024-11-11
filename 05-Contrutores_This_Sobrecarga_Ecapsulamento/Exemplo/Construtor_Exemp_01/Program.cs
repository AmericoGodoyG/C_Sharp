using System;
using System.Globalization;
using System.Runtime.InteropServices;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Produto p = new Produto("TV", 500.0, 10);

            // Sintaxe de atribuição permitida atraves do uso de propertie
            p.Nome = "T";
            
            Console.WriteLine(p.Nome);
            Console.WriteLine("R$ " + p.Preco.ToString("F2"));
        }
    }
}

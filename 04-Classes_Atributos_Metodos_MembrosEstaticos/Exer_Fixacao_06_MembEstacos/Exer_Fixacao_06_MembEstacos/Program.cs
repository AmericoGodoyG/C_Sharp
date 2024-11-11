using System;
using System.Globalization;

namespace Exer_Fixacao_06_MembEstacos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você irá comprar? ");
            double quantidadeDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.ValorEmReais(cotacaoDolar, quantidadeDolares);

            Console.WriteLine("O valor a ser pago em R$ " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

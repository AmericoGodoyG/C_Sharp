using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício de fixação 2

            Console.Write("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.Write("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.Write("Entre com o preço dos produto: ");
            double produtos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com seu último nome, idade e altura: ");
            string dados = Console.ReadLine();

            // Split
            string[] vetDados = dados.Split(" ");
            string ultimoNome = vetDados[0];
            int idade = int.Parse(vetDados[1]);
            double altura = double.Parse(vetDados[2], CultureInfo.InvariantCulture);

            Console.WriteLine("=== SAÌDA ===");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(produtos.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

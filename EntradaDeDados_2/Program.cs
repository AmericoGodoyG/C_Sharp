using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados em C# pt 2
            
            // inputs com conversão de tipos 
            //int n1 = int.Parse(Console.ReadLine());
            //char cr = char.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine($"Você digitou: {n1}, {cr}, {n2.ToString("F2", CultureInfo.InvariantCulture)}");


            Console.WriteLine("==========================================");

            Console.Write("Insira os dados da pessoa, nome, sexo, idade e altura: ");
            string dadosPessoa = Console.ReadLine();
            string[] vetDados = dadosPessoa.Split(" ");

            string nome = vetDados[0];
            char sexo = char.Parse(vetDados[1]);
            int idade = int.Parse(vetDados[2]);
            double altura = double.Parse(vetDados[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
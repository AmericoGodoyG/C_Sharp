using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Saída de dados 
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite");

            Console.WriteLine("-----------------------------");

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            // Exibe o valor com o ponto como separador
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("------------------------------------------");

            // Placeholders, concatenação e interpolação
            int idadeDois = 35;
            double saldoDois = 10.44490;
            string nomeDois = "Mario";

            // Interpolação
            Console.WriteLine($"{nomeDois} tem {idadeDois} anos, seu saldo é de R${saldoDois.ToString("F3", CultureInfo.InvariantCulture)}");

            // Placeholder
            Console.WriteLine("{0} tem {1} anos, seu saldo é de R${2:F3}", nomeDois, idadeDois, saldoDois);

            // Concatenação
            Console.WriteLine(nomeDois + " tem " + idadeDois + " anos, seu saldo é de R$" + saldoDois.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
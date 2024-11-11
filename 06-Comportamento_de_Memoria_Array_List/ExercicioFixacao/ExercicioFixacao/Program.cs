using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante[] quartos = new Estudante[10];

            Console.Write("Quantos quartos serão alugados?: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel #{i+1} ");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int numeroDoQuarto = int.Parse(Console.ReadLine());

                quartos[numeroDoQuarto] = new Estudante { Nome = nome, Email = email };

                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(quartos[i]);
                }
            }

        }
    }
}

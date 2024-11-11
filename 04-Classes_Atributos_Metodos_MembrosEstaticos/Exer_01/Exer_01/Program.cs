using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoaUm = new Pessoa();
            Pessoa pessoaDois = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            
            Console.Write("Nome: ");
            pessoaUm.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoaUm.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            
            Console.Write("Nome: ");
            pessoaDois.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoaDois.Idade = int.Parse(Console.ReadLine());

            if (pessoaUm.Idade > pessoaDois.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {pessoaUm.Nome}");
            } else
            {
                Console.WriteLine($"Pessoa mais velha: {pessoaDois.Nome}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exer_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoaUm = new Pessoa();

            Console.WriteLine("Dados do primeiro funcoinario: ");
            Console.Write("Nome: ");
            pessoaUm.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            pessoaUm.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario: ");

            Pessoa pessoaDois = new Pessoa();

            Console.Write("Nome: ");
            pessoaDois.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            pessoaDois.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (pessoaUm.Salario + pessoaDois.Salario) / 2;
             
            Console.WriteLine("Salário médio: " + salarioMedio.ToString("F2"),CultureInfo.InvariantCulture);
        }
    }
}

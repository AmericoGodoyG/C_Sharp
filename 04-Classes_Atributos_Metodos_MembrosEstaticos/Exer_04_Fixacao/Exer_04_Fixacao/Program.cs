using System;
using System.Globalization;

namespace Exer_04_Fixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();

            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            f1.SalarioBruto = double .Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + f1);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            f1.AumentarSalario(porcentAumento);

            Console.WriteLine();
            Console.WriteLine("dados atualizados: " + f1);
        }
    }
}

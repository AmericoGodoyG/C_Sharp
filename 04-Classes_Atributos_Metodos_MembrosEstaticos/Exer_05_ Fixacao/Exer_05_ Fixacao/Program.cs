using System;
using System.Globalization;

namespace Exer_05__Fixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.NotaUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaTres = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("RESTARAM " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture) + "PONTOS");
            }

        }
    }
}

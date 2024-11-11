using System;
using System.Globalization;


namespace Exer_Fixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria Conta;

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (S/N) ?: ");
            char verificDep = char.Parse(Console.ReadLine());


            if (verificDep == 'S' || verificDep == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Conta = new ContaBancaria(numeroConta, nomeTitular, deposito);
            }
            else
            {
                Conta = new ContaBancaria(numeroConta, nomeTitular);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(Conta);

            Console.WriteLine();

            Console.Write("Entre umm valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta.Deposito(quantia);

            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(Conta);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(Conta);

        }
    }
}

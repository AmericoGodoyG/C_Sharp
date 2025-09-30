using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Metadata;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Estruturas Condicional (if-else)

            // Exercicio 1)

            Console.Write("Insira um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 < 0)
                Console.WriteLine($"{n1} é NEGATIVO");
            else
                Console.WriteLine($"{n1} é NÃO NEGATIVO");


            // Exercício 2)

            Console.Write("Insira um número inteiro: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n2 % 2 == 0)
                Console.WriteLine($"{n2} é PAR");
            else
                Console.WriteLine($"{n2} é IMPAR");

            // Exercicio 3)
            Console.Write("Insira o valor de A e B: ");
            string[] valores = Console.ReadLine().Split(' ');

            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            if (a % b == 0 || b % a == 0)
                Console.WriteLine("São multiplos");
            else
                Console.WriteLine("Não multiplos");
            

            // Exercicio 5)
            Console.Write("Inisira a hora inicia e final de um jogo: ");
            string[] horasPartida = Console.ReadLine().Split(' ');

            int horaInicio = int.Parse(horasPartida[0]); // 1:00
            int horaFinal = int.Parse(horasPartida[1]);  // 00:00

            int duracao;

            if (horaInicio < horaFinal)
                duracao = horaFinal - horaInicio;
            else
                duracao = 24 - horaInicio + horaFinal;

            Console.WriteLine("O JOGO DUROU " + duracao + "HORA(S)");
            

            // Exercicio 5)

            Console.Write("Insira o código do item e a quantidade: ");
            string[] produto = Console.ReadLine().Split(' ');

            int codigo = int.Parse(produto[0]);
            int quantidade = int.Parse(produto[1]);

            double preco = 0.0;
            
            switch (codigo)
            {
                case 1:
                    preco = 4.00;
                    break;

                case 2:
                    preco = 4.50;
                    break;

                case 3:
                    preco = 5.00;
                    break;

                case 4:
                    preco = 2.00;
                    break;

                case 5:
                    preco = 1.50;
                    break;

                default:
                    Console.WriteLine("Código indisponível. Insiraum código válido!");
                    break;
            }

            double total = quantidade * preco;
            Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");



            // Exercicio 6)

            Console.Write("Insira um valor de 0 a 100: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor < 0.0 || valor > 100)
                Console.WriteLine("Fora de intervalo");
            else if (valor <= 25.00)
                Console.WriteLine("Intervadlo [0, 25]");
            else if (valor <= 50.00)
                Console.WriteLine("Intervalo (25, 50]");
            else if (valor <= 75)
                Console.WriteLine("Intervalo (50, 75]");
            else
                Console.WriteLine("Intervalo de (75, 100]");
            


            // Exercício 7)

            Console.WriteLine("Insira os valores de X e Y com uma casa decimal: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
                Console.WriteLine("Origem");

            else if (x == 0)
                Console.WriteLine("Eixo Y");

            else if (y == 0)
                Console.WriteLine("Eixo X");

            else if (x > 0.0 && y > 0.0)
                Console.WriteLine("Q1");

            else if (x < 0 && y > 0.0)
                Console.WriteLine("Q2");

            else if (x < 0.0 && y < 0.0)
                Console.WriteLine("Q3");

            else
                Console.WriteLine("Q4"); */


            // Exercicio 8)
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }


            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}

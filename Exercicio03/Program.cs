using System;
using System.Globalization;
using System.Reflection.Metadata;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
         {
            /*
            // Exercício 01
            int a, b;

            Console.WriteLine("Insira dois valores para a soma abaixo");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            int soma = a + b;

            Console.WriteLine($" {a} + {b} = {soma}");

            //Exercício 02
            Console.WriteLine("Área da circunferência");

            Console.Write("Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Formula circunferência
            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine($" A = {area.ToString("F4", CultureInfo.InvariantCulture)}");

            //Exercício 03
            Console.WriteLine("Diferença produto valor");

            Console.Write("Insira valores para A, B, C e D: ");
            string valores = Console.ReadLine();

            string[] vetValores = valores.Split(" ");

            int a, b, c, d;

            a = int.Parse(vetValores[0]);
            b = int.Parse(vetValores[1]);
            c = int.Parse(vetValores[2]);
            d = int.Parse(vetValores[3]);

            // cálculo difrença valor
            int diferenca = a * b - c * d;

            Console.WriteLine($"DIFERENCA = {diferenca}"); 

            //Exercicio 04
            Console.WriteLine("Insira os dados do funcionario: Número do funcionario | Horas trabalhadas | Valor por hora |");
            string funInfo = Console.ReadLine();
            string[] vetInfoFun = funInfo.Split(" ");

            int numeroFun = int.Parse(vetInfoFun[0]);
            int horasTrabFun = int.Parse(vetInfoFun[1]);
            double valorHoraFun = double.Parse(vetInfoFun[2], CultureInfo.InvariantCulture);

            // Calculo slário
            double salarioFun = horasTrabFun * valorHoraFun;

            Console.WriteLine($"NUMBER: {numeroFun}\n" +
                $"SALARY = U$ {salarioFun.ToString("F2", CultureInfo.InvariantCulture)}");

            
            // Exercício 05
            Console.WriteLine("Insira os dados 1º peça: | Código da peça | Quantidade | Valor unitário");

            //Split da string 1ª peça
            string pecaUmInfo = Console.ReadLine();
            string[] vetPecaUm = pecaUmInfo.Split(" ");

            string codigoPecaUm = vetPecaUm[0];
            int qntPecaUm = int.Parse(vetPecaUm[1]);
            double valorPecaUm = double.Parse(vetPecaUm[2], CultureInfo.InvariantCulture);

            // Split da string 2ª peça
            Console.WriteLine("Insira os dados 2º peça: | Código da peça | Quantidade | Valor unitário");

            string pecaDoisInfo = Console.ReadLine();
            string[] vetPecaDois = pecaDoisInfo.Split(" ");

            string codigoPecaDois = vetPecaDois[0];
            int qntPecaDois = int.Parse(vetPecaDois[1]);
            double valorPecaDois = double.Parse(vetPecaDois[2], CultureInfo.InvariantCulture);

            // Custo total
            double custoTotal = qntPecaUm * valorPecaUm + qntPecaDois * valorPecaDois;

            // Saída
            Console.WriteLine($"VALOR A PAGAR: R$ {custoTotal.ToString("F2", CultureInfo.InvariantCulture)}"); 


            // Exercicio  06
            Console.WriteLine("Insira o valor de A B e C: ");
            string valores = Console.ReadLine();

            string[] vetValores = valores.Split(" ");

            double a = double.Parse(vetValores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vetValores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vetValores[2], CultureInfo.InvariantCulture);

            // TRIÂNGULO
            double areaTriangulo = (a * c) / 2;

            // CIRCUNFERÊNCIA
            double pi = 3.14159;
            double areaCircunferencia = pi * Math.Pow(c, 2);

            // TRAPÉZIO
            double areaTrapezio = (a + b) * c / 2;

            // Quadrado
            double areaQuadrado = Math.Pow(b, 2);

            // RETÂNGULO
            double areaRetangulo = a * b;

            Console.WriteLine($"TRANGULO: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                $"CIRCULO: {areaCircunferencia.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                $"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                $"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                $"RETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            //Fim

            */
        }
    }
}
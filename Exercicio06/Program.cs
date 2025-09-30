using System.ComponentModel;
using System.Globalization;
using System.Threading.Channels;
using System.Transactions;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /* // Exercicio 01)
            int X = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < X; i++)
            {   
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            } 


            // Exercicio 02)
            int N = int.Parse(Console.ReadLine());

            int dentro = 0;
            int fora = 0;
            int entrada = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.Write($"Insira o {i}º valor: ");
                entrada = int.Parse(Console.ReadLine());

                if (entrada >= 10 && entrada <= 20)
                {
                    dentro++;
                } 
                else
                {
                    fora++;
                }
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " in"); 

            // Exercicio 03)

            int X = int.Parse(Console.ReadLine());

            for (int i = 0; i < X; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture)); 

            } 

            // Exercicio 04)
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double numerador = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double denominador = double.Parse(valores[1], CultureInfo.InvariantCulture);

                double resultado = 0.0;

                if (denominador!= 0)
                {
                    resultado = numerador / denominador;
                    Console.WriteLine($"Resultado = {resultado.ToString("F2",CultureInfo.InvariantCulture)}");
                }
                else
                {
                    Console.WriteLine("Divisão imposível.");
                }
                

            } 

            // Exercicio 05)
            int N = int.Parse(Console.ReadLine());

            int fat = 1;

            for (int i = 1; i <= N; i++)
            {

                fat *= i;

            }
            Console.WriteLine(fat); 

            // Exercicio 06)
            int N = int.Parse(Console.ReadLine());
 
            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }
            } 

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                double quadrado = Math.Pow(i, 2);
                double cubo = Math.Pow(i, 3);
                Console.WriteLine($"{i} {quadrado} {cubo}");
            }
            */

        }
    }
}


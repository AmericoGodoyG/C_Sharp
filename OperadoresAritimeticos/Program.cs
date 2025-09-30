using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Operadores aritméticos
                
              Operador          Significado
                 +                Adição
                 -                Subtração
                 *                Multiplicação
                 /                Divisão
                 %                Resto da divisão (MOD)

            NOTAS:
                1) * / % tem PRECEDÊNCIA maior que + -

                2) Exemplos:
                   3 + 4 * 2 ------------> Resultado: 11
                  (3 + 4) * 2 -----------> Resultado: 14

                3) Pode-se usar parênteses à vontade

                4) Exemplo com % mod (resto da divisão)
                17 % 3 ---------> Resultado: 2
            
                17 |__3__
                (2)  5
            */

            int n1 = 3 + 4 * 2; 
            Console.WriteLine(n1); // 11

            int n2 = (3 + 4) * 2; // 14
            Console.WriteLine(n2);

            int n3 = 17 % 3;
            Console.WriteLine(n3); // 2

            double n4 = (double) 10 / 8;
            Console.WriteLine(n4);  // 1,25

            Console.WriteLine("===============================");

            // Coeficientes
            double a = 1.0, b = -3.0, c = -4.0;

            // Delta
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            Console.WriteLine($"Delta = {delta}");

            // Basckara
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"X1 = {x1}");
            Console.WriteLine($"X2 = {x2}");

        }
    }
}
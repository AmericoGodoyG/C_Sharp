using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                 Conversão implícita entre tipos
                 - É quando o conteúdo de um certo tipo pode ser naturalmente
                   atribuido a uma variável de outro tipo.

                 Casting
                 - É uma conversão explícta entre tipo COMPATÍVEIS
             */

            // Conversão implícita de tipos
            float x = 4.5f; // float 4 bytes
            double y = x;   // double 8 bytes
            Console.WriteLine(y);


            // Conversão explícita de tipos (CASTING)
            double a;
            float b;

            a = 5.1;
            b = (float)a; // convesão explícita (casting)
            Console.WriteLine(b); // 5.1

            double c = 5.1;
            int d;

            d = (int)a; // convesão explícita (casting)
            Console.WriteLine(d); // 5

            int e = 5;
            int f = 2;
            double resultado = (double) e / f; // 2.5
            Console.WriteLine(resultado);
            
          /*
            Obs: Ao realizar uma divisão entre dois inteiros
            e armazena-los em uma variavel double, é necessário
            realizar o casting, porque o compilador entende que 
            no momento de realizar a divisão com os tipos serão
            descartdas as casas decimais.
          */

        }
    }
}
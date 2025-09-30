using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operação cumulativa de variáveis");
            /*
                 Operador     Exemplo     Significado
                  =           a = 10;      a RECEBE   10
                 +=           a += 2;      a RECEBE a + 2  Concat. cumulativa de strings 
                 -=           a -= 2;      a RECEBE a - 2
                 *=           a *= 2;      a RECEBE a * 2
                 /=           a /= 2;      a RECEBE a / 2
                 %= (mod)     a %= 3;      a RECEBE a % 2
             */


            /*
             Operador      Exemplo      Significado
               ++        a++; ou ++a;    a = a + 1;  ++ Incrementa o valor de uma variável de um em um
               --        a--; ou --a;    a = a - 1;  -- Decrementa o valor de uma variável de um em um
             
               b = a++ Primeiro passa o valor da variavel para b, depois incrementa a
               b = ++a Primeiro incrementa o valor de a, depois passa o valor para b

             */

            int a = 10;
            int b = ++a;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
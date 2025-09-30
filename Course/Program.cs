using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Restrições para nomes de variáveis
                - Não pode começar com dígito: use uma letra ou _
                - Não pode usar acento ou til
                - Não pode ter espaço em branco
                - Sugestão: use nomes que tenha significado

                Convenções
                - camelCase: lastName (parâmetros de métodos, variáveis dentro de métodos)
                - PascalCase: LastName(namespaces, classe, properties e métodos)
                - Padrão _lastName(atributos "internos" da classe)

             */

            // bool: boleano
            bool completo = false;

            // char: caractere
            char genero = 'f';
            char letra = '\u0041';

            // string: cadeia de caractertes e imutável
            string nome = "Maria Green";

            byte n1 = 126; 
            int n2 = 1000;
            int n3 = 2147483647;

            long n4 = 2147483648L; // L indica a que é um número do tipo long
            float n5 = 4.5f;
            double n6 = 4.5;

            // object: Um tipo genérico (toda classe em C# é uma subclasse de object)
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            // Funções para valores mínimos e máximos
            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            sbyte n9 = sbyte.MinValue;
            decimal n10 = decimal.MaxValue;

            Console.WriteLine(completo);

            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(nome);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);

            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            
        }
    }
}
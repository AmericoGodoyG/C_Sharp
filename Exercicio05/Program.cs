using System.ComponentModel;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Exercicio 01)

            int senha = 2002;

            Console.Write("Insira a senha: ");
            int entrada = int.Parse(Console.ReadLine());

            while (entrada != senha) // Executa enquanto for verdade
            {
                Console.Write("Senha inválida. Insira novamente: ");
                entrada = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido!"); 

            // Exercício 02)

            Console.Write("Insira as cordenadas x e Y de um plano: ");
            string[] coordenadas = Console.ReadLine().Split(' ');

            int x = int.Parse(coordenadas[0]);
            int y = int.Parse(coordenadas[1]);

            while (x != null && y != null)
            {

                if (x > 0 && y > 0)
                    Console.WriteLine("Q1");
                else if (x > 0 && y < 0)
                    Console.WriteLine("Q2");
                else if (x < 0 && y < 0)
                    Console.WriteLine("Q3");
                else if (x > 0 && y < 0)
                    Console.WriteLine("Q5");
                else if (x == 0 && y == 0)
                    Console.WriteLine("Origem");
                else if (x == 0 && y > 0)
                    Console.WriteLine("Eixo Y");
                else
                    Console.WriteLine("Eixo X");

                Console.Write("Insira NOVAMENTE as cordenadas x e Y: ");
                coordenadas = Console.ReadLine().Split(' ');

                x = int.Parse(coordenadas[0]);
                y = int.Parse(coordenadas[1]);

            } 

            // Exercicio 03)
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool = alcool + 1;
                }
                else if (tipo == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (tipo == 3)
                {
                    diesel = diesel + 1;
                }
                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);         */
        }
    }
}    

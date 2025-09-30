using System.ComponentModel;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Estrutura repetitiva for

                inicio: executa somente na primeira vez
                condicao: V -> executa e volta. F -> pula fora
                incremento: executa toda vez depois de voltar
            
            for (inicio; condicao; incremento){
                comando 1
                comando 2
            }               
            
             Obs: Usada quando conhecemos a quantidade de repetições */

            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("Soma = " + soma);


        }
    }
}

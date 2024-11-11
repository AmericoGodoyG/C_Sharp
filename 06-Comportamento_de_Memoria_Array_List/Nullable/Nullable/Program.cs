using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipos structs não recebem o valor null sem utilizar o recurso que permita o uso de nulable
            double? x = null;
            Nullable<double> y = 10.0;

            /* 
                Métodos de nullable
                > GetValueOrDefault: Exibe o valor atribuido ou o valor padrão
                > HasValue: Diz se dentro da variavel exite um valor ou não (False ou True)
                > Value: Lança uma exceção caso a chamada parta de um objeto nulo
            */
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue); // False
            Console.WriteLine(y.HasValue); // True

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);

            }
            else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }

            // Operador de coalescência nula
            /*
                ?? -> caso a não seja nullo o valor de a vai para b
                porém, se o valor de a for nullo, 0.0 é atribuido a b
             */
            double? a = null;
            double? b = 10;

            double c = a ?? 5;
            double d = b ?? 5;

            Console.WriteLine(c);
            Console.WriteLine(d);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipos struct necessitam ser inicializados
            Point p;
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);

        }
    }
}

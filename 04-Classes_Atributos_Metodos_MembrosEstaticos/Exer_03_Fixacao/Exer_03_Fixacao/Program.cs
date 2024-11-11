using System;
using System.Globalization;

namespace Exer_03_Fixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            r1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + r1.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = " + r1.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + r1.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

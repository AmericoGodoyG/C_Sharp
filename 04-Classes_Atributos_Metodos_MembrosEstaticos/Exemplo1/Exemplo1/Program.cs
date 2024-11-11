using System; // Importação de depêndencias
using System.Transactions;
using System.Globalization;
using Exemplo1;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando os objetos x e y do a partir da classe triângulo (Stack)
            Triangulo x, y;

            // Instânciado os objetos x e y  (Heap)
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X : ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y : ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Área do triângulo X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do triângulo Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine($"Área de X é a maior.");
            } else
            {
                Console.WriteLine($"Área de Y é a maior.");
            }
        }
    }
}

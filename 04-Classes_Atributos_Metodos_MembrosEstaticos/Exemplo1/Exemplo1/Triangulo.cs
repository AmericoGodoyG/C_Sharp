using System;

namespace Exemplo1
{
    internal class Triangulo
    {
        // Propriedades do triângulo
        public double A;
        public double B;
        public double C;

        // Método cálculo de área
        public double Area()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p  - A) * (p - B) * (p - C));
        }
    }
}
 


using System;

namespace Membros_Estaticos
{
    internal class Calculadora
    {
        // static permite o uso dos membros sem a necessidade de instanciar um objeto
        public static double Pi = 3.14;

        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3 * Pi * Math.Pow(r, 2);
        }
    }
}

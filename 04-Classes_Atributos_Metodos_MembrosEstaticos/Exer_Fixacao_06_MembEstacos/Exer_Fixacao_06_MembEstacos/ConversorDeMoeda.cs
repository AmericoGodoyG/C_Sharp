using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_Fixacao_06_MembEstacos
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double ValorEmReais(double qte_dolar, double qte_real)
        {
            double total = qte_dolar * qte_real;
            return total + total * Iof / 100;
        }

    }
}

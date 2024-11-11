using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exer_05__Fixacao
{
    internal class Aluno
    {
        public string Nome;

        public double NotaUm;

        public double NotaDois;

        public double NotaTres;

        public double NotaFinal()
        {
            return NotaUm + NotaDois + NotaTres;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.00;
            }else
            {
                return 60.00 - NotaFinal();
            }
        }

    }
}

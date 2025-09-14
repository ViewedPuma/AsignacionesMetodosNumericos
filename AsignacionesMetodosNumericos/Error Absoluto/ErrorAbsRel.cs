using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AsignacionesMetodosNumericos.Error_Absoluto
{
    public class ErrorAbsRel
    {
        public static double ErrorAbsoluto(double valorReal, double valorAproximado)
        {
            return Math.Abs(valorReal - valorAproximado);
        }

        public static double ErrorRelativo(double errorAbsoluto, double valorReal)
        {
            if (valorReal == 0)
                throw new ArgumentException("El valor relativo no puede ser 0");

            return (errorAbsoluto / valorReal)*100;
        }

    }
}

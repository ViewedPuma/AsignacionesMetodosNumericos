using System;

namespace AsignacionesMetodosNumericos.Error_Absoluto
{
    public static class ErrorAbsRel
    {
        public static double ErrorAbsoluto(double valorReal, double valorAproximado)
        {
            return Math.Abs(valorReal - valorAproximado);
        }

        public static double ErrorRelativo(double errorAbsoluto, double valorReal)
        {
            if (valorReal == 0)
                throw new ArgumentException("El valor real no puede ser 0 para calcular el error relativo.");

            return (errorAbsoluto / Math.Abs(valorReal)) * 100.0;
        }
    }
}

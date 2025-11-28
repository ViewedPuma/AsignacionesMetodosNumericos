using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosNumericosUnidad5.Implementaciones
{
    public class Interpolacion
    {
        public void despliegaPuntos(double [,] puntos, int n)
        {
           
        }

        public double interpolacionLagrange (double[,] puntos, int n, double x)
        {
            double suma = 0;
            for (int i = 0; i <= n; i++)
            {
                suma += multiplicatoria(i, puntos, n, x) * puntos[i, 1];
            }
            return suma;
        }

        public double multiplicatoria(int i, double[,] puntos, int n, double x)
        {
            double producto = 1;
            for( int j=0; j <=n; j++)
            {
                if(j != i)
                {
                    producto *= (x - puntos[j, 0]) / (puntos[i,0] - puntos[j,0]);
                }
            }
            return producto;
        }
    }
}

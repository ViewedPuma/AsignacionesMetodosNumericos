using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosNumericos_Unidad2.Asignacion07.implementaciones
{
    public class SolucionEcuaciones
    {
        public double[] EliminacionGauss(double[,] a)
        {
            int n = a.GetLength(0);
            EliminacionAdelante(a);
            return SustitucionAtras(a, new double[n]);
        }

        public void EliminacionAdelante(double[,] a)
        {
            int n = a.GetLength(0);

            for (int i = 0; i < n - 1; i++)
            {
                Pivotea(a, i);

                for (int k = i + 1; k < n; k++)
                {
                    double factor = a[k, i] / a[i, i];
                    for (int j = i; j < n + 1; j++)
                    {
                        a[k, j] = a[k, j] - factor * a[i, j];
                    }
                }
            }
        }

        public void Pivotea(double[,] a, int i)
        {
            int n = a.GetLength(0);
            int maxFila = i;
            double maxValor = Math.Abs(a[i, i]);

            for (int k = i + 1; k < n; k++)
            {
                if (Math.Abs(a[k, i]) > maxValor)
                {
                    maxValor = Math.Abs(a[k, i]);
                    maxFila = k;
                }
            }

            if(maxFila != i)
            {
                for (int j = 0; j <= n; j++)
                {
                    double temp = a[i, j];
                    a[i, j] = a[maxFila, j];
                    a[maxFila, j] = temp;
                }
            }
        }

        public double[] SustitucionAtras(double[,] a, double[] x)
        {
            int n = a.GetLength(0);

            for (int i = n-1; i >= 0; i--)
            {
                double suma = 0;
                for(int j = i + 1; j < n; j++)
                {
                    suma += a[i, j] * x[j];
                }

                x[i] = (a[i, n] - suma) / a[i, i];
            }

            return x;
        }
        //Puede que los metodos DespliegaMatrizAmpliada y DespliegaSolucion no sean necesarios dado que mostrare los resultados en Textbox.
        public void DespliezaMatrizAmpliada(double[,] a)
        {

        }

        public void DespliegaSolucion(double[] x)
        {

        }

        public double[] GaussJordan(double[,] a)
        {
            int n = a.GetLength(0);

            for(int i=0; i < n; i++)
            {
                Pivotea(a, i);

                double pivote = a[i, i];

                for (int j = 0; j <= n; j++) 
                {
                    a[i, j] /= pivote;
                }

                for (int k = 0; k < n; k++)
                {
                    if (k != i)
                    {
                        double factor = a[k, i];
                        for (int j = 0; j <= n; j++)
                            a[k, j] -= factor * a[i, j];
                    }
                }
            }

            double[] x = new double[n];
            for (int i = 0; i < n; i++)
                x[i] = a[i, n];

            return x;
        }
    }
}

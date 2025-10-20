using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosNumericos_Unidad2.Meotodo_Gauss_Seidel
{
    public class Gauss_Seidel
    {
        public int Iteraciones { get; set; }
        public List <Iteraciones_GaussSeidel> MetodoGaussSeidel(double[,] a, double eaMax, int maxIteraciones = 100)
        {
            if (a == null) throw new ArgumentException("La matriz debe de ser de mas de n x (n+1)");

            int n = a.GetLength(0);
            if(a.GetLength(1) != n + 1)
                throw new ArgumentException("La matriz debe de ser de tamaño de n x (n+1)");

            var historial = new List<Iteraciones_GaussSeidel>();
            Iteraciones = 0;
            var x = new double[n];
            var ea = new double[n];
            for (int i = 0; i < n; i++) ea[i] = 100.0;

            for (int iter = 1; iter <= maxIteraciones; iter++)
            {
                var xPrev = (double[])x.Clone();

                for (int i = 0; i < n; i++)
                {
                    double suma = 0.0;
                    for (int j = 0; j < n; j++)
                    {
                        if (i != j) suma += a[i, j] * x[j]; 
                    }

                    double diag = a[i, i];
                    if (diag == 0.0)
                        throw new ArgumentException("Elemento diagonal cero; no se puede dividir.");

                    x[i] = (a[i, n] - suma) / diag;

                    if (x[i] != 0.0)
                        ea[i] = Math.Abs((x[i] - xPrev[i]) / x[i]) * 100.0; // en %
                    else
                        ea[i] = 100.0; // conserva grande si es 0 para evitar división
                }

                double eaIter = 0.0;
                for (int k = 0; k < n; k++) eaIter = Math.Max(eaIter, ea[k]);

                var registro = new Iteraciones_GaussSeidel
                {
                    Numero = iter,
                    NumeroIteracion = iter,
                    ValoresSolucion = (double[])x.Clone(),         // snapshoot para no compartir referencia
                    ErroresAproximados = (double[])ea.Clone(),     // idem
                    Ea = eaIter,
                    Convergido = eaIter <= eaMax
                };
                historial.Add(registro);

                Iteraciones = iter;
                if (eaIter <= eaMax) break;
            }
            return historial;
        }
    }
}

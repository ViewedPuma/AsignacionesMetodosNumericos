using System;

namespace MetodosDeRegresion
{
    // Regresión Lineal Simple: y = a0 + a1*x
    public class RegresionLineal
    {
        public double[] ResolverSistema(double[,] A, double[] B)
        {
            int n = B.Length;
            double[,] M = new double[n, n + 1];

            // Construir matriz aumentada
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    M[i, j] = A[i, j];
                M[i, n] = B[i];
            }

            // Gauss-Jordan
            for (int i = 0; i < n; i++)
            {
                double pivote = M[i, i];
                for (int j = 0; j <= n; j++)
                    M[i, j] /= pivote;

                for (int k = 0; k < n; k++)
                {
                    if (k == i) continue;
                    double factor = M[k, i];
                    for (int j = 0; j <= n; j++)
                        M[k, j] -= factor * M[i, j];
                }
            }

            double[] X = new double[n];
            for (int i = 0; i < n; i++)
                X[i] = M[i, n];

            return X;
        }




        //Regresión lineal simple

        public (double a, double b) LinealSimple(double[] x, double[] y)
        {
            int n = x.Length;
            double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;

            for (int i = 0; i < n; i++)
            {
                sumX += x[i];
                sumY += y[i];
                sumXY += x[i] * y[i];
                sumX2 += x[i] * x[i];
            }

            double b = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
            double a = (sumY - b * sumX) / n;
            return (a, b);
        }

        public double[] Polinomial(double[] x, double[] y, int grado)
        {
            int n = x.Length;
            double[,] X = new double[grado + 1, grado + 1];
            double[] B = new double[grado + 1];

            for (int i = 0; i <= grado; i++)
            {
                for (int j = 0; j <= grado; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < n; k++)
                        sum += Math.Pow(x[k], i + j);
                    X[i, j] = sum;
                }

                double sumY = 0;
                for (int k = 0; k < n; k++)
                    sumY += y[k] * Math.Pow(x[k], i);
                B[i] = sumY;
            }

            return ResolverSistema(X, B); // Gauss-Jordan
        }


        public double[] LinealMultiple(double[,] X, double[] Y)
        {

            return MinimosCuadrados(X, Y);
        }

        public double[,] InvertirMatriz(double[,] matriz)
        {
            int n = matriz.GetLength(0);
            double[,] result = new double[n, n];
            double[,] copia = new double[n, n];

            // Inicializar result como identidad y copia como la matriz original
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    copia[i, j] = matriz[i, j];
                    result[i, j] = (i == j) ? 1.0 : 0.0;
                }
            }

            for (int i = 0; i < n; i++)
            {
                // Dividir la fila i por el pivote
                double pivote = copia[i, i];
                if (Math.Abs(pivote) < 1e-12)
                    throw new Exception("Matriz singular, no se puede invertir.");

                for (int j = 0; j < n; j++)
                {
                    copia[i, j] /= pivote;
                    result[i, j] /= pivote;
                }

                // Hacer ceros en la columna i para todas las demás filas
                for (int k = 0; k < n; k++)
                {
                    if (k == i) continue;
                    double factor = copia[k, i];
                    for (int j = 0; j < n; j++)
                    {
                        copia[k, j] -= factor * copia[i, j];
                        result[k, j] -= factor * result[i, j];
                    }
                }
            }

            return result;
        }


        public double[] MinimosCuadrados(double[,] X, double[] Y)
        {
            int filas = X.GetLength(0);
            int columnas = X.GetLength(1);

            // Crear nueva matriz agregando columna de 1s para el intercepto
            double[,] XconB0 = new double[filas, columnas + 1];
            for (int i = 0; i < filas; i++)
            {
                XconB0[i, 0] = 1.0; // b0
                for (int j = 0; j < columnas; j++)
                    XconB0[i, j + 1] = X[i, j];
            }

            // Transponer XconB0
            int newCols = XconB0.GetLength(1);
            double[,] XT = new double[newCols, filas];
            for (int i = 0; i < filas; i++)
                for (int j = 0; j < newCols; j++)
                    XT[j, i] = XconB0[i, j];

            // Calcular XT*X
            double[,] XTX = new double[newCols, newCols];
            for (int i = 0; i < newCols; i++)
                for (int j = 0; j < newCols; j++)
                    for (int k = 0; k < filas; k++)
                        XTX[i, j] += XT[i, k] * XconB0[k, j];

            // Invertir XTX
            double[,] XTXinv = InvertirMatriz(XTX);

            // Calcular XT*Y
            double[] XTY = new double[newCols];
            for (int i = 0; i < newCols; i++)
                for (int k = 0; k < filas; k++)
                    XTY[i] += XT[i, k] * Y[k];

            // Calcular beta
            double[] beta = new double[newCols];
            for (int i = 0; i < newCols; i++)
                for (int j = 0; j < newCols; j++)
                    beta[i] += XTXinv[i, j] * XTY[j];

            return beta;
        }



    }
}

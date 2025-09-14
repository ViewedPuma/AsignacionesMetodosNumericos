using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignacionesMetodosNumericos.Asignacion02TabulacionFunciones
{
    public class Tabula
    {
        public  List<(double x, double y)> Tabular(Func<double, double> f, double xi, double xf, double incx, out double xmin, out double ymin, out double xmax, out double ymax)
        {
            List<(double, double)> resultados = new List<(double, double)>();

            double x = xi;
            ymin = double.MaxValue;
            ymax = double.MinValue;
            xmin = xi;
            xmax = xi;

            while (x <= xf)
            {
                try
                {
                    double y = f(x);
                    resultados.Add((x, y));

                    if (y < ymin) { ymin = y; xmin = x; }
                    if (y > ymax) { ymax = y; xmax = x; }
                }
                catch
                {
                    // Manejo de errores si la función no es válida en algún punto
                    resultados.Add((x, double.NaN)); // Usar NaN para indicar un valor no válido
                }
                x += incx;



            }
            return resultados;
        }
            
        
    }
}

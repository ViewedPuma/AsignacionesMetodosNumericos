using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignacionesMetodosNumericos.Secante
{
    public class Secante
    {
        public int Iteraciones { get; set; }
        public List<Iteraciones_Secante> MetodoSecante(
            Func<double, double> f,
            double xi,
            double x1,
            double eaMax)
        {
            var listaIteraciones = new List<Iteraciones_Secante>();
            Iteraciones = 0;
            double xn_1 = xi;
            double xn = x1;
            double ea = 100; //Error inicial de 100%
            while (ea > eaMax)
            {
                double fxn_1 = f(xn_1);
                double fxn = f(xn);
                if (fxn - fxn_1 == 0)
                {
                    throw new ArgumentException("La funcion no puede tener el mismo valor en los dos puntos");
                }
                double xn1 = xn - fxn * (xn - xn_1) / (fxn - fxn_1);
                if (Iteraciones > 0)
                {
                    ea = Math.Abs((xn1 - xn) / xn1) * 100;
                }
                listaIteraciones.Add(new Iteraciones_Secante
                {
                    Numero = Iteraciones + 1,
                    Xi_1 = xn_1,
                    Xi = xn,
                    Fxi_1 = fxn_1,
                    Fxi = fxn,
                    Xi1 = xn1,
                    Ea = ea
                });
                xn_1 = xn;
                xn = xn1;
                Iteraciones++;
            }
            return listaIteraciones;
        }
    }
}

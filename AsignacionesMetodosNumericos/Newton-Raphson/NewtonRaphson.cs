using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignacionesMetodosNumericos.Newton_Raphson
{
    
    public class NewtonRaphson
    {
        public int Iteraciones { get; set; }

        public List<Iteraciones_NewtonRaphson> MetodoNewtonRaphson(
            Func<double, double> f,
            Func<double, double> df,
            double xi,
            double eaMax)
        {
            var listaIteraciones = new List<Iteraciones_NewtonRaphson>();
            Iteraciones = 0;
            double xn = xi;
            double ea = 100; //Error inicial de 100%

            while (ea > eaMax)
            {
                double fx = f(xn);
                double dfx = df(xn);

                if(dfx == 0)
                {
                    throw new ArgumentException("La derivada de la funcion no puede ser igual a 0");
                }

                double xn1 = xn - fx / dfx;

                if(Iteraciones > 0)
                {
                    ea = Math.Abs((xn1 - xn) / xn1) * 100;
                }

                listaIteraciones.Add(new Iteraciones_NewtonRaphson
                {
                    Numero = Iteraciones + 1,
                    Xi = xn,
                    Fxi = fx,
                    DFx = dfx,
                    Xn1 = xn1,
                    Ea = ea
                });
                xn = xn1;
                Iteraciones++;
            }
            return listaIteraciones;
        }
    }
}

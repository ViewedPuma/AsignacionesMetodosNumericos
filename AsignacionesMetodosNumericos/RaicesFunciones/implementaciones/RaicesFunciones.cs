using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AsignacionesMetodosNumericos.RaicesFunciones.implementaciones
{
    public class RaicesFunciones
    {
        public int Iteraciones { get; set; }
        public List<Iteraciones_Bisecc> Biseccion(
           Func<double, double> f,
           double xi,
           double xf, //Parametros de los valores de entrada
           double eamax)
        {

            var listaIteraciones = new List<Iteraciones_Bisecc>(); //Con esto guardamos las iteraciones


            Iteraciones = 0;
            double xr = 0;
            double ea = 100; //Error inicial alto para entrar al ciclo


            // Validar cambio de signo al inicio
            if (f(xi) * f(xf) >= 0)
                //Muestra una ventana de error si no hay cambio de signo
                throw new ArgumentException("La función debe cambiar de signo en el intervalo [xi, xf].");




            while (ea > eamax)
            {
                double xrsave = xr; //Ira guardando el valor de Xr anterior
                xr = (xi + xf) / 2; //Sacar la xr

                double fxr = f(xr);
                double fxi = f(xi); //Ahora evaluamos la funcion sustituyendo las Xi y las Xf
                double fxf = f(xf);

                if (Iteraciones > 0) //No sale error en la primera iteracion hasta que 
                                     //Se tengan dos iteraciones 0 y 1
                {
                    ea = Math.Abs((xr - xrsave) / xr) * 100; // error aproximado
                }

                // Determinar en qué subintervalo continuar
                double fxiFxr = fxi * fxr;

                if (fxiFxr < 0)
                {
                    xf = xr;
                }
                else if (fxiFxr > 0)
                {
                    xi = xr;
                }
                else
                {
                    ea = 0; // Raíz exacta encontrada
                }

                // Guardar en lista
                listaIteraciones.Add(new Iteraciones_Bisecc
                {
                    Numero = Iteraciones + 1,
                    Xi = xi,
                    Xf = xf,
                    Xr = xr,
                    Fxi = fxi,
                    Fxr = fxr,
                    FxiFxr = fxiFxr,
                    Ea = ea,



                });

                Iteraciones++;
            }

            return listaIteraciones;
        }

        // Método para la Regla Falsa
        public List<Iteraciones_ReglaFalsa> ReglaFalsa(
            Func<double, double> f,
            double xi,
            double xf,
            double eamax)
        {
            var listaIteraciones = new List<Iteraciones_ReglaFalsa>();
            Iteraciones = 0;
            double xr = 0;
            double ea = 100;

            if (f(xi) * f(xf) >= 0)
                throw new ArgumentException("La función debe cambiar de signo en el intervalo [xi, xf].");

            while (ea > eamax)
            {
                double xrsave = xr;
                double fxi = f(xi);
                double fxf = f(xf);

                // Fórmula de la Regla Falsa
                xr = xf - (fxf * (xi - xf)) / (fxi - fxf);

                double fxr = f(xr);

                if (Iteraciones > 0)
                {
                    ea = Math.Abs((xr - xrsave) / xr) * 100;
                }

                double fxiFxr = fxi * fxr;

                if (fxiFxr < 0)
                {
                    xf = xr;
                }
                else if (fxiFxr > 0)
                {
                    xi = xr;
                }
                else
                {
                    ea = 0;
                }

                listaIteraciones.Add(new Iteraciones_ReglaFalsa
                {
                    Numero = Iteraciones + 1,
                    Xi = xi,
                    Xf = xf,
                    Fxi = fxi,
                    Fxf = fxf,
                    Xr = xr,
                    Fxr = fxr,
                    FxiFxr = fxiFxr,
                    Ea = ea,
                });

                Iteraciones++;
            }

            return listaIteraciones;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosNumericos_Unidad2.Meotodo_Gauss_Seidel
{
    public class Iteraciones_GaussSeidel
    {
        public  double[] ValoresSolucion { get; set; }
        public double[] ErroresAproximados { get; set; }

        public bool Convergido { get; set; }
        public int NumeroIteracion { get; set; }

        public int Numero { get; set; }
        public double Ea { get; set; }

    }
}

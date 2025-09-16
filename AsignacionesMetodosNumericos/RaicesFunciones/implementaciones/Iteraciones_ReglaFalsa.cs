using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignacionesMetodosNumericos.RaicesFunciones.implementaciones
{
    public class Iteraciones_ReglaFalsa
    {
        public int Numero { get; set; }
        public double Xi { get; set; }
        public double Xf { get; set; }
        
        public double Fxi { get; set; }
        public double Fxf { get; set; }
        public double Xr { get; set; }
        

        
        public double Fxr { get; set; }
        public double FxiFxr { get; set; }
        public double Ea { get; set; }
    }
}

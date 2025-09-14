using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignacionesMetodosNumericos.Asignacion02TabulacionFunciones
{
    public partial class TabularFuncionesControl : UserControl
    {
        public TabularFuncionesControl()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyles(this);
        }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //este es para las funciones, despues tendre que agregar no solo estas dos funciones si no que se pueden escribir
        private void button9_Click(object sender, EventArgs e)
        {
            Tabula t = new Tabula();

            Func<double, double> f = (x) => 4 * Math.Pow(x, 3)
                                            - 6 * Math.Pow(x, 2)
                                            + 7 * x - 2.3;

            Func<double, double> g = (x) => Math.Pow(x, 2) *
                                            Math.Sqrt(Math.Abs(Math.Cos(x))) - 5;
            //sirve para limpiar grid view
            dgvResultados.Columns.Clear();
            dgvResultados.Rows.Clear();

            //Crear las columnas
            dgvResultados.Columns.Add("Funcion", "Funcion");
            dgvResultados.Columns.Add("X", "x");
            dgvResultados.Columns.Add("Y", "f(x)");

            double xmin, ymin, xmax, ymax;

            var datosF = t.Tabular(f, 0.0, 1.0, 0.1, out xmin, out ymin, out xmax, out ymax);

            foreach (var (X, Y) in datosF)
                dgvResultados.Rows.Add("f(x)", X.ToString("F2"), Y.ToString("F4"));


            dgvResultados.Rows.Add("Mínimo", xmin.ToString("F2"), ymin.ToString("F4"));
            dgvResultados.Rows.Add("Máximo", xmax.ToString("F2"), ymax.ToString("F4"));

            // Tabular g(x) de -3 a -2
            var datosG1 = t.Tabular(g, -3.0, -2.0, 0.1, out xmin, out ymin, out xmax, out ymax);

            foreach (var (X, Y) in datosG1)
                dgvResultados.Rows.Add("g(x) (-3,-2)", X.ToString("F2"), Y.ToString("F4"));

            dgvResultados.Rows.Add("Mínimo", xmin.ToString("F2"), ymin.ToString("F4"));
            dgvResultados.Rows.Add("Máximo", xmax.ToString("F2"), ymax.ToString("F4"));

            // Tabular g(x) de 2 a 3
            var datosG2 = t.Tabular(g, 2.0, 3.0, 0.1, out xmin, out ymin, out xmax, out ymax);

            foreach (var (X, Y) in datosG2)
                dgvResultados.Rows.Add("g(x) (2,3)", X.ToString("F2"), Y.ToString("F4"));

            dgvResultados.Rows.Add("Mínimo", xmin.ToString("F2"), ymin.ToString("F4"));
            dgvResultados.Rows.Add("Máximo", xmax.ToString("F2"), ymax.ToString("F4"));
        }
        //este es para boton volver

        public event EventHandler VolverClick;

        private void button1_Click(object sender, EventArgs e)
        {
            VolverClick?.Invoke(this, EventArgs.Empty);
        }

        

       
    }
}

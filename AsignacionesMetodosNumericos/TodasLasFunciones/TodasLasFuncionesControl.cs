using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsignacionesMetodosNumericos.RaicesFunciones.implementaciones;
using AsignacionesMetodosNumericos.Newton_Raphson;
using AsignacionesMetodosNumericos.Secante;

namespace AsignacionesMetodosNumericos.TodasLasFunciones
{
    public partial class TodasLasFuncionesControl : UserControl
    {
        public TodasLasFuncionesControl()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyles(this);

            //Opciones del comboBox
            cmbFuncion.Items.Clear();
            cmbFuncion.Items.Add("f(x) = x^3 - 5");
            cmbFuncion.Items.Add("f(x) = x^2 - 2");
            cmbFuncion.Items.Add("f(x) = e^x -3");
            cmbFuncion.Items.Add("f(x) = cos(x) - x");
            cmbFuncion.Items.Add("f(x) = ln(x) + x");
            cmbFuncion.Items.Add("f(x) = 4x^3 -6x^2 + 7x - 2.3");
            cmbFuncion.Items.Add("f(x) = x^2 sqrt |cos(x)| - 5");
            cmbFuncion.SelectedIndex = -1; // Sin selección inicial
        }

        private (Func<double, double> f, Func<double, double> df) GetFunctionAndDerivative(int index)
        {
            switch (index)
            {
                case 0:
                    return (x => Math.Pow(x, 3) - 5, x => 3 * Math.Pow(x, 2));
                case 1:
                    return (x => Math.Pow(x, 2) - 2, x => 2 * x);
                case 2:
                    return (x => Math.Exp(x) - 3, x => Math.Exp(x));
                case 3:
                    return (x => Math.Cos(x) - x, x => -Math.Sin(x) - 1);
                case 4:
                    return (x => Math.Log(x) + x, x => 1 / x + 1);
                case 5:
                    return (x => 4 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 7 * x - 2.3, x => 12 * Math.Pow(x, 2) - 12 * x + 7);
                case 6:
                    return (x => Math.Pow(x, 2) * Math.Sqrt(Math.Abs(Math.Cos(x))) - 5, x => 2 * x * Math.Sqrt(Math.Abs(Math.Cos(x))) + Math.Pow(x, 2) * (0.5 / Math.Sqrt(Math.Abs(Math.Cos(x)))) * (-Math.Sin(x) * Math.Sign(Math.Cos(x))));
                default:
                    return (null, null);
            }
        }

      
        public event EventHandler VolverClick;
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            VolverClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtErrorAproximado.Clear();
            txtValor1.Clear();
            txtValor2.Clear();
            cmbFuncion.SelectedIndex = -1;
            dgvTodasLasFunciones.DataSource = null;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbFuncion.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una función", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtValor1.Text, out double xi) ||
                !double.TryParse(txtValor2.Text, out double xf) ||
                !double.TryParse(txtErrorAproximado.Text, out double eamax))
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var (f, df) = GetFunctionAndDerivative(cmbFuncion.SelectedIndex);
            if (f == null)
            {
                MessageBox.Show("Función no válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var raices = new RaicesFunciones.implementaciones.RaicesFunciones();
            var biseccion = raices.Biseccion(f, xi, xf, eamax);
            var reglaFalsa = raices.ReglaFalsa(f, xi, xf, eamax);

            var newton = new NewtonRaphson();
            var newtonRes = newton.MetodoNewtonRaphson(f, df, xi, eamax); // Xi as initial guess

            // Change this line:
            // var secante = new Secante();
            // To this, assuming the class is Secante.Secante (based on the namespace):
            var secante = new Secante.Secante();
            var secanteRes = secante.MetodoSecante(f, xi, xf, eamax);

            dgvTodasLasFunciones.Columns.Clear();
            dgvTodasLasFunciones.Rows.Clear();

            dgvTodasLasFunciones.Columns.Add("Metodo", "Método");
            dgvTodasLasFunciones.Columns.Add("Iteraciones", "Iteraciones");
            dgvTodasLasFunciones.Columns.Add("Raiz", "Raíz");
            dgvTodasLasFunciones.Columns.Add("YRaiz", "Y(raíz)");
            dgvTodasLasFunciones.Columns.Add("ErrorAprox", "Error aprox");

            void AddRow(string metodo, int iteraciones, double raiz, double yRaiz, double errorAprox)
            {
                dgvTodasLasFunciones.Rows.Add(
                    metodo,
                    iteraciones.ToString(),
                    raiz.ToString("F4"),
                    yRaiz.ToString("F4"),
                    errorAprox.ToString("F4")
                );
            }

            AddRow("Bisección", biseccion.Count, biseccion.Last().Xr, f(biseccion.Last().Xr), biseccion.Last().Ea);
            AddRow("Regla falsa", reglaFalsa.Count, reglaFalsa.Last().Xr, f(reglaFalsa.Last().Xr), reglaFalsa.Last().Ea);
            AddRow("Newton-Raphson", newtonRes.Count, newtonRes.Last().Xn1, f(newtonRes.Last().Xn1), newtonRes.Last().Ea);
            AddRow("Secante", secanteRes.Count, secanteRes.Last().Xi1, f(secanteRes.Last().Xi1), secanteRes.Last().Ea);
        }
    }
}

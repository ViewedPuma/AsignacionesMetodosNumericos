using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignacionesMetodosNumericos.RaicesFunciones.implementaciones
{
    public partial class MetodoReglaFalsaControl : UserControl
    {
        public MetodoReglaFalsaControl()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyles(this);
        }


        implementaciones.RaicesFunciones raices = new implementaciones.RaicesFunciones();
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double xi = double.Parse(txtXinicial.Text);
            double xf = double.Parse(txtXfinal.Text);
            double eamax = double.Parse(txtErrorAproximado.Text);
            string funcionTexto = txtFuncion.Text;


            if (xi == 0 & xf == 0 & eamax == 0 & funcionTexto == " ")
            {
                MessageBox.Show("Los valores no pueden ser nulos llenalos", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Asegura multiplicación explícita: 4x -> 4*x
            funcionTexto = System.Text.RegularExpressions.Regex.Replace(funcionTexto, @"(\d)(x)", "$1*$2");

            // Convierte potencias: x^3 -> Pow(x,3), 4*x^3 -> 4*Pow(x,3)
            funcionTexto = System.Text.RegularExpressions.Regex.Replace(
                funcionTexto,
                @"x\^(\d+)",
                "Pow(x,$1)"
            );
            // También para casos como 4x^3 -> 4*Pow(x,3)
            funcionTexto = System.Text.RegularExpressions.Regex.Replace(
                funcionTexto,
                @"(\d+)\*x\^(\d+)",
                "$1*Pow(x,$2)"
            );
            funcionTexto = System.Text.RegularExpressions.Regex.Replace(
                funcionTexto,
                @"(\d+)x\^(\d+)",
                "$1*Pow(x,$2)"
            );

            funcionTexto = Regex.Replace(funcionTexto, @"\bsqrt\b", "Sqrt", RegexOptions.IgnoreCase);
            funcionTexto = Regex.Replace(funcionTexto, @"\babs\b", "Abs", RegexOptions.IgnoreCase);
            funcionTexto = Regex.Replace(funcionTexto, @"\bcos\b", "Cos", RegexOptions.IgnoreCase);
            // Convertir texto a función dinámica
            Func<double, double> funcion = (x) =>
            {
                var expr = new NCalc.Expression(funcionTexto);
                expr.Parameters["x"] = x;
                var result = expr.Evaluate();
                if (result is double d)
                    return d;
                if (result is int i)
                    return Convert.ToDouble(i);
                throw new InvalidOperationException($"La expresión no se pudo evaluar como número. Resultado: {result} (Tipo: {result?.GetType().Name})");
            };

            var raices = new implementaciones.RaicesFunciones();
            var resultado = raices.ReglaFalsa(funcion, xi, xf, eamax);

            // Mostrar en DataGridView
            dgvReglaFalsa.DataSource = resultado;

            // Formatear columnas después de asignar el DataSource
            dgvReglaFalsa.Columns["Xi"].DefaultCellStyle.Format = "F4";
            dgvReglaFalsa.Columns["Xf"].DefaultCellStyle.Format = "F4";
            dgvReglaFalsa.Columns["Xr"].DefaultCellStyle.Format = "F4";
            dgvReglaFalsa.Columns["Fxi"].DefaultCellStyle.Format = "F4";
            dgvReglaFalsa.Columns["Fxr"].DefaultCellStyle.Format = "F4";
            dgvReglaFalsa.Columns["Fxf"].DefaultCellStyle.Format = "F4";
            dgvReglaFalsa.Columns["FxiFxr"].DefaultCellStyle.Format = "F4";
            dgvReglaFalsa.Columns["Ea"].DefaultCellStyle.Format = "F4";
        }

        public event EventHandler VolverClick;
        private void BtnVolver_Click_1(object sender, EventArgs e)
        {
            VolverClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtXinicial.Clear();
            txtXfinal.Clear();
            txtErrorAproximado.Clear();
            txtFuncion.Clear();
            dgvReglaFalsa.DataSource = null;
            dgvReglaFalsa.Rows.Clear();
            dgvReglaFalsa.Refresh();
        }

        private void MetodoReglaFalsaControl_Load(object sender, EventArgs e)
        {
            txtEjemplo.ReadOnly = true;
            txtEjemplo.BorderStyle = BorderStyle.None;
            txtEjemplo.BackColor = this.BackColor;
            txtEjemplo.TabStop = false;
        }

        private void txtXinicial_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

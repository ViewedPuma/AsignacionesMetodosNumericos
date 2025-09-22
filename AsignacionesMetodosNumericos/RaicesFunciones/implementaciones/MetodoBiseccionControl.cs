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
using NCalc;
using AsignacionesMetodosNumericos.RaicesFunciones.implementaciones;

namespace AsignacionesMetodosNumericos.RaicesFunciones.implementaciones
{
    public partial class MetodoBiseccionControl : UserControl
    {
        public MetodoBiseccionControl()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyles(this);



        }
        public event EventHandler VolverClick;
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            VolverClick?.Invoke(this, EventArgs.Empty);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, el punto decimal y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox)?.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }





        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtXinicial.Clear();
            txtXfinal.Clear();
            txtErrorAproximado.Clear();

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
            var resultado = raices.Biseccion(funcion, xi, xf, eamax);

            // Mostrar en DataGridView
            dgvBiseccion.DataSource = resultado;

            // Formatear columnas después de asignar el DataSource
            dgvBiseccion.Columns["Xi"].DefaultCellStyle.Format = "F4";
            dgvBiseccion.Columns["Xf"].DefaultCellStyle.Format = "F4";
            dgvBiseccion.Columns["Xr"].DefaultCellStyle.Format = "F4";
            dgvBiseccion.Columns["Fxi"].DefaultCellStyle.Format = "F4";
            dgvBiseccion.Columns["Fxr"].DefaultCellStyle.Format = "F4";
            dgvBiseccion.Columns["FxiFxr"].DefaultCellStyle.Format = "F4";
            dgvBiseccion.Columns["Ea"].DefaultCellStyle.Format = "F4";
        }







        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblFuncion_Click(object sender, EventArgs e)
        {

        }

        private void lblXi_Click(object sender, EventArgs e)
        {

        }

        private void MetodoBiseccionControl_Load(object sender, EventArgs e)
        {
            txtEjemplo.ReadOnly = true;
            txtEjemplo.BorderStyle = BorderStyle.None;
            txtEjemplo.BackColor = this.BackColor;
            txtEjemplo.TabStop = false;
        }

        private void txtEjemplo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

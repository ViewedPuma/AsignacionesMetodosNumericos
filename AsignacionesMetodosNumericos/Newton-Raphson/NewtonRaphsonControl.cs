using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignacionesMetodosNumericos.Newton_Raphson
{
    public partial class NewtonRaphsonControl : UserControl
    {
        public NewtonRaphsonControl()
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
            cmbFuncion.SelectedIndex = -1; // Sin selección inicial

            /*
            f(x) = x^3 - 5
            f(x) = x^2 - 2
            f(x) = e^x -3
            f(x) = cos(x) - x
            f(x) = ln(x) + x
             */
            txtErrorAproximado.KeyPress += txtSoloNumeros_KeyPress;
            txtXinicial.KeyPress += txtSoloNumeros_KeyPress;
        }

        private void txtXinicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtErrorAproximado_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbFuncion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFuncion.SelectedIndex)
            {
                case 0:
                    lblFuncion.Text = "f(x) = x^3 - 5";
                    break;
                case 1:
                    lblFuncion.Text = "f(x) = x^2 - 2";
                    break;
                case 2:
                    lblFuncion.Text = " f(x) = e^x -3";
                    break;
                case 3:
                    lblFuncion.Text = "f(x) = cos(x) - x";
                    break;
                case 4:
                    lblFuncion.Text = "f(x) = ln(x) + x";
                    break;
                case 5:
                    lblFuncion.Text = "f(x) = 4x^3 -6x^2 + 7x - 2.3";
                    break;
                default:
                    lblFuncion.Text = "Seleccione una función";
                    break;
            }
        }

        public event EventHandler VolverClick;
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            VolverClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbFuncion.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una función", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double x0 = double.Parse(txtXinicial.Text);
            double eaMax = double.Parse(txtErrorAproximado.Text);

            Func<double, double> f;
            Func<double, double> df;

            switch (cmbFuncion.SelectedIndex)
            {
                case 0:
                    f = (x) => Math.Pow(x, 3) - 5;
                    df = (x) => 3 * Math.Pow(x, 2);
                    break;
                case 1:
                    f = (x) => Math.Pow(x, 2) - 2;
                    df = (x) => 2 * x;
                    break;
                case 2:
                    f = (x) => Math.Exp(x) - 3;
                    df = (x) => Math.Exp(x);
                    break;
                case 3:
                    f = (x) => Math.Cos(x) - x;
                    df = (x) => -Math.Sin(x) - 1;
                    break;
                case 4:
                    f = (x) => Math.Log(x) + x;
                    df = (x) => 1 / x + 1;
                    break;
                case 5:
                    f = (x) => 4 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 7 * x - 2.3;
                    df = (x) => 12 * Math.Pow(x, 2) - 12 * x + 7;
                    break;
                default:
                    MessageBox.Show("Función no válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            NewtonRaphson newtonRaphson = new NewtonRaphson();
            var resultados = newtonRaphson.MetodoNewtonRaphson(f, df, x0, eaMax);

            dgvNewtonRaphson.DataSource = resultados;

            dgvNewtonRaphson.Columns["Xi"].DefaultCellStyle.Format = "F4";
            dgvNewtonRaphson.Columns["Fxi"].DefaultCellStyle.Format = "F4";
            dgvNewtonRaphson.Columns["DFx"].DefaultCellStyle.Format = "F4";
            dgvNewtonRaphson.Columns["Xn1"].DefaultCellStyle.Format = "F4";
            dgvNewtonRaphson.Columns["Ea"].DefaultCellStyle.Format = "F4";
            dgvNewtonRaphson.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            /*public int Numero { get; set; }
                public double Xi { get; set; }
                public double Fxi { get; set; }
                public double DFx { get; set; }
                public double Xn1 { get; set; }
                public double Ea { get; set; }*/

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtErrorAproximado.Clear();
            txtXinicial.Clear();
            cmbFuncion.SelectedIndex = -1;
            dgvNewtonRaphson.DataSource = null;
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

        private void NewtonRaphsonControl_Load(object sender, EventArgs e)
        {

        }
    }
}

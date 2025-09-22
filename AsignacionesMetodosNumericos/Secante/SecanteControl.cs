using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignacionesMetodosNumericos.Secante
{
    public partial class SecanteControl : UserControl
    {
        public SecanteControl()
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
            cmbFuncion.Items.Add("f(x) = x^2 sqrt |cos(x)| - 5");
            cmbFuncion.SelectedIndex = -1; // Sin selección inicial

            txtErrorAproximado.KeyPress += txtSoloNumeros_KeyPress;
            txtValor1.KeyPress += txtSoloNumeros_KeyPress;
            txtValor2.KeyPress += txtSoloNumeros_KeyPress;
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
            dgvSecante.DataSource = null;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbFuncion.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una función", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtValor1.Text, out double x0) ||
                !double.TryParse(txtValor2.Text, out double x1) ||
                !double.TryParse(txtErrorAproximado.Text, out double eaMax))
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Func<double, double> f;

            switch (cmbFuncion.SelectedIndex)
            {
                case 0:
                    f = (x) => Math.Pow(x, 3) - 5;
                    break;
                case 1:
                    f = (x) => Math.Pow(x, 2) - 2;
                    break;
                case 2:
                    f = (x) => Math.Exp(x) - 3;
                    break;
                case 3:
                    f = (x) => Math.Cos(x) - x;
                    break;
                case 4:
                    f = (x) => Math.Log(x) + x;
                    break;
                case 5:
                    f = (x) => Math.Pow(x, 2) * Math.Sqrt(Math.Abs(Math.Cos(x))) - 5;
                    break;
                default:
                    MessageBox.Show("Función no válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            try
            {
                Secante secante = new Secante();
                var resultados = secante.MetodoSecante(f, x0, x1, eaMax);

                dgvSecante.DataSource = resultados;

                dgvSecante.Columns["Xi_1"].DefaultCellStyle.Format = "F4";
                dgvSecante.Columns["Xi"].DefaultCellStyle.Format = "F4";
                dgvSecante.Columns["Fxi_1"].DefaultCellStyle.Format = "F4";
                dgvSecante.Columns["Fxi"].DefaultCellStyle.Format = "F4";
                dgvSecante.Columns["Xi1"].DefaultCellStyle.Format = "F4";
                dgvSecante.Columns["Ea"].DefaultCellStyle.Format = "F4";
                dgvSecante.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en el cálculo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                default:
                    lblFuncion.Text = "Seleccione una función";
                    break;
            }
        }

        private void txtErrorAproximado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor2_TextChanged(object sender, EventArgs e)
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
    }
}

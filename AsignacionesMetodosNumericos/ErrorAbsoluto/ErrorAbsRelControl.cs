using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignacionesMetodosNumericos.Error_Absoluto
{
    public partial class ErrorAbsRelControl : UserControl
    {
        public ErrorAbsRelControl()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyles(this);
            txtValorAproximado.KeyPress += txtSoloNumeros_KeyPress;
            txtValorReal.KeyPress += txtSoloNumeros_KeyPress;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtValorRelativo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorAbsoluto_TextChanged(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }
        public event EventHandler VolverClick;
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            VolverClick?.Invoke(this, EventArgs.Empty);
        }

        private void lblValor1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtValorRelativo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtValorAbsoluto_KeyPress(object sender, KeyPressEventArgs e)
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
        //Boton para calcular el resultado
        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtValorAproximado.Text, out double valorAproximado) &&
                double.TryParse(txtValorReal.Text, out double valorReal))
            {
                double errorAbs = ErrorAbsRel.ErrorAbsoluto(valorReal, valorAproximado);
                double errorRel = ErrorAbsRel.ErrorRelativo(errorAbs, valorReal);

                lblErrorAbsoluto.Text = $"{errorAbs:F2}";

                lblErrorRelativo.Text = $"{errorRel:F2} %";
            }
        }

        private void btnLimpiarErrores_Click(object sender, EventArgs e)
        {
            txtValorAproximado.Clear();
            txtValorReal.Clear();
            lblErrorAbsoluto.Text = "";
            lblErrorRelativo.Text = "";
        }
    }
}

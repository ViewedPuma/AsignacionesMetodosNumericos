using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsignacionesMetodosNumericos;

namespace MetodosNumericos_Unidad2.Asignacion07
{
    public partial class Asignacion07Control : UserControl
    {
        public Asignacion07Control()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyles(this);


            var numericTextBoxes = new TextBox[]
            {
                txtX11, txtX12, txtX13, txtB1,
                txtX21, txtX22, txtX23, txtB2,
                txtX31, txtX32, txtX33, txtB3
            };

            foreach (var tb in numericTextBoxes)
            {
                // Prevent duplicate subscription (defensive)
                tb.KeyPress -= txtSoloNumeros_KeyPress;
                tb.KeyPress += txtSoloNumeros_KeyPress;
            }

        }
        public event EventHandler VolverClick;
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            VolverClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                var solucion = new implementaciones.SolucionEcuaciones();

                double[,] matriz = new double[3, 4]
                {
                {
                    double.Parse(txtX11.Text),
                    double.Parse(txtX12.Text),
                    double.Parse(txtX13.Text),
                    double.Parse(txtB1.Text)
                },
                {
                    double.Parse(txtX21.Text),
                    double.Parse(txtX22.Text),
                    double.Parse(txtX23.Text),
                    double.Parse(txtB2.Text)
                },
                {
                    double.Parse(txtX31.Text),
                    double.Parse(txtX32.Text),
                    double.Parse(txtX33.Text),
                    double.Parse(txtB3.Text)
                }
                };

                // Determinar el método elegido
                string metodo = cmbMetodo.SelectedItem?.ToString() ?? "";

                double[] respuesta = null;

                if (metodo == "Gauss")
                    respuesta = solucion.EliminacionGauss(matriz);
                else if (metodo == "Gauss-Jordan")
                    respuesta = solucion.GaussJordan(matriz);
                else
                    throw new Exception("Selecciona un método válido.");

                // Mostrar resultados
                txtResultadoX1.Text = respuesta[0].ToString("F4");
                txtResultadoX2.Text = respuesta[1].ToString("F4");
                txtResultadoX3.Text = respuesta[2].ToString("F4");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los TextBox
            txtX11.Clear();
            txtX12.Clear();
            txtX13.Clear();
            txtB1.Clear();

            txtX21.Clear();
            txtX22.Clear();
            txtX23.Clear();
            txtB2.Clear();

            txtX31.Clear();
            txtX32.Clear();
            txtX33.Clear();
            txtB3.Clear();

            // Limpiar los resultados
            txtResultadoX1.Clear();
            txtResultadoX2.Clear();
            txtResultadoX3.Clear();
            // Reiniciar el ComboBox
            cmbMetodo.SelectedIndex = -1;
        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;

            // Permitir teclas de control (Backspace, Delete, flechas, etc.)
            if (char.IsControl(e.KeyChar))
                return;

            // Dígitos
            if (char.IsDigit(e.KeyChar))
                return;

            // Signo negativo: solo si es el primer carácter o va a reemplazar todo
            if (e.KeyChar == '-')
            {
                bool reemplazaTodo = tb.SelectionLength == tb.TextLength;
                if ((tb.SelectionStart == 0 && !tb.Text.Contains('-')) || reemplazaTodo)
                    return;

                e.Handled = true;
                return;
            }

            // Punto decimal: solo uno (si el seleccionado contiene el punto, se permite para reemplazar)
            if (e.KeyChar == '.')
            {
                bool seleccionContienePunto = tb.SelectionLength > 0 && tb.SelectedText.Contains(".");
                if (!tb.Text.Contains('.') || seleccionContienePunto)
                    return;

                e.Handled = true;
                return;
            }

            // Cualquier otro carácter se bloquea
            e.Handled = true;
        }
    }
}

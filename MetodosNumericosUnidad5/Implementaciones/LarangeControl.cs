using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using AsignacionesMetodosNumericos;

namespace MetodosNumericosUnidad5.Implementaciones
{
    public partial class LarangeControl : UserControl
    {
        private readonly Interpolacion _interpolacion = new();

        public LarangeControl()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyles(this);
            ConfigureGrid();
            ConfigureCombo();
        }

        public event EventHandler VolverClick;
        private void BtnVolver_Click_1(object sender, EventArgs e) => VolverClick?.Invoke(this, EventArgs.Empty);

        private void dgvLarange_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void ConfigureGrid()
        {
            if (dgvLarange.Columns.Count == 0)
            {
                dgvLarange.AutoGenerateColumns = false;
                dgvLarange.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "X", Name = "colX", Width = 80 });
                dgvLarange.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Y", Name = "colY", Width = 80 });
            }
            dgvLarange.AllowUserToAddRows = true;
            dgvLarange.ReadOnly = false;
        }

        private void ConfigureCombo()
        {
            if (cmbGradoFuncion.Items.Count == 0)
            {
                cmbGradoFuncion.Items.Add("Lineal (2 puntos)");
                cmbGradoFuncion.Items.Add("Cuadrática (3 puntos)");
                cmbGradoFuncion.Items.Add("Cúbica (4 puntos)");
            }
            cmbGradoFuncion.SelectedIndex = 0;
            LoadSamplePoints();
        }

        private void cmbGradoFuncion_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSamplePoints();
        }

        private void LoadSamplePoints()
        {
            dgvLarange.Rows.Clear();
            switch (cmbGradoFuncion.SelectedIndex)
            {
                case 0: // Lineal
                    AddPoint(3, 5.25);
                    AddPoint(5, 19.75);
                    break;
                case 1: // Cuadrática
                    AddPoint(2, 4);
                    AddPoint(3, 5.25);
                    AddPoint(5, 19.75);
                    break;
                case 2: // Cúbica
                    AddPoint(2, 4);
                    AddPoint(3, 5.25);
                    AddPoint(5, 19.75);
                    AddPoint(6, 36);
                    break;
            }
        }

        private void AddPoint(double x, double y)
        {
            dgvLarange.Rows.Add(
                x.ToString(CultureInfo.InvariantCulture),
                y.ToString(CultureInfo.InvariantCulture));
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblResultado.Text = string.Empty;

            if (!double.TryParse(txtFX.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out double xEval))
            {
                MessageBox.Show("Ingrese un valor numérico válido para X a evaluar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int requiredPoints = cmbGradoFuncion.SelectedIndex switch
            {
                0 => 2,
                1 => 3,
                2 => 4,
                _ => 2
            };

            var parsed = ParseGridPoints();
            if (parsed.pointCount < requiredPoints)
            {
                MessageBox.Show($"Se requieren al menos {requiredPoints} puntos válidos.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Solo usar la cantidad necesaria (los primeros n puntos válidos)
            int m = requiredPoints;
            var puntosArray = new double[m, 2];
            for (int i = 0; i < m; i++)
            {
                puntosArray[i, 0] = parsed.points[i].X;
                puntosArray[i, 1] = parsed.points[i].Y;
            }

            // Validar X duplicadas
            if (parsed.points.Take(m).GroupBy(p => p.X).Any(g => g.Count() > 1))
            {
                MessageBox.Show("Hay valores de X duplicados. Modifique los puntos.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // El parámetro n en tu algoritmo es el índice máximo (m - 1)
            double result;
            try
            {
                result = _interpolacion.interpolacionLagrange(puntosArray, m - 1, xEval);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblResultado.Text = $"f({xEval.ToString(CultureInfo.InvariantCulture)}) = {result.ToString("G15", CultureInfo.InvariantCulture)}";
        }

        private (int pointCount, (double X, double Y)[] points) ParseGridPoints()
        {
            var list = dgvLarange.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Select(r =>
                {
                    var xObj = r.Cells["colX"].Value;
                    var yObj = r.Cells["colY"].Value;
                    if (xObj == null || yObj == null) return (ok: false, X: 0.0, Y: 0.0);

                    bool okX = double.TryParse(xObj.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out double x);
                    bool okY = double.TryParse(yObj.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out double y);
                    return (ok: okX && okY, X: x, Y: y);
                })
                .Where(t => t.ok)
                .Select(t => (t.X, t.Y))
                .ToArray();

            return (list.Length, list);
        }
    }
}

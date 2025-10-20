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
using System.Reflection;
using System.Globalization;

namespace MetodosNumericos_Unidad2.Meotodo_Gauss_Seidel
{
    public partial class GaussSeidelControl : UserControl
    {
        public GaussSeidelControl()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyles(this);

            // Ensure scrolling works even after CustomUI styles
            ConfigureGridForScrolling();

            // Reasonable defaults for size
            if (numericUpDown1.Minimum < 2) numericUpDown1.Minimum = 2;
            if (numericUpDown1.Maximum < 2) numericUpDown1.Maximum = 40;
            if (numericUpDown1.Value < 2) numericUpDown1.Value = 3;

            // Build the default augmented matrix immediately for editing
            InitializeOrRebuildAugmentedMatrix();

            // Wire events
            btnCalcular.Click -= btnCalcular_Click;
            btnCalcular.Click += btnCalcular_Click;

            numericUpDown1.ValueChanged -= numericUpDown1_ValueChanged;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
        }

        public event EventHandler VolverClick;
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            VolverClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpia el error
            txtEA.Clear();

            // Restablece el tamaño (ajustado a los límites del NumericUpDown)
            int defaultN = 3;
            var bounded = Math.Min(Math.Max(defaultN, (int)numericUpDown1.Minimum), (int)numericUpDown1.Maximum);
            if (numericUpDown1.Value != bounded)
                numericUpDown1.Value = bounded;

            // Vuelve a mostrar la matriz aumentada editable con valores por defecto
            InitializeOrRebuildAugmentedMatrix();

            // Asegura el scroll y tamaño de columnas (útil si el estilo global las cambia)
            ConfigureGridForScrolling();
            ApplyColumnSizing();
        }
        

        private void NUDGaussSeidel_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            InitializeOrRebuildAugmentedMatrix();
        }

        // Botón Calcular: lee la matriz del DGV (si existe), aplica Gauss-Seidel y muestra la tabla de iteraciones
        private void btnCalcular_Click(object? sender, EventArgs e)
        {
            try
            {
                int n = (int)numericUpDown1.Value;
                if (n < 2 || n > 40)
                {
                    MessageBox.Show("Matrix size must be between 2 and 40.", "Invalid size",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(txtEA.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out double eaMax))
                {
                    MessageBox.Show("Enter a valid absolute error (%).", "Invalid input",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Try to read the augmented matrix from the current grid
                if (!TryReadAugmentedMatrixFromGrid(out var A, out var msg))
                {
                    // If the grid currently shows iterations or is empty, fallback to default and inform the user
                    A = ConstruirMatrizAumentadaPorDefectoArray(n);
                }

                // Ejecutar Gauss-Seidel
                var gs = new Gauss_Seidel();
                var historial = gs.MetodoGaussSeidel(A, eaMax);

                // Armar tabla de iteraciones: x1..xn, εa1..εan
                var tablaIter = CrearTablaIteraciones(historial, n, incluirFilaInicial: true);

                // Cargar en el DGV (results view)
                dgvGaussSeidel.DataSource = null;
                dgvGaussSeidel.ReadOnly = true;
                dgvGaussSeidel.AllowUserToAddRows = false;
                dgvGaussSeidel.AllowUserToDeleteRows = false;
                dgvGaussSeidel.RowHeadersVisible = false;
                dgvGaussSeidel.DataSource = tablaIter;

                foreach (DataGridViewColumn col in dgvGaussSeidel.Columns)
                {
                    col.DefaultCellStyle.Format = "F4";
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                // Apply scroll-friendly layout after binding
                ConfigureGridForScrolling();
                ApplyColumnSizing();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error running Gauss-Seidel: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Build or rebuild the editable augmented matrix based on current size
        private void InitializeOrRebuildAugmentedMatrix()
        {
            int n = (int)numericUpDown1.Value;
            if (n < 2) return;

            var table = BuildDefaultAugmentedDataTable(n);

            dgvGaussSeidel.DataSource = null;
            dgvGaussSeidel.ReadOnly = false; // editable so user can change coefficients
            dgvGaussSeidel.AllowUserToAddRows = false;
            dgvGaussSeidel.AllowUserToDeleteRows = false;
            dgvGaussSeidel.RowHeadersVisible = true;
            dgvGaussSeidel.DataSource = table;

            // Set row headers 1..n
            for (int i = 0; i < dgvGaussSeidel.Rows.Count; i++)
                dgvGaussSeidel.Rows[i].HeaderCell.Value = (i + 1).ToString();

            foreach (DataGridViewColumn col in dgvGaussSeidel.Columns)
            {
                col.DefaultCellStyle.Format = "F4";
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Differentiate RHS visually
            var colB = dgvGaussSeidel.Columns["b"];
            if (colB != null)
            {
                colB.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
                colB.HeaderCell.Style.Font = new Font(dgvGaussSeidel.Font, FontStyle.Bold);
            }

            ConfigureGridForScrolling();
            ApplyColumnSizing();
        }

        // Create editable default augmented matrix as DataTable (n x (n+1))
        private DataTable BuildDefaultAugmentedDataTable(int n)
        {
            var dt = new DataTable();

            for (int j = 0; j < n; j++)
                dt.Columns.Add($"a{j + 1}", typeof(double));
            dt.Columns.Add("b", typeof(double));

            for (int i = 0; i < n; i++)
            {
                var row = dt.NewRow();
                for (int j = 0; j < n; j++)
                    row[j] = CoeficientePorDefecto(i, j);
                row[n] = 1.0; // RHS
                dt.Rows.Add(row);
            }

            return dt;
        }

        // Try to read an augmented matrix A|b from the current grid
        private bool TryReadAugmentedMatrixFromGrid(out double[,] a, out string message)
        {
            a = null!;
            message = string.Empty;

            if (dgvGaussSeidel.DataSource is not DataTable dt)
            {
                message = "Grid has no data.";
                return false;
            }

            int n = (int)numericUpDown1.Value;
            if (dt.Columns.Count != n + 1 || dt.Rows.Count != n)
            {
                message = "Grid does not contain an n x (n+1) augmented matrix.";
                return false;
            }

            // Validate that columns are a1..an and b
            for (int j = 0; j < n; j++)
            {
                if (!string.Equals(dt.Columns[j].ColumnName, $"a{j + 1}", StringComparison.OrdinalIgnoreCase))
                {
                    message = "Grid columns do not match a1..an,b.";
                    return false;
                }
            }
            if (!string.Equals(dt.Columns[n].ColumnName, "b", StringComparison.OrdinalIgnoreCase))
            {
                message = "Grid must have a last column named 'b'.";
                return false;
            }

            a = new double[n, n + 1];
            for (int i = 0; i < n; i++)
            {
                var dr = dt.Rows[i];
                for (int j = 0; j <= n; j++)
                {
                    if (!double.TryParse(Convert.ToString(dr[j], CultureInfo.InvariantCulture),
                        NumberStyles.Float, CultureInfo.InvariantCulture, out var val))
                    {
                        message = $"Non-numeric value at row {i + 1}, column {j + 1}.";
                        return false;
                    }
                    a[i, j] = val;
                }
            }

            return true;
        }

        // Enable scrollbars and disable Fill autosizing so horizontal scrolling appears
        private void ConfigureGridForScrolling()
        {
            dgvGaussSeidel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvGaussSeidel.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvGaussSeidel.ScrollBars = ScrollBars.Both; // horizontal + vertical
            dgvGaussSeidel.AllowUserToResizeColumns = true;
            dgvGaussSeidel.AllowUserToResizeRows = false;
            dgvGaussSeidel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Smoother scrolling for large tables
            typeof(DataGridView).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
                ?.SetValue(dgvGaussSeidel, true);
        }

        // Give every column a readable width so horizontal scrollbar engages
        private void ApplyColumnSizing()
        {
            const int defaultWidth = 90;   // readable for "x1" and "εa1" values with F4 format
            const int minWidth = 70;

            foreach (DataGridViewColumn c in dgvGaussSeidel.Columns)
            {
                c.MinimumWidth = minWidth;
                c.Width = defaultWidth;
            }
        }

        // Tabla de iteraciones con columnas dinámicas: x1..xn, εa1..εan
        private static DataTable CrearTablaIteraciones(
            List<Iteraciones_GaussSeidel> historial, int n, bool incluirFilaInicial)
        {
            var dt = new DataTable();

            // Columnas de solución
            for (int j = 0; j < n; j++)
                dt.Columns.Add($"x{j + 1}", typeof(double));

            // Columnas de error aproximado por componente
            for (int j = 0; j < n; j++)
                dt.Columns.Add($"εa{j + 1}", typeof(double));

            // Fila inicial opcional para visual como en el ejemplo
            if (incluirFilaInicial)
            {
                var row0 = dt.NewRow();
                for (int j = 0; j < n; j++) row0[j] = 0.0;
                for (int j = 0; j < n; j++) row0[n + j] = 0.0;
                dt.Rows.Add(row0);
            }

            foreach (var it in historial)
            {
                var row = dt.NewRow();

                for (int j = 0; j < n; j++)
                    row[j] = (it.ValoresSolucion != null && j < it.ValoresSolucion.Length) ? it.ValoresSolucion[j] : 0.0;

                for (int j = 0; j < n; j++)
                    row[n + j] = (it.ErroresAproximados != null && j < it.ErroresAproximados.Length) ? it.ErroresAproximados[j] : 0.0;

                dt.Rows.Add(row);
            }       

            return dt;
        }

        // Construye un sistema diagonalmente dominante (A|b)
        private static double[,] ConstruirMatrizAumentadaPorDefectoArray(int n)
        {
            var a = new double[n, n + 1];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    a[i, j] = CoeficientePorDefecto(i, j);

                a[i, n] = 1.0; // RHS
            }

            return a;
        }

        private static double CoeficientePorDefecto(int i, int j)
        {
            if (i == j) return 4.0;
            if (Math.Abs(i - j) == 1) return -1.0;
            return 0.0;
        }
    }
}

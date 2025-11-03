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
using System.Windows.Forms.DataVisualization.Charting;

namespace MetodosDeRegresion
{
    public partial class MetodosControl : UserControl
    {
        public enum Metodo
        {
            Lineal,
            LinealExponencial,
            LinealMultiple,
            Polinomial
        }

        public MetodosControl()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyles(this);

            dgvRegresion.ReadOnly = false;
            dgvRegresion.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            dgvRegresion.AllowUserToAddRows = true;
            dgvRegresion.AllowUserToDeleteRows = true;
            dgvRegresion.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvRegresion.MultiSelect = false;
        }

        private void MetodosControl_Load(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                comboBox1.Items.AddRange(Enum.GetNames(typeof(Metodo)));
            }
            comboBox1.SelectedIndex = 0; // selecciona "Lineal" por defecto

            numFilas.Value = 5; // valor inicial (opcional)
            BuildGridColumns();
            EnsureRowCount(); // crea y rellena filas
        }

        private void comboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ConfigureUIForMethod();
            BuildGridColumns();
            EnsureRowCount();
            ClearChart();
        }

        private void numFilas_ValueChanged(object? sender, EventArgs e)
        {
            if (numFilas.Value > 10) numFilas.Value = 10; // safety cap
            EnsureRowCount(); // aumenta o reduce filas en el grid sin tocar los datos existentes
            ClearChart();
        }

        private void numVariables_ValueChanged(object? sender, EventArgs e)
        {
            if (GetSelectedMetodo() == Metodo.LinealMultiple)
            {
                if (numVariables.Value > 10) numVariables.Value = 10; // safety cap
                BuildGridColumns();
                EnsureRowCount();
                ClearChart();
            }
        }

        private void gradoPolinomio_ValueChanged(object? sender, EventArgs e)
        {
            if (gradoPolinomio.Value > 10) gradoPolinomio.Value = 10; // safety cap
            // Para polinomial no cambia la forma del grid (sigue siendo X,Y)
            ClearChart();
        }

        private Metodo GetSelectedMetodo()
        {
            if (Enum.TryParse<Metodo>(comboBox1.SelectedItem?.ToString() ?? string.Empty, out var m))
                return m;
            return Metodo.Lineal;
        }

        private void ConfigureUIForMethod()
        {
            var m = GetSelectedMetodo();

            switch (m)
            {
                case Metodo.Lineal:
                case Metodo.LinealExponencial:
                    numVariables.Enabled = false;
                    gradoPolinomio.Enabled = false;
                    break;

                case Metodo.LinealMultiple:
                    numVariables.Enabled = true;
                    gradoPolinomio.Enabled = false;
                    break;

                case Metodo.Polinomial:
                    numVariables.Enabled = false;
                    gradoPolinomio.Enabled = true; // cap ya en 10
                    break;
            }
        }

        private void BuildGridColumns()
        {
            dgvRegresion.Columns.Clear();

            var m = GetSelectedMetodo();
            int xCount = (m == Metodo.LinealMultiple) ? (int)numVariables.Value : 1;

            for (int j = 0; j < xCount; j++)
            {
                var col = new DataGridViewTextBoxColumn
                {
                    Name = (xCount == 1 && m != Metodo.LinealMultiple) ? "X" : $"X{j + 1}",
                    HeaderText = (xCount == 1 && m != Metodo.LinealMultiple) ? "X" : $"X{j + 1}",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };
                dgvRegresion.Columns.Add(col);
            }

            var yCol = new DataGridViewTextBoxColumn
            {
                Name = "Y",
                HeaderText = "Y",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dgvRegresion.Columns.Add(yCol);
        }

        private void EnsureRowCount()
        {
            int n = (int)numFilas.Value;
            int cols = dgvRegresion.Columns.Count;
            if (cols == 0) return;

            Random rnd = new Random();

            // Ajustar filas
            dgvRegresion.RowCount = n;

            // Rellenar celdas vacías con valores aleatorios (entre 0 y 10)
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    var cell = dgvRegresion.Rows[i].Cells[j];
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        double val = Math.Round(rnd.NextDouble() * 10, 2);
                        cell.Value = val;
                    }
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e) { }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRegresion.Columns.Count < 2 || dgvRegresion.Rows.Count == 0)
                {
                    MessageBox.Show("Configura y llena la tabla de datos primero.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var metodo = GetSelectedMetodo();

                // Construcción Y y X
                var filas = GetValidRows();
                if (filas.Count == 0)
                {
                    MessageBox.Show("La tabla no tiene filas válidas.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int columnasX = (metodo == Metodo.LinealMultiple) ? dgvRegresion.Columns.Count - 1 : 1;

                double[] y = ConstruirVectorY(filas);
                double[] xSimple = null!;
                double[,] X = null!;

                if (metodo == Metodo.Lineal || metodo == Metodo.LinealExponencial || metodo == Metodo.Polinomial)
                {
                    xSimple = ConstruirVectorXSimple(filas);
                }
                else if (metodo == Metodo.LinealMultiple)
                {
                    X = ConstruirMatrizX(filas, columnasX);
                }

                // Calcular y graficar
                ClearChart();
                var serieDatos = crtGrafica.Series.Add("Datos");
                serieDatos.ChartType = SeriesChartType.Point;
                serieDatos.Color = Color.RoyalBlue;
                serieDatos.MarkerSize = 6;

                // Datos originales: graficar contra X1 o X simple
                if (metodo == Metodo.LinealMultiple)
                {
                    for (int i = 0; i < filas.Count; i++)
                        serieDatos.Points.AddXY(Convert.ToDouble(filas[i].Cells[0].Value), y[i]);
                }
                else
                {
                    for (int i = 0; i < filas.Count; i++)
                        serieDatos.Points.AddXY(xSimple[i], y[i]);
                }

                var serieReg = crtGrafica.Series.Add("Regresión");
                serieReg.ChartType = SeriesChartType.Line;
                serieReg.Color = Color.Crimson;
                serieReg.BorderWidth = 2;

                string titulo = "";

                switch (metodo)
                {
                    case Metodo.Lineal:
                        var (a, b) = LinealSimple(xSimple, y);
                        titulo = $"y = {a:F4} + {b:F4}·x";
                        // Graficar línea sobre x ordenado
                        foreach (var (xs, ys) in PuntosAjusteOrdenados(xSimple, (xx) => a + b * xx))
                            serieReg.Points.AddXY(xs, ys);
                        break;

                    case Metodo.LinealExponencial:
                        var (ae, be) = LinealExponencial(xSimple, y);
                        titulo = $"y = {ae:F4} · e^({be:F4}·x)";
                        foreach (var (xs, ys) in PuntosAjusteOrdenados(xSimple, (xx) => ae * Math.Exp(be * xx)))
                            serieReg.Points.AddXY(xs, ys);
                        break;

                    case Metodo.Polinomial:
                        int grado = (int)gradoPolinomio.Value;
                        var coeffs = Polinomial(xSimple, y, grado);
                        titulo = "y = " + FormatPolinomio(coeffs);
                        foreach (var (xs, ys) in PuntosAjusteOrdenados(xSimple, (xx) => EvalPoly(coeffs, xx)))
                            serieReg.Points.AddXY(xs, ys);
                        break;

                    case Metodo.LinealMultiple:
                        var beta = LinealMultiple(X, y); // beta[0] = intercepto
                        titulo = "y = " + string.Join(" + ", beta.Select((c, i) => i == 0 ? $"{c:F4}" : $"{c:F4}·x{i}"));
                        // Graficar contra la primera variable X1 (representación 2D)
                        var xs1 = new double[filas.Count];
                        for (int i = 0; i < filas.Count; i++)
                            xs1[i] = Convert.ToDouble(filas[i].Cells[0].Value);

                        foreach (var (xs, ys) in PuntosAjusteOrdenados(xs1, (xx) =>
                        {
                            // Encontrar y estimado para el punto con X1=xx más cercano de los datos
                            // o usar el vector X original para ese i (trazamos sobre los puntos reales)
                            // Aquí estimamos con los X originales en el orden de xs1 ordenado:
                            // buscamos índices ordenados y usamos X completo por ese índice.
                            return 0.0; // placeholder, reemplazado abajo
                        })) { /* reemplazado abajo */ }

                        // Construir pares (x1,yest) con los X originales
                        var indicesOrden = Enumerable.Range(0, xs1.Length)
                                                     .OrderBy(i => xs1[i])
                                                     .ToArray();
                        foreach (var idx in indicesOrden)
                        {
                            double yest = beta[0];
                            for (int j = 0; j < X.GetLength(1); j++)
                                yest += beta[j + 1] * X[idx, j];
                            serieReg.Points.AddXY(xs1[idx], yest);
                        }
                        break;
                }

                crtGrafica.Titles.Clear();
                crtGrafica.Titles.Add(titulo);
            }
            catch (FormatException)
            {
                MessageBox.Show("Todos los valores de la tabla deben ser números válidos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el cálculo: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvRegresion.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                    cell.Value = null;

            ClearChart();
        }

        public event EventHandler VolverClick;
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            VolverClick?.Invoke(this, EventArgs.Empty);
        }

        private void label5_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        // ------------- Utilidades de lectura de grid -------------
        private List<DataGridViewRow> GetValidRows()
        {
            return dgvRegresion.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .ToList();
        }

        private double[] ConstruirVectorY(List<DataGridViewRow> filas)
        {
            int colY = dgvRegresion.Columns.Count - 1;
            var y = new double[filas.Count];
            for (int i = 0; i < filas.Count; i++)
            {
                var v = filas[i].Cells[colY].Value;
                if (v == null || string.IsNullOrWhiteSpace(v.ToString()))
                    throw new Exception($"Celda vacía en fila {i + 1}, columna Y");
                y[i] = Convert.ToDouble(v);
            }
            return y;
        }

        private double[] ConstruirVectorXSimple(List<DataGridViewRow> filas)
        {
            var x = new double[filas.Count];
            for (int i = 0; i < filas.Count; i++)
            {
                var v = filas[i].Cells[0].Value;
                if (v == null || string.IsNullOrWhiteSpace(v.ToString()))
                    throw new Exception($"Celda vacía en fila {i + 1}, columna X");
                x[i] = Convert.ToDouble(v);
            }
            return x;
        }

        private double[,] ConstruirMatrizX(List<DataGridViewRow> filas, int columnasSinY)
        {
            var X = new double[filas.Count, columnasSinY];
            for (int i = 0; i < filas.Count; i++)
            {
                for (int j = 0; j < columnasSinY; j++)
                {
                    var v = filas[i].Cells[j].Value;
                    if (v == null || string.IsNullOrWhiteSpace(v.ToString()))
                        throw new Exception($"Celda vacía en fila {i + 1}, columna X{j + 1}");
                    X[i, j] = Convert.ToDouble(v);
                }
            }
            return X;
        }

        private void ClearChart()
        {
            crtGrafica.Series.Clear();
            crtGrafica.Titles.Clear();
        }

        // ------------- Algoritmos de regresión -------------
        // y = a + b x
        private static (double a, double b) LinealSimple(double[] x, double[] y)
        {
            if (x.Length != y.Length || x.Length == 0)
                throw new ArgumentException("Dimensiones inválidas para Lineal Simple.");

            int n = x.Length;
            double sx = x.Sum();
            double sy = y.Sum();
            double sxx = 0.0, sxy = 0.0;
            for (int i = 0; i < n; i++)
            {
                sxx += x[i] * x[i];
                sxy += x[i] * y[i];
            }

            double den = n * sxx - sx * sx;
            if (Math.Abs(den) < 1e-12) throw new Exception("Denominador cero (datos degenerados).");

            double b = (n * sxy - sx * sy) / den;
            double a = (sy - b * sx) / n;
            return (a, b);
        }

        // y = a * exp(b x)  => ln y = ln a + b x
        private static (double a, double b) LinealExponencial(double[] x, double[] y)
        {
            if (x.Length != y.Length || x.Length == 0)
                throw new ArgumentException("Dimensiones inválidas para Lineal Exponencial.");

            // validar y > 0
            if (y.Any(v => v <= 0.0))
                throw new Exception("Para regresión exponencial todos los valores de Y deben ser > 0.");

            double[] ly = y.Select(v => Math.Log(v)).ToArray();
            var (la, b) = LinealSimple(x, ly);
            double a = Math.Exp(la);
            return (a, b);
        }

        // y = beta0 + beta1*x1 + ... + betap*xp
        private static double[] LinealMultiple(double[,] X, double[] y)
        {
            int m = X.GetLength(0);
            int p = X.GetLength(1);
            if (y.Length != m) throw new ArgumentException("Dimensiones inválidas para Lineal Multiple.");

            // Diseñar matriz con intercepto
            var Z = new double[m, p + 1];
            for (int i = 0; i < m; i++)
            {
                Z[i, 0] = 1.0;
                for (int j = 0; j < p; j++)
                    Z[i, j + 1] = X[i, j];
            }

            return ResolverMinimosCuadrados(Z, y); // devuelve beta tamaño p+1
        }

        // Polinomial grado d: y = c0 + c1 x + ... + cd x^d
        private static double[] Polinomial(double[] x, double[] y, int grado)
        {
            if (x.Length != y.Length || x.Length == 0)
                throw new ArgumentException("Dimensiones inválidas para Polinomial.");
            if (grado < 0) throw new ArgumentException("Grado inválido.");

            int m = x.Length;
            int p = grado + 1;

            var Z = new double[m, p];
            for (int i = 0; i < m; i++)
            {
                double val = 1.0;
                for (int j = 0; j < p; j++)
                {
                    Z[i, j] = val;   // x^j
                    val *= x[i];
                }
            }

            return ResolverMinimosCuadrados(Z, y); // c0..cd
        }

        // ------------- Utilidades matemáticas -------------
        private static double EvalPoly(double[] c, double x)
        {
            // Horner
            double acc = 0.0;
            for (int i = c.Length - 1; i >= 0; i--)
                acc = acc * x + c[i];
            return acc;
        }

        private static string FormatPolinomio(double[] c)
        {
            var parts = new List<string>();
            for (int i = 0; i < c.Length; i++)
            {
                string term = i == 0 ? $"{c[i]:F4}"
                    : i == 1 ? $"{c[i]:F4}·x"
                    : $"{c[i]:F4}·x^{i}";
                parts.Add(term);
            }
            return string.Join(" + ", parts);
        }

        private static IEnumerable<(double x, double y)> PuntosAjusteOrdenados(double[] x, Func<double, double> f)
        {
            // generar línea suave entre min/max con 100 puntos si hay rango,
            // o usar los puntos ordenados si todos los x son iguales
            double xmin = x.Min(), xmax = x.Max();
            if (Math.Abs(xmax - xmin) < 1e-12)
            {
                foreach (var xi in x.OrderBy(v => v))
                    yield return (xi, f(xi));
                yield break;
            }

            int n = Math.Clamp(100, 2, 1000);
            double dx = (xmax - xmin) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                double xi = xmin + i * dx;
                yield return (xi, f(xi));
            }
        }

        // Resuelve mínimos cuadrados via ecuaciones normales y eliminación Gaussiana con pivoteo
        private static double[] ResolverMinimosCuadrados(double[,] Z, double[] y)
        {
            int m = Z.GetLength(0);
            int p = Z.GetLength(1);

            // A = Z^T Z, b = Z^T y
            var A = new double[p, p];
            var b = new double[p];

            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    double s = 0.0;
                    for (int k = 0; k < m; k++)
                        s += Z[k, i] * Z[k, j];
                    A[i, j] = s;
                }
                double sy = 0.0;
                for (int k = 0; k < m; k++)
                    sy += Z[k, i] * y[k];
                b[i] = sy;
            }

            return ResolverSistema(A, b);
        }

        // Eliminación Gaussiana con pivoteo parcial
        private static double[] ResolverSistema(double[,] A, double[] b)
        {
            int n = b.Length;
            var M = new double[n, n + 1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    M[i, j] = A[i, j];
                M[i, n] = b[i];
            }

            for (int k = 0; k < n; k++)
            {
                // pivoteo parcial
                int piv = k;
                double max = Math.Abs(M[k, k]);
                for (int i = k + 1; i < n; i++)
                {
                    double val = Math.Abs(M[i, k]);
                    if (val > max) { max = val; piv = i; }
                }
                if (Math.Abs(max) < 1e-14)
                    throw new Exception("Matriz singular o mal condicionada.");

                if (piv != k)
                    SwapRows(M, k, piv);

                // normalizar fila pivote y eliminar
                double diag = M[k, k];
                for (int j = k; j <= n; j++) M[k, j] /= diag;

                for (int i = 0; i < n; i++)
                {
                    if (i == k) continue;
                    double factor = M[i, k];
                    for (int j = k; j <= n; j++)
                        M[i, j] -= factor * M[k, j];
                }
            }

            var x = new double[n];
            for (int i = 0; i < n; i++)
                x[i] = M[i, n];
            return x;
        }

        private static void SwapRows(double[,] M, int r1, int r2)
        {
            int cols = M.GetLength(1);
            for (int j = 0; j < cols; j++)
            {
                (M[r1, j], M[r2, j]) = (M[r2, j], M[r1, j]);
            }
        }
    }
}

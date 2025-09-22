using System.Drawing;//sirve para cambiar el color de fondo de la ventana
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Security.Cryptography.Xml;
using AsignacionesMetodosNumericos.Asignacion02TabulacionFunciones;


namespace AsignacionesMetodosNumericos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            Borde();
            CustomUI.LoadDefaultStyles(this);




        }

        private void Borde()
        {
            Color robleOscuro = Color.FromArgb(101, 67, 33); // tono marrón madera
            this.Paint += (s, e) =>
            {
                int grosor = 18;
                ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                    robleOscuro, grosor, ButtonBorderStyle.Solid,
                    robleOscuro, grosor, ButtonBorderStyle.Solid,
                    robleOscuro, grosor, ButtonBorderStyle.Solid,
                    robleOscuro, grosor, ButtonBorderStyle.Solid);
            };


        }
        private void MostrarEnPanel(UserControl control)
        {
            PanelContenedor.Controls.Clear();
            control.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(control);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var control = new TabularFuncionesControl();
            control.VolverClick += (s, e) =>
            {
                PanelContenedor.Controls.Clear();
                PanelContenedor.Visible = false;
            };
            MostrarEnPanel(control);
            PanelContenedor.Visible = true;

        }

        private void PanelAsignacion2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void someEvent_Handler(object sender, EventArgs e)
        {
            var control = new TabularFuncionesControl();
            control.VolverClick += (s, e) =>
            {
                PanelContenedor.Controls.Clear();
                PanelContenedor.Visible = false;
            };
            MostrarEnPanel(control);
        }

        private void btnErrorAbsolutoRelativo_Click(object sender, EventArgs e)
        {
            var control = new Error_Absoluto.ErrorAbsRelControl();
            control.VolverClick += (s, e) =>
            {
                PanelContenedor.Controls.Clear();
                PanelContenedor.Visible = false;
            };
            MostrarEnPanel(control);
            PanelContenedor.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var control = new RaicesFunciones.implementaciones.EntradaMetodosControl();
            control.VolverClick += (s, e) =>
            {
                PanelContenedor.Controls.Clear();
                PanelContenedor.Visible = false;
            };
            MostrarEnPanel(control);
            PanelContenedor.Visible = true;
        }

        private void btnNewtonRaphson_Click(object sender, EventArgs e)
        {
            var control = new Newton_Raphson.NewtonRaphsonControl();
            control.VolverClick += (s, e) =>
            {
                if (PanelContenedor != null && !PanelContenedor.IsDisposed)
                {
                    PanelContenedor.Controls.Clear();
                    PanelContenedor.Visible = false;
                }
            };
            MostrarEnPanel(control);
            if (PanelContenedor != null && !PanelContenedor.IsDisposed)
            {
                PanelContenedor.Visible = true;
            }
        }

        private void btnSecante_Click(object sender, EventArgs e)
        {
            var control = new Secante.SecanteControl();
            control.VolverClick += (s, e) =>
            {
                if (PanelContenedor != null && !PanelContenedor.IsDisposed)
                {
                    PanelContenedor.Controls.Clear();
                    PanelContenedor.Visible = false;
                }
            };
            MostrarEnPanel(control);
            if (PanelContenedor != null && !PanelContenedor.IsDisposed)
            {
                PanelContenedor.Visible = true;
            }
        }

        private void btnTodosLosMetodos_Click(object sender, EventArgs e)
        {
            var control = new TodasLasFunciones.TodasLasFuncionesControl();
            control.VolverClick += (s, e) =>
            {
                if (PanelContenedor != null && !PanelContenedor.IsDisposed)
                {
                    PanelContenedor.Controls.Clear();
                    PanelContenedor.Visible = false;
                }
            };
            MostrarEnPanel(control);
            if (PanelContenedor != null && !PanelContenedor.IsDisposed)
            {
                PanelContenedor.Visible = true;
            }
        }
    }
}

using AsignacionesMetodosNumericos;
using MetodosNumericos_Unidad2.Asignacion07;
using MetodosNumericos_Unidad2.Meotodo_Gauss_Seidel;

namespace MetodosNumericos_Unidad2
{
    public partial class frmMain : Form
    {
        public frmMain()
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

        private void btnAsignacion07_Click(object sender, EventArgs e)
        {
            var control = new Asignacion07Control();
            control.VolverClick += (s, e) =>
            {
                PanelContenedor.Controls.Clear();
                PanelContenedor.Visible = false;
            };
            MostrarEnPanel(control);
            PanelContenedor.Visible = true;
        }

        private void btnGaussSeidel_Click(object sender, EventArgs e)
        {
            var control = new GaussSeidelControl();
            control.VolverClick += (s, e) =>
            {
                PanelContenedor.Controls.Clear();
                PanelContenedor.Visible = false;
            };
            MostrarEnPanel(control);
            PanelContenedor.Visible = true;
        }
    }
}

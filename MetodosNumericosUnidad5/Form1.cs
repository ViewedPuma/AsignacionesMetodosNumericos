using AsignacionesMetodosNumericos;
using MetodosNumericosUnidad5.Implementaciones;

namespace MetodosNumericosUnidad5
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void btnGaussSeidel_Click(object sender, EventArgs e)
        {
            var control = new LarangeControl();
            control.VolverClick += (s, e) =>
            {
                PanelContenedor.Controls.Clear();
                PanelContenedor.Visible = false;
            };
            MostrarEnPanel(control);
            PanelContenedor.Visible = true;
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

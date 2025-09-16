using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignacionesMetodosNumericos.RaicesFunciones.implementaciones
{
    public partial class EntradaMetodosControl : UserControl
    {
        public EntradaMetodosControl()
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
        public event EventHandler VolverClick;
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            VolverClick?.Invoke(this, EventArgs.Empty);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //Boton Regla Falsa
        private void button1_Click(object sender, EventArgs e)
        {
            var control = new MetodoReglaFalsaControl();
            control.VolverClick += (s, ev) =>
            {
                // Aquí puedes notificar al contenedor principal que debe mostrar el menú anterior
                VolverClick?.Invoke(this, EventArgs.Empty);
            };
            this.Controls.Clear();
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);



        }
        //Boton Biseccion
        private void btnBiseccion_Click(object sender, EventArgs e)
        {
            var control = new MetodoBiseccionControl();
            control.VolverClick += (s, ev) =>
            {
                // Aquí puedes notificar al contenedor principal que debe mostrar el menú anterior
                VolverClick?.Invoke(this, EventArgs.Empty);
            };
            this.Controls.Clear();
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);
        }
    }
}

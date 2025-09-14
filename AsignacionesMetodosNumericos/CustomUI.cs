using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AsignacionesMetodosNumericos
{
    public static class CustomUI
    {
        //este metodo sirve para customizar todos los controles de un formulario de una, ya que con el foreach los cambios que aplicaran a todos los elementos de este tipo
        public static void LoadDefaultStyles(Control control)
        {
            // Carga la fuente una sola vez
            PrivateFontCollection fuentes = new PrivateFontCollection();
            fuentes.AddFontFile("Resources/fonts/ttf/Jaro-Regular.ttf");

            Font fuenteChica = new Font(fuentes.Families[0], 24);
            Font fuenteMediana = new Font(fuentes.Families[0], 48);
            Font fuenteGrande = new Font(fuentes.Families[0], 72);



            // Aplica estilos a todos los controles, incluyendo los anidados
            ApplyStyles(control.Controls, fuenteChica, fuenteMediana, fuenteGrande);


        }

        public static void LoadDefaultStyles(Form form)
        {
            LoadDefaultStyles((Control)form);
        }
        private static void ApplyStyles(Control.ControlCollection controls, Font fuenteChica, Font fuenteMediana, Font fuenteGrande)
        {
            foreach (Control control in controls)
            {
                if (control is Label label)
                {
                    label.Font = fuenteMediana;
                    label.ForeColor = Color.White;
                    RedondearLabel(label, 20);
                }
                else if (control is Button button)
                {
                    button.Font = fuenteChica;
                    button.BackColor = Color.FromArgb(6, 60, 70);
                    button.ForeColor = Color.White;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    //button.Size = new Size(207, 138);
                    RedondearBoton(button, 20);
                    button.Padding = new Padding(10);
                    button.Margin = new Padding(5);
                    button.Cursor = Cursors.Hand;
                    button.MouseEnter += (s, e) => { button.BackColor = Color.FromArgb(255, 183, 3); };
                    button.MouseLeave += (s, e) => { button.BackColor = Color.FromArgb(6, 60, 70); };
                }
                else if (control is TextBox textBox)
                {
                    textBox.Font = fuenteChica;
                    textBox.BackColor = Color.FromArgb(30, 30, 30);
                    textBox.ForeColor = Color.White;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is Panel panel)
                {
                    panel.BackColor = Color.FromArgb(16, 48, 54);
                }
                else if(control is DataGridView dataGridView)
                {
                    dataGridView.Font = fuenteChica;
                    dataGridView.BackgroundColor = Color.FromArgb(16, 48, 54);
                    //color del texto
                    dataGridView.ForeColor = Color.FromArgb(255, 255, 255);
                    //sin borde
                    dataGridView.BorderStyle = BorderStyle.None;
                    //Desactiva los estilos visuales predeterminados de Windows para los encabezados
                    dataGridView.EnableHeadersVisualStyles = false;

                    dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(6, 60, 70);
                    dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(6, 60, 70);
                    dataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                    dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(16, 48, 54);
                    //Muestra solo lineas horizontales entre las celdas
                    dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    //Establece el color de las líneas de la cuadrícula
                    dataGridView.GridColor = Color.FromArgb(6, 60, 70);

                    dataGridView.RowTemplate.Height = 40;
                    //Selecciona toda la fila al hacer clic en una celda
                    dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    //Ayuda a que todas las columnas se ajusten al tamaño del DataGridView
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    //Ajusta el ancho de cada columna segun el contenido que tenga
                    //dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;



                    dataGridView.MultiSelect = false;
                    dataGridView.ReadOnly = true;
                    dataGridView.AllowUserToAddRows = false;
                    dataGridView.AllowUserToDeleteRows = false;
                    dataGridView.AllowUserToResizeRows = false;
                }

                // Aplica estilos a controles hijos
                if (control.HasChildren)
                {
                    ApplyStyles(control.Controls, fuenteChica, fuenteMediana, fuenteGrande);
                }
            }
        }

        public static void RedondearBoton(Button boton, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, boton.Width, boton.Height);
            path.AddArc(rect.X, rect.Y, radio, radio, 180, 90); // Esquina superior izquierda
            path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90); // Superior derecha
            path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90); // Inferior derecha
            path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90); // Inferior izquierda
            path.CloseFigure();

            boton.Region = new Region(path);


        }

        public static void RedondearLabel(Label label, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, label.Width, label.Height);
            path.AddArc(rect.X, rect.Y, radio, radio, 180, 90); // Esquina superior izquierda
            path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90); // Superior derecha
            path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90); // Inferior derecha
            path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90); // Inferior izquierda
            path.CloseFigure();

            label.Region = new Region(path);


        }


    }
}



namespace AsignacionesMetodosNumericos
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            label1 = new Label();
            btnErrorAbsolutoRelativo = new Button();
            btnRaicesDeEcuaciones = new Button();
            btnNewtonRaphson = new Button();
            btnSecante = new Button();
            btnTodosLosMetodos = new Button();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            btnAsignacion02 = new Button();
            PanelContenedor = new Panel();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(16, 48, 54);
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 42);
            label1.Name = "label1";
            label1.Size = new Size(1048, 90);
            label1.TabIndex = 0;
            label1.Text = "Metodos Numericos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // btnErrorAbsolutoRelativo
            // 
            btnErrorAbsolutoRelativo.BackColor = Color.FromArgb(16, 48, 54);
            btnErrorAbsolutoRelativo.Location = new Point(416, 245);
            btnErrorAbsolutoRelativo.Name = "btnErrorAbsolutoRelativo";
            btnErrorAbsolutoRelativo.Size = new Size(207, 138);
            btnErrorAbsolutoRelativo.TabIndex = 2;
            btnErrorAbsolutoRelativo.Text = "Error A y R";
            btnErrorAbsolutoRelativo.UseVisualStyleBackColor = false;
            btnErrorAbsolutoRelativo.Visible = false;
            btnErrorAbsolutoRelativo.Click += btnErrorAbsolutoRelativo_Click;
            // 
            // btnRaicesDeEcuaciones
            // 
            btnRaicesDeEcuaciones.BackColor = Color.FromArgb(16, 48, 54);
            btnRaicesDeEcuaciones.Location = new Point(667, 245);
            btnRaicesDeEcuaciones.Name = "btnRaicesDeEcuaciones";
            btnRaicesDeEcuaciones.Size = new Size(207, 138);
            btnRaicesDeEcuaciones.TabIndex = 3;
            btnRaicesDeEcuaciones.Text = "Raices de Ecuaciones";
            btnRaicesDeEcuaciones.UseVisualStyleBackColor = false;
            btnRaicesDeEcuaciones.Visible = false;
            btnRaicesDeEcuaciones.Click += button3_Click;
            // 
            // btnNewtonRaphson
            // 
            btnNewtonRaphson.BackColor = Color.FromArgb(16, 48, 54);
            btnNewtonRaphson.Location = new Point(916, 245);
            btnNewtonRaphson.Name = "btnNewtonRaphson";
            btnNewtonRaphson.Size = new Size(207, 138);
            btnNewtonRaphson.TabIndex = 4;
            btnNewtonRaphson.Text = "NewtonRaphson";
            btnNewtonRaphson.UseVisualStyleBackColor = false;
            btnNewtonRaphson.Visible = false;
            btnNewtonRaphson.Click += btnNewtonRaphson_Click;
            // 
            // btnSecante
            // 
            btnSecante.BackColor = Color.FromArgb(16, 48, 54);
            btnSecante.Location = new Point(160, 444);
            btnSecante.Name = "btnSecante";
            btnSecante.Size = new Size(207, 138);
            btnSecante.TabIndex = 5;
            btnSecante.Text = "Secante";
            btnSecante.UseVisualStyleBackColor = false;
            btnSecante.Visible = false;
            btnSecante.Click += btnSecante_Click;
            // 
            // btnTodosLosMetodos
            // 
            btnTodosLosMetodos.BackColor = Color.FromArgb(16, 48, 54);
            btnTodosLosMetodos.Location = new Point(416, 444);
            btnTodosLosMetodos.Name = "btnTodosLosMetodos";
            btnTodosLosMetodos.Size = new Size(207, 138);
            btnTodosLosMetodos.TabIndex = 6;
            btnTodosLosMetodos.Text = "Todos los metodos";
            btnTodosLosMetodos.UseVisualStyleBackColor = false;
            btnTodosLosMetodos.Visible = false;
            btnTodosLosMetodos.Click += btnTodosLosMetodos_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.BackColor = Color.FromArgb(16, 48, 54);
            label2.Location = new Point(119, 160);
            label2.Name = "label2";
            label2.Size = new Size(1048, 507);
            label2.TabIndex = 9;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(160, 773);
            label3.Name = "label3";
            label3.Size = new Size(207, 23);
            label3.TabIndex = 10;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(172, 109, 54);
            label5.Location = new Point(986, 704);
            label5.Name = "label5";
            label5.Size = new Size(197, 92);
            label5.TabIndex = 12;
            // 
            // btnAsignacion02
            // 
            btnAsignacion02.BackColor = Color.FromArgb(16, 48, 54);
            btnAsignacion02.Location = new Point(160, 245);
            btnAsignacion02.Name = "btnAsignacion02";
            btnAsignacion02.Size = new Size(207, 138);
            btnAsignacion02.TabIndex = 13;
            btnAsignacion02.Text = "Asignacion02";
            btnAsignacion02.UseVisualStyleBackColor = false;
            btnAsignacion02.Visible = false;
            btnAsignacion02.Click += button1_Click_1;
            // 
            // PanelContenedor
            // 
            PanelContenedor.Location = new Point(1104, 685);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(79, 130);
            PanelContenedor.TabIndex = 14;
            PanelContenedor.Visible = false;
            PanelContenedor.Paint += PanelAsignacion2_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(16, 48, 54);
            button2.Enabled = false;
            button2.Location = new Point(667, 444);
            button2.Name = "button2";
            button2.Size = new Size(207, 138);
            button2.TabIndex = 16;
            button2.Text = "Coming Soon";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(16, 48, 54);
            button3.Enabled = false;
            button3.Location = new Point(916, 444);
            button3.Name = "button3";
            button3.Size = new Size(207, 138);
            button3.TabIndex = 17;
            button3.Text = "Coming Soon";
            button3.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 77, 86);
            ClientSize = new Size(1262, 815);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(PanelContenedor);
            Controls.Add(btnAsignacion02);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnTodosLosMetodos);
            Controls.Add(btnSecante);
            Controls.Add(btnNewtonRaphson);
            Controls.Add(btnRaicesDeEcuaciones);
            Controls.Add(btnErrorAbsolutoRelativo);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPrincipal";
            Text = "Proyectos Metodos Numericos";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Button btnAsignacion02;
        private Button btnErrorAbsolutoRelativo;
        private Button btnRaicesDeEcuaciones;
        private Button btnNewtonRaphson;
        private Button btnSecante;
        private Button btnTodosLosMetodos;
        private Label label2;
        private Label label3;
        private Label label5;
        private Panel PanelContenedor;
        private Button button2;
        private Button button3;
    }
}

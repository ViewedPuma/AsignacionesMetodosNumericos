namespace AsignacionesMetodosNumericos.RaicesFunciones.implementaciones
{
    partial class MetodoReglaFalsaControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEjemplo = new TextBox();
            lblFuncion = new Label();
            txtFuncion = new TextBox();
            label4 = new Label();
            txtErrorAproximado = new TextBox();
            txtXfinal = new TextBox();
            txtXinicial = new TextBox();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            label2 = new Label();
            label1 = new Label();
            lblXi = new Label();
            dgvReglaFalsa = new DataGridView();
            BtnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReglaFalsa).BeginInit();
            SuspendLayout();
            // 
            // txtEjemplo
            // 
            txtEjemplo.Location = new Point(679, 174);
            txtEjemplo.Name = "txtEjemplo";
            txtEjemplo.Size = new Size(483, 23);
            txtEjemplo.TabIndex = 80;
            txtEjemplo.Text = "Ejemplo: x^2*Sqrt(Abs(Cos(x)))-5";
            // 
            // lblFuncion
            // 
            lblFuncion.AutoSize = true;
            lblFuncion.Location = new Point(679, 131);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(50, 15);
            lblFuncion.TabIndex = 79;
            lblFuncion.Tag = "chico";
            lblFuncion.Text = "Funcion";
            // 
            // txtFuncion
            // 
            txtFuncion.Location = new Point(679, 256);
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(360, 23);
            txtFuncion.TabIndex = 78;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(16, 48, 54);
            label4.Location = new Point(59, 27);
            label4.Name = "label4";
            label4.Size = new Size(925, 90);
            label4.TabIndex = 77;
            label4.Text = "Metodo Biseccion";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtErrorAproximado
            // 
            txtErrorAproximado.Location = new Point(361, 174);
            txtErrorAproximado.Name = "txtErrorAproximado";
            txtErrorAproximado.Size = new Size(199, 23);
            txtErrorAproximado.TabIndex = 76;
            // 
            // txtXfinal
            // 
            txtXfinal.Location = new Point(59, 270);
            txtXfinal.Name = "txtXfinal";
            txtXfinal.Size = new Size(199, 23);
            txtXfinal.TabIndex = 75;
            // 
            // txtXinicial
            // 
            txtXinicial.Location = new Point(59, 174);
            txtXinicial.Name = "txtXinicial";
            txtXinicial.Size = new Size(199, 23);
            txtXinicial.TabIndex = 74;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(16, 48, 54);
            btnLimpiar.Location = new Point(1045, 573);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(158, 90);
            btnLimpiar.TabIndex = 73;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(16, 48, 54);
            btnCalcular.Location = new Point(1045, 369);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(158, 90);
            btnCalcular.TabIndex = 72;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 131);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 71;
            label2.Tag = "chico";
            label2.Text = "Error Aproximado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 227);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 70;
            label1.Tag = "chico";
            label1.Text = "X final";
            // 
            // lblXi
            // 
            lblXi.AutoSize = true;
            lblXi.Location = new Point(59, 131);
            lblXi.Name = "lblXi";
            lblXi.Size = new Size(48, 15);
            lblXi.TabIndex = 69;
            lblXi.Tag = "chico";
            lblXi.Text = "X inicial";
            // 
            // dgvReglaFalsa
            // 
            dgvReglaFalsa.AllowUserToResizeColumns = false;
            dgvReglaFalsa.BackgroundColor = Color.FromArgb(16, 48, 54);
            dgvReglaFalsa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReglaFalsa.Location = new Point(59, 319);
            dgvReglaFalsa.Name = "dgvReglaFalsa";
            dgvReglaFalsa.Size = new Size(980, 469);
            dgvReglaFalsa.TabIndex = 68;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.FromArgb(16, 48, 54);
            BtnVolver.Location = new Point(1004, 27);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(158, 90);
            BtnVolver.TabIndex = 67;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click_1;
            // 
            // MetodoReglaFalsaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 77, 86);
            Controls.Add(txtEjemplo);
            Controls.Add(lblFuncion);
            Controls.Add(txtFuncion);
            Controls.Add(label4);
            Controls.Add(txtErrorAproximado);
            Controls.Add(txtXfinal);
            Controls.Add(txtXinicial);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblXi);
            Controls.Add(dgvReglaFalsa);
            Controls.Add(BtnVolver);
            Name = "MetodoReglaFalsaControl";
            Size = new Size(1262, 815);
            Load += MetodoReglaFalsaControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReglaFalsa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEjemplo;
        private Label lblFuncion;
        private TextBox txtFuncion;
        private Label label4;
        private TextBox txtErrorAproximado;
        private TextBox txtXfinal;
        private TextBox txtXinicial;
        private Button btnLimpiar;
        private Button btnCalcular;
        private Label label2;
        private Label label1;
        private Label lblXi;
        private DataGridView dgvReglaFalsa;
        private Button BtnVolver;
    }
}

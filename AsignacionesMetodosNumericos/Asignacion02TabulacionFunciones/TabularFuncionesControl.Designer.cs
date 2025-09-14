namespace AsignacionesMetodosNumericos.Asignacion02TabulacionFunciones
{
    partial class TabularFuncionesControl
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
            dgvResultados = new DataGridView();
            btnFunciones = new Button();
            BtnVolver = new Button();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblFondo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // dgvResultados
            // 
            dgvResultados.AllowUserToResizeColumns = false;
            dgvResultados.BackgroundColor = Color.FromArgb(16, 48, 54);
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(104, 157);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(874, 569);
            dgvResultados.TabIndex = 29;
            dgvResultados.CellContentClick += dgvResultados_CellContentClick;
            // 
            // btnFunciones
            // 
            btnFunciones.BackColor = Color.FromArgb(16, 48, 54);
            btnFunciones.Location = new Point(1003, 157);
            btnFunciones.Name = "btnFunciones";
            btnFunciones.Size = new Size(193, 90);
            btnFunciones.TabIndex = 28;
            btnFunciones.Text = "Funciones";
            btnFunciones.UseVisualStyleBackColor = false;
            btnFunciones.Click += button9_Click;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.FromArgb(16, 48, 54);
            BtnVolver.Location = new Point(1003, 22);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(158, 90);
            BtnVolver.TabIndex = 27;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += button1_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(172, 109, 54);
            label4.Location = new Point(1003, 701);
            label4.Name = "label4";
            label4.Size = new Size(197, 92);
            label4.TabIndex = 26;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Location = new Point(62, 579);
            label6.Name = "label6";
            label6.Size = new Size(25, 170);
            label6.TabIndex = 25;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(16, 48, 54);
            label7.Location = new Point(93, 22);
            label7.Name = "label7";
            label7.Size = new Size(904, 90);
            label7.TabIndex = 24;
            label7.Text = "Tabular Funciones";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFondo
            // 
            lblFondo.BackColor = Color.FromArgb(16, 48, 54);
            lblFondo.Location = new Point(93, 129);
            lblFondo.Name = "lblFondo";
            lblFondo.Size = new Size(904, 620);
            lblFondo.TabIndex = 23;
            // 
            // TabularFuncionesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 77, 86);
            Controls.Add(dgvResultados);
            Controls.Add(btnFunciones);
            Controls.Add(BtnVolver);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(lblFondo);
            Name = "TabularFuncionesControl";
            Size = new Size(1262, 815);
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvResultados;
        private Button btnFunciones;
        private Button BtnVolver;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label lblFondo;
    }
}

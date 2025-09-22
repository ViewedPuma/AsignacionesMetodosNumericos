namespace AsignacionesMetodosNumericos.TodasLasFunciones
{
    partial class TodasLasFuncionesControl
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
            txtValor2 = new TextBox();
            label1 = new Label();
            cmbFuncion = new ComboBox();
            lblFuncion = new Label();
            label4 = new Label();
            txtErrorAproximado = new TextBox();
            txtValor1 = new TextBox();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            label2 = new Label();
            lblXi = new Label();
            dgvTodasLasFunciones = new DataGridView();
            BtnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTodasLasFunciones).BeginInit();
            SuspendLayout();
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(59, 259);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(199, 23);
            txtValor2.TabIndex = 106;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 216);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 105;
            label1.Tag = "chico";
            label1.Text = "Valor X 2";
            // 
            // cmbFuncion
            // 
            cmbFuncion.FormattingEnabled = true;
            cmbFuncion.Items.AddRange(new object[] { "", "f(x) = x^3 - 5", "f(x) = x^2 - 2", "f(x) = e^x -3", "f(x) = cos(x) - x", "f(x) = ln(x) + x", "f(x) = 4x^3 - 6x^2 + 7x -2.3", "f(x) = x^2 sqrt |cos(x)| - 5" });
            cmbFuncion.Location = new Point(679, 213);
            cmbFuncion.Name = "cmbFuncion";
            cmbFuncion.Size = new Size(305, 23);
            cmbFuncion.TabIndex = 104;
            // 
            // lblFuncion
            // 
            lblFuncion.Location = new Point(679, 131);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(305, 47);
            lblFuncion.TabIndex = 103;
            lblFuncion.Tag = "chico";
            lblFuncion.Text = "Funcion";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(16, 48, 54);
            label4.Location = new Point(59, 27);
            label4.Name = "label4";
            label4.Size = new Size(925, 90);
            label4.TabIndex = 102;
            label4.Text = "Comparacion de Metodos";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtErrorAproximado
            // 
            txtErrorAproximado.Location = new Point(361, 213);
            txtErrorAproximado.Name = "txtErrorAproximado";
            txtErrorAproximado.Size = new Size(199, 23);
            txtErrorAproximado.TabIndex = 101;
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(59, 171);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(199, 23);
            txtValor1.TabIndex = 100;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(16, 48, 54);
            btnLimpiar.Location = new Point(1045, 573);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(158, 90);
            btnLimpiar.TabIndex = 99;
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
            btnCalcular.TabIndex = 98;
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
            label2.TabIndex = 97;
            label2.Tag = "chico";
            label2.Text = "Error Aproximado";
            // 
            // lblXi
            // 
            lblXi.AutoSize = true;
            lblXi.Location = new Point(59, 131);
            lblXi.Name = "lblXi";
            lblXi.Size = new Size(52, 15);
            lblXi.TabIndex = 96;
            lblXi.Tag = "chico";
            lblXi.Text = "Valor X 1";
            // 
            // dgvTodasLasFunciones
            // 
            dgvTodasLasFunciones.AllowUserToResizeColumns = false;
            dgvTodasLasFunciones.BackgroundColor = Color.FromArgb(16, 48, 54);
            dgvTodasLasFunciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTodasLasFunciones.Location = new Point(59, 319);
            dgvTodasLasFunciones.Name = "dgvTodasLasFunciones";
            dgvTodasLasFunciones.Size = new Size(980, 469);
            dgvTodasLasFunciones.TabIndex = 95;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.FromArgb(16, 48, 54);
            BtnVolver.Location = new Point(1004, 27);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(158, 90);
            BtnVolver.TabIndex = 94;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // TodasLasFuncionesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 77, 86);
            Controls.Add(txtValor2);
            Controls.Add(label1);
            Controls.Add(cmbFuncion);
            Controls.Add(lblFuncion);
            Controls.Add(label4);
            Controls.Add(txtErrorAproximado);
            Controls.Add(txtValor1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(lblXi);
            Controls.Add(dgvTodasLasFunciones);
            Controls.Add(BtnVolver);
            Name = "TodasLasFuncionesControl";
            Size = new Size(1262, 815);
            ((System.ComponentModel.ISupportInitialize)dgvTodasLasFunciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValor2;
        private Label label1;
        private ComboBox cmbFuncion;
        private Label lblFuncion;
        private Label label4;
        private TextBox txtErrorAproximado;
        private TextBox txtValor1;
        private Button btnLimpiar;
        private Button btnCalcular;
        private Label label2;
        private Label lblXi;
        private DataGridView dgvTodasLasFunciones;
        private Button BtnVolver;
    }
}

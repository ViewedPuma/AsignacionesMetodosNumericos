namespace AsignacionesMetodosNumericos.Secante
{
    partial class SecanteControl
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
            cmbFuncion = new ComboBox();
            lblFuncion = new Label();
            label4 = new Label();
            txtErrorAproximado = new TextBox();
            txtValor1 = new TextBox();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            label2 = new Label();
            lblXi = new Label();
            dgvSecante = new DataGridView();
            BtnVolver = new Button();
            label1 = new Label();
            txtValor2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSecante).BeginInit();
            SuspendLayout();
            // 
            // cmbFuncion
            // 
            cmbFuncion.FormattingEnabled = true;
            cmbFuncion.Items.AddRange(new object[] { "", "f(x) = x^3 - 5", "f(x) = x^2 - 2", "f(x) = e^x -3", "f(x) = cos(x) - x", "f(x) = ln(x) + x" });
            cmbFuncion.Location = new Point(679, 213);
            cmbFuncion.Name = "cmbFuncion";
            cmbFuncion.Size = new Size(305, 23);
            cmbFuncion.TabIndex = 91;
            cmbFuncion.SelectedIndexChanged += cmbFuncion_SelectedIndexChanged;
            // 
            // lblFuncion
            // 
            lblFuncion.Location = new Point(679, 131);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(305, 47);
            lblFuncion.TabIndex = 90;
            lblFuncion.Tag = "chico";
            lblFuncion.Text = "Funcion";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(16, 48, 54);
            label4.Location = new Point(59, 27);
            label4.Name = "label4";
            label4.Size = new Size(925, 90);
            label4.TabIndex = 89;
            label4.Text = "Metodo NewtonRaphson";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtErrorAproximado
            // 
            txtErrorAproximado.Location = new Point(361, 213);
            txtErrorAproximado.Name = "txtErrorAproximado";
            txtErrorAproximado.Size = new Size(199, 23);
            txtErrorAproximado.TabIndex = 88;
            txtErrorAproximado.TextChanged += txtErrorAproximado_TextChanged;
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(59, 171);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(199, 23);
            txtValor1.TabIndex = 87;
            txtValor1.TextChanged += txtValor1_TextChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(16, 48, 54);
            btnLimpiar.Location = new Point(1045, 573);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(158, 90);
            btnLimpiar.TabIndex = 86;
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
            btnCalcular.TabIndex = 85;
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
            label2.TabIndex = 84;
            label2.Tag = "chico";
            label2.Text = "Error Aproximado";
            // 
            // lblXi
            // 
            lblXi.AutoSize = true;
            lblXi.Location = new Point(59, 131);
            lblXi.Name = "lblXi";
            lblXi.Size = new Size(52, 15);
            lblXi.TabIndex = 83;
            lblXi.Tag = "chico";
            lblXi.Text = "Valor X 1";
            // 
            // dgvSecante
            // 
            dgvSecante.AllowUserToResizeColumns = false;
            dgvSecante.BackgroundColor = Color.FromArgb(16, 48, 54);
            dgvSecante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSecante.Location = new Point(59, 319);
            dgvSecante.Name = "dgvSecante";
            dgvSecante.Size = new Size(980, 469);
            dgvSecante.TabIndex = 82;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.FromArgb(16, 48, 54);
            BtnVolver.Location = new Point(1004, 27);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(158, 90);
            BtnVolver.TabIndex = 81;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 216);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 92;
            label1.Tag = "chico";
            label1.Text = "Valor X 2";
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(59, 259);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(199, 23);
            txtValor2.TabIndex = 93;
            txtValor2.TextChanged += txtValor2_TextChanged;
            // 
            // SecanteControl
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
            Controls.Add(dgvSecante);
            Controls.Add(BtnVolver);
            Name = "SecanteControl";
            Size = new Size(1262, 815);
            ((System.ComponentModel.ISupportInitialize)dgvSecante).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFuncion;
        private Label lblFuncion;
        private Label label4;
        private TextBox txtErrorAproximado;
        private TextBox txtValor1;
        private Button btnLimpiar;
        private Button btnCalcular;
        private Label label2;
        private Label lblXi;
        private DataGridView dgvSecante;
        private Button BtnVolver;
        private Label label1;
        private TextBox txtValor2;
    }
}

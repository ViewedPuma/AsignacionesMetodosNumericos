namespace AsignacionesMetodosNumericos.Newton_Raphson
{
    partial class NewtonRaphsonControl
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
            lblFuncion = new Label();
            label4 = new Label();
            txtErrorAproximado = new TextBox();
            txtXinicial = new TextBox();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            label2 = new Label();
            lblXi = new Label();
            dgvNewtonRaphson = new DataGridView();
            BtnVolver = new Button();
            cmbFuncion = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvNewtonRaphson).BeginInit();
            SuspendLayout();
            // 
            // lblFuncion
            // 
            lblFuncion.Location = new Point(679, 131);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(305, 47);
            lblFuncion.TabIndex = 79;
            lblFuncion.Tag = "chico";
            lblFuncion.Text = "Funcion";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(16, 48, 54);
            label4.Location = new Point(59, 27);
            label4.Name = "label4";
            label4.Size = new Size(925, 90);
            label4.TabIndex = 77;
            label4.Text = "Metodo NewtonRaphson";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtErrorAproximado
            // 
            txtErrorAproximado.Location = new Point(361, 213);
            txtErrorAproximado.Name = "txtErrorAproximado";
            txtErrorAproximado.Size = new Size(199, 23);
            txtErrorAproximado.TabIndex = 76;
            txtErrorAproximado.TextChanged += txtErrorAproximado_TextChanged;
            // 
            // txtXinicial
            // 
            txtXinicial.Location = new Point(59, 213);
            txtXinicial.Name = "txtXinicial";
            txtXinicial.Size = new Size(199, 23);
            txtXinicial.TabIndex = 74;
            txtXinicial.TextChanged += txtXinicial_TextChanged;
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
            // dgvNewtonRaphson
            // 
            dgvNewtonRaphson.AllowUserToResizeColumns = false;
            dgvNewtonRaphson.BackgroundColor = Color.FromArgb(16, 48, 54);
            dgvNewtonRaphson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNewtonRaphson.Location = new Point(59, 319);
            dgvNewtonRaphson.Name = "dgvNewtonRaphson";
            dgvNewtonRaphson.Size = new Size(980, 469);
            dgvNewtonRaphson.TabIndex = 68;
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
            BtnVolver.Click += BtnVolver_Click;
            // 
            // cmbFuncion
            // 
            cmbFuncion.FormattingEnabled = true;
            cmbFuncion.Items.AddRange(new object[] { "", "f(x) = x^3 - 5", "f(x) = x^2 - 2", "f(x) = e^x -3", "f(x) = cos(x) - x", "f(x) = ln(x) + x", "f(x) = 4x^3 - 6x^2 + 7x -2.3" });
            cmbFuncion.Location = new Point(679, 213);
            cmbFuncion.Name = "cmbFuncion";
            cmbFuncion.Size = new Size(305, 23);
            cmbFuncion.TabIndex = 80;
            cmbFuncion.SelectedIndexChanged += cmbFuncion_SelectedIndexChanged;
            // 
            // NewtonRaphsonControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 77, 86);
            Controls.Add(cmbFuncion);
            Controls.Add(lblFuncion);
            Controls.Add(label4);
            Controls.Add(txtErrorAproximado);
            Controls.Add(txtXinicial);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(lblXi);
            Controls.Add(dgvNewtonRaphson);
            Controls.Add(BtnVolver);
            Name = "NewtonRaphsonControl";
            Size = new Size(1262, 815);
            Load += NewtonRaphsonControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNewtonRaphson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFuncion;
        private Label label4;
        private TextBox txtErrorAproximado;
        private TextBox txtXinicial;
        private Button btnLimpiar;
        private Button btnCalcular;
        private Label label2;
        private Label lblXi;
        private DataGridView dgvNewtonRaphson;
        private Button BtnVolver;
        private ComboBox cmbFuncion;
    }
}

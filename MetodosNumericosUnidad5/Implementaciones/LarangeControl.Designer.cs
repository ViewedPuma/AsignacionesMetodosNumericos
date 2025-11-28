namespace MetodosNumericosUnidad5.Implementaciones
{
    partial class LarangeControl
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
            label4 = new Label();
            BtnVolver = new Button();
            dgvLarange = new DataGridView();
            txtFX = new TextBox();
            cmbGradoFuncion = new ComboBox();
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            lblX2 = new Label();
            lblResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLarange).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(16, 48, 54);
            label4.Location = new Point(81, 62);
            label4.Name = "label4";
            label4.Size = new Size(925, 90);
            label4.TabIndex = 125;
            label4.Text = "Interpolacion Larange";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.FromArgb(16, 48, 54);
            BtnVolver.Location = new Point(1026, 62);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(158, 90);
            BtnVolver.TabIndex = 124;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click_1;
            // 
            // dgvLarange
            // 
            dgvLarange.AllowUserToResizeColumns = false;
            dgvLarange.BackgroundColor = Color.FromArgb(16, 48, 54);
            dgvLarange.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLarange.Location = new Point(62, 433);
            dgvLarange.Name = "dgvLarange";
            dgvLarange.Size = new Size(549, 310);
            dgvLarange.TabIndex = 126;
            dgvLarange.CellContentClick += dgvLarange_CellContentClick;
            // 
            // txtFX
            // 
            txtFX.Location = new Point(81, 236);
            txtFX.Name = "txtFX";
            txtFX.Size = new Size(225, 23);
            txtFX.TabIndex = 127;
            // 
            // cmbGradoFuncion
            // 
            cmbGradoFuncion.FormattingEnabled = true;
            cmbGradoFuncion.Items.AddRange(new object[] { "Lineal", "Cuadratica", "Cubica" });
            cmbGradoFuncion.Location = new Point(506, 236);
            cmbGradoFuncion.Name = "cmbGradoFuncion";
            cmbGradoFuncion.Size = new Size(234, 23);
            cmbGradoFuncion.TabIndex = 129;
            cmbGradoFuncion.SelectedIndexChanged += cmbGradoFuncion_SelectedIndexChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(16, 48, 54);
            btnCalcular.Location = new Point(1026, 201);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(158, 90);
            btnCalcular.TabIndex = 130;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 188);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 131;
            label1.Tag = "chico";
            label1.Text = "Ingresa F(x) a calcular";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(506, 188);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 132;
            label2.Tag = "chico";
            label2.Text = "Escoje el Grado";
            // 
            // lblX2
            // 
            lblX2.AutoSize = true;
            lblX2.Location = new Point(789, 433);
            lblX2.Name = "lblX2";
            lblX2.Size = new Size(59, 15);
            lblX2.TabIndex = 138;
            lblX2.Text = "Resultado";
            // 
            // lblResultado
            // 
            lblResultado.Location = new Point(789, 537);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(355, 66);
            lblResultado.TabIndex = 140;
            lblResultado.Tag = "chico";
            lblResultado.Text = "Resultado";
            // 
            // LarangeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 77, 86);
            Controls.Add(lblResultado);
            Controls.Add(lblX2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(cmbGradoFuncion);
            Controls.Add(txtFX);
            Controls.Add(dgvLarange);
            Controls.Add(label4);
            Controls.Add(BtnVolver);
            Name = "LarangeControl";
            Size = new Size(1262, 815);
            ((System.ComponentModel.ISupportInitialize)dgvLarange).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button BtnVolver;
        private DataGridView dgvLarange;
        private TextBox txtFX;
        private ComboBox cmbGradoFuncion;
        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private Label lblX2;
        private Label lblResultado;
    }
}

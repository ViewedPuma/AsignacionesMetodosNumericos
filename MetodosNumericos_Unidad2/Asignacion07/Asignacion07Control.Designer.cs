namespace MetodosNumericos_Unidad2.Asignacion07
{
    partial class Asignacion07Control
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
            label4 = new Label();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            lblMetodo = new Label();
            BtnVolver = new Button();
            lblIngresarDatos = new Label();
            lblResultados = new Label();
            lblTipoMatriz = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtB3 = new TextBox();
            txtX33 = new TextBox();
            txtX32 = new TextBox();
            txtX31 = new TextBox();
            txtB2 = new TextBox();
            txtX23 = new TextBox();
            txtX22 = new TextBox();
            txtX21 = new TextBox();
            txtB1 = new TextBox();
            txtX13 = new TextBox();
            txtX11 = new TextBox();
            txtX12 = new TextBox();
            txtResultadoX1 = new TextBox();
            txtResultadoX2 = new TextBox();
            txtResultadoX3 = new TextBox();
            cmbMetodo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbFuncion
            // 
            cmbFuncion.Enabled = false;
            cmbFuncion.FormattingEnabled = true;
            cmbFuncion.Items.AddRange(new object[] { "", "2x2", "3x3" });
            cmbFuncion.Location = new Point(607, 202);
            cmbFuncion.Name = "cmbFuncion";
            cmbFuncion.Size = new Size(305, 23);
            cmbFuncion.TabIndex = 104;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(16, 48, 54);
            label4.Location = new Point(67, 47);
            label4.Name = "label4";
            label4.Size = new Size(925, 90);
            label4.TabIndex = 102;
            label4.Text = "Gauss/-Jordan";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(16, 48, 54);
            btnLimpiar.Location = new Point(1053, 593);
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
            btnCalcular.Location = new Point(1053, 389);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(158, 90);
            btnCalcular.TabIndex = 98;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblMetodo
            // 
            lblMetodo.AutoSize = true;
            lblMetodo.Location = new Point(67, 151);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(49, 15);
            lblMetodo.TabIndex = 96;
            lblMetodo.Tag = "chico";
            lblMetodo.Text = "Metodo";
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.FromArgb(16, 48, 54);
            BtnVolver.Location = new Point(1012, 47);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(158, 90);
            BtnVolver.TabIndex = 94;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // lblIngresarDatos
            // 
            lblIngresarDatos.AutoSize = true;
            lblIngresarDatos.Location = new Point(239, 272);
            lblIngresarDatos.Name = "lblIngresarDatos";
            lblIngresarDatos.Size = new Size(79, 15);
            lblIngresarDatos.TabIndex = 108;
            lblIngresarDatos.Tag = "chico";
            lblIngresarDatos.Text = "Insertar Datos";
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Location = new Point(755, 272);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(70, 15);
            lblResultados.TabIndex = 109;
            lblResultados.Tag = "chico";
            lblResultados.Text = "Resultados :";
            // 
            // lblTipoMatriz
            // 
            lblTipoMatriz.AutoSize = true;
            lblTipoMatriz.Location = new Point(607, 151);
            lblTipoMatriz.Name = "lblTipoMatriz";
            lblTipoMatriz.Size = new Size(83, 15);
            lblTipoMatriz.TabIndex = 110;
            lblTipoMatriz.Tag = "chico";
            lblTipoMatriz.Text = "Tipo de Matriz";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(txtB3, 3, 2);
            tableLayoutPanel1.Controls.Add(txtX33, 2, 2);
            tableLayoutPanel1.Controls.Add(txtX32, 1, 2);
            tableLayoutPanel1.Controls.Add(txtX31, 0, 2);
            tableLayoutPanel1.Controls.Add(txtB2, 3, 1);
            tableLayoutPanel1.Controls.Add(txtX23, 2, 1);
            tableLayoutPanel1.Controls.Add(txtX22, 1, 1);
            tableLayoutPanel1.Controls.Add(txtX21, 0, 1);
            tableLayoutPanel1.Controls.Add(txtB1, 3, 0);
            tableLayoutPanel1.Controls.Add(txtX13, 2, 0);
            tableLayoutPanel1.Controls.Add(txtX11, 0, 0);
            tableLayoutPanel1.Controls.Add(txtX12, 1, 0);
            tableLayoutPanel1.Location = new Point(57, 316);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(509, 481);
            tableLayoutPanel1.TabIndex = 111;
            // 
            // txtB3
            // 
            txtB3.Location = new Point(384, 323);
            txtB3.Name = "txtB3";
            txtB3.Size = new Size(122, 23);
            txtB3.TabIndex = 126;
            // 
            // txtX33
            // 
            txtX33.Location = new Point(257, 323);
            txtX33.Name = "txtX33";
            txtX33.Size = new Size(121, 23);
            txtX33.TabIndex = 125;
            // 
            // txtX32
            // 
            txtX32.Location = new Point(130, 323);
            txtX32.Name = "txtX32";
            txtX32.Size = new Size(121, 23);
            txtX32.TabIndex = 124;
            // 
            // txtX31
            // 
            txtX31.Location = new Point(3, 323);
            txtX31.Name = "txtX31";
            txtX31.Size = new Size(121, 23);
            txtX31.TabIndex = 123;
            // 
            // txtB2
            // 
            txtB2.Location = new Point(384, 163);
            txtB2.Name = "txtB2";
            txtB2.Size = new Size(122, 23);
            txtB2.TabIndex = 122;
            // 
            // txtX23
            // 
            txtX23.Location = new Point(257, 163);
            txtX23.Name = "txtX23";
            txtX23.Size = new Size(121, 23);
            txtX23.TabIndex = 121;
            // 
            // txtX22
            // 
            txtX22.Location = new Point(130, 163);
            txtX22.Name = "txtX22";
            txtX22.Size = new Size(121, 23);
            txtX22.TabIndex = 120;
            // 
            // txtX21
            // 
            txtX21.Location = new Point(3, 163);
            txtX21.Name = "txtX21";
            txtX21.Size = new Size(121, 23);
            txtX21.TabIndex = 119;
            // 
            // txtB1
            // 
            txtB1.Location = new Point(384, 3);
            txtB1.Name = "txtB1";
            txtB1.Size = new Size(122, 23);
            txtB1.TabIndex = 118;
            // 
            // txtX13
            // 
            txtX13.Location = new Point(257, 3);
            txtX13.Name = "txtX13";
            txtX13.Size = new Size(121, 23);
            txtX13.TabIndex = 117;
            // 
            // txtX11
            // 
            txtX11.Location = new Point(3, 3);
            txtX11.Name = "txtX11";
            txtX11.Size = new Size(121, 23);
            txtX11.TabIndex = 115;
            // 
            // txtX12
            // 
            txtX12.Location = new Point(130, 3);
            txtX12.Name = "txtX12";
            txtX12.Size = new Size(121, 23);
            txtX12.TabIndex = 116;
            // 
            // txtResultadoX1
            // 
            txtResultadoX1.BorderStyle = BorderStyle.FixedSingle;
            txtResultadoX1.Location = new Point(713, 389);
            txtResultadoX1.Name = "txtResultadoX1";
            txtResultadoX1.ReadOnly = true;
            txtResultadoX1.Size = new Size(199, 23);
            txtResultadoX1.TabIndex = 112;
            // 
            // txtResultadoX2
            // 
            txtResultadoX2.Location = new Point(713, 545);
            txtResultadoX2.Name = "txtResultadoX2";
            txtResultadoX2.ReadOnly = true;
            txtResultadoX2.Size = new Size(199, 23);
            txtResultadoX2.TabIndex = 113;
            // 
            // txtResultadoX3
            // 
            txtResultadoX3.Location = new Point(713, 702);
            txtResultadoX3.Name = "txtResultadoX3";
            txtResultadoX3.ReadOnly = true;
            txtResultadoX3.Size = new Size(199, 23);
            txtResultadoX3.TabIndex = 114;
            // 
            // cmbMetodo
            // 
            cmbMetodo.FormattingEnabled = true;
            cmbMetodo.Items.AddRange(new object[] { "", "Gauss", "Gauss-Jordan" });
            cmbMetodo.Location = new Point(67, 202);
            cmbMetodo.Name = "cmbMetodo";
            cmbMetodo.Size = new Size(305, 23);
            cmbMetodo.TabIndex = 115;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(598, 391);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 116;
            label1.Tag = "chico";
            label1.Text = "X1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(598, 548);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 117;
            label2.Tag = "chico";
            label2.Text = "X2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(598, 710);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 118;
            label3.Tag = "chico";
            label3.Text = "X3";
            // 
            // Asignacion07Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 77, 86);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbMetodo);
            Controls.Add(txtResultadoX3);
            Controls.Add(txtResultadoX2);
            Controls.Add(txtResultadoX1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblTipoMatriz);
            Controls.Add(lblResultados);
            Controls.Add(lblIngresarDatos);
            Controls.Add(cmbFuncion);
            Controls.Add(label4);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(lblMetodo);
            Controls.Add(BtnVolver);
            Name = "Asignacion07Control";
            Size = new Size(1278, 854);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbFuncion;
        private Label lblFuncion;
        private Label label4;
        private TextBox txtValor1;
        private Button btnLimpiar;
        private Button btnCalcular;
        private Label lblMetodo;
        private DataGridView dgvSecante;
        private Button BtnVolver;
        private Label lblIngresarDatos;
        private Label lblResultados;
        private Label lblTipoMatriz;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtResultadoX1;
        private TextBox txtResultadoX2;
        private TextBox txtB3;
        private TextBox txtX33;
        private TextBox txtX32;
        private TextBox txtX31;
        private TextBox txtB2;
        private TextBox txtX23;
        private TextBox txtX22;
        private TextBox txtX21;
        private TextBox txtB1;
        private TextBox txtX13;
        private TextBox txtX12;
        private TextBox txtX11;
        private TextBox txtResultadoX3;
        private ComboBox cmbMetodo;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

namespace AsignacionesMetodosNumericos.RaicesFunciones.implementaciones
{
    partial class MetodoBiseccionControl
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
            label2 = new Label();
            label1 = new Label();
            lblXi = new Label();
            dgvBiseccion = new DataGridView();
            BtnVolver = new Button();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            txtXinicial = new TextBox();
            txtXfinal = new TextBox();
            txtErrorAproximado = new TextBox();
            label4 = new Label();
            txtFuncion = new TextBox();
            lblFuncion = new Label();
            txtEjemplo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBiseccion).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 126);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 55;
            label2.Tag = "chico";
            label2.Text = "Error Aproximado";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 222);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 54;
            label1.Tag = "chico";
            label1.Text = "X final";
            // 
            // lblXi
            // 
            lblXi.AutoSize = true;
            lblXi.Location = new Point(52, 126);
            lblXi.Name = "lblXi";
            lblXi.Size = new Size(48, 15);
            lblXi.TabIndex = 53;
            lblXi.Tag = "chico";
            lblXi.Text = "X inicial";
            lblXi.Click += lblXi_Click;
            // 
            // dgvBiseccion
            // 
            dgvBiseccion.AllowUserToResizeColumns = false;
            dgvBiseccion.BackgroundColor = Color.FromArgb(16, 48, 54);
            dgvBiseccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBiseccion.Location = new Point(52, 314);
            dgvBiseccion.Name = "dgvBiseccion";
            dgvBiseccion.Size = new Size(980, 469);
            dgvBiseccion.TabIndex = 48;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.FromArgb(16, 48, 54);
            BtnVolver.Location = new Point(997, 22);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(158, 90);
            BtnVolver.TabIndex = 47;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(16, 48, 54);
            btnCalcular.Location = new Point(1038, 364);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(158, 90);
            btnCalcular.TabIndex = 58;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(16, 48, 54);
            btnLimpiar.Location = new Point(1038, 568);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(158, 90);
            btnLimpiar.TabIndex = 59;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtXinicial
            // 
            txtXinicial.Location = new Point(52, 169);
            txtXinicial.Name = "txtXinicial";
            txtXinicial.Size = new Size(199, 23);
            txtXinicial.TabIndex = 60;
            // 
            // txtXfinal
            // 
            txtXfinal.Location = new Point(52, 265);
            txtXfinal.Name = "txtXfinal";
            txtXfinal.Size = new Size(199, 23);
            txtXfinal.TabIndex = 61;
            // 
            // txtErrorAproximado
            // 
            txtErrorAproximado.Location = new Point(354, 169);
            txtErrorAproximado.Name = "txtErrorAproximado";
            txtErrorAproximado.Size = new Size(199, 23);
            txtErrorAproximado.TabIndex = 62;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(16, 48, 54);
            label4.Location = new Point(52, 22);
            label4.Name = "label4";
            label4.Size = new Size(925, 90);
            label4.TabIndex = 63;
            label4.Text = "Metodo Biseccion";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFuncion
            // 
            txtFuncion.Location = new Point(672, 251);
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(360, 23);
            txtFuncion.TabIndex = 64;
            // 
            // lblFuncion
            // 
            lblFuncion.AutoSize = true;
            lblFuncion.Location = new Point(672, 126);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(50, 15);
            lblFuncion.TabIndex = 65;
            lblFuncion.Tag = "chico";
            lblFuncion.Text = "Funcion";
            lblFuncion.Click += lblFuncion_Click;
            // 
            // txtEjemplo
            // 
            txtEjemplo.Location = new Point(672, 169);
            txtEjemplo.Name = "txtEjemplo";
            txtEjemplo.Size = new Size(483, 23);
            txtEjemplo.TabIndex = 66;
            txtEjemplo.Text = "Ejemplo: 4x^3 - 6x^2 + 7x - 2.3";
            txtEjemplo.TextChanged += txtEjemplo_TextChanged;
            // 
            // MetodoBiseccionControl
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
            Controls.Add(dgvBiseccion);
            Controls.Add(BtnVolver);
            Name = "MetodoBiseccionControl";
            Size = new Size(1262, 815);
            Load += MetodoBiseccionControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBiseccion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label lblXi;
        private DataGridView dgvBiseccion;
        private Button BtnVolver;
        private Button btnCalcular;
        private Button btnLimpiar;
        private TextBox txtXinicial;
        private TextBox txtXfinal;
        private TextBox txtErrorAproximado;
        private Label label4;
        private TextBox txtFuncion;
        private Label lblFuncion;
        private TextBox txtEjemplo;
    }
}

namespace AsignacionesMetodosNumericos.Error_Absoluto
{
    partial class ErrorAbsRelControl
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
            lblFondo = new Label();
            lblTituloErrores = new Label();
            label6 = new Label();
            BtnVolver = new Button();
            txtValorAproximado = new TextBox();
            txtValorReal = new TextBox();
            lblNombreValorAproximado = new Label();
            lblValorReal = new Label();
            lblValor1 = new Label();
            lblErrorAbsoluto = new Label();
            label5 = new Label();
            lblErrorRelativo = new Label();
            button1 = new Button();
            btnLimpiarErrores = new Button();
            SuspendLayout();
            // 
            // lblFondo
            // 
            lblFondo.BackColor = Color.FromArgb(16, 48, 54);
            lblFondo.Location = new Point(93, 129);
            lblFondo.Name = "lblFondo";
            lblFondo.Size = new Size(1068, 620);
            lblFondo.TabIndex = 30;
            // 
            // lblTituloErrores
            // 
            lblTituloErrores.BackColor = Color.FromArgb(16, 48, 54);
            lblTituloErrores.Location = new Point(93, 22);
            lblTituloErrores.Name = "lblTituloErrores";
            lblTituloErrores.Size = new Size(904, 90);
            lblTituloErrores.TabIndex = 31;
            lblTituloErrores.Text = "Calcular Error Absoluto y Relativo";
            lblTituloErrores.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Location = new Point(62, 579);
            label6.Name = "label6";
            label6.Size = new Size(25, 170);
            label6.TabIndex = 32;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.FromArgb(16, 48, 54);
            BtnVolver.Location = new Point(1003, 22);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(158, 90);
            BtnVolver.TabIndex = 34;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // txtValorAproximado
            // 
            txtValorAproximado.Location = new Point(133, 310);
            txtValorAproximado.Name = "txtValorAproximado";
            txtValorAproximado.Size = new Size(411, 23);
            txtValorAproximado.TabIndex = 35;
            txtValorAproximado.TextChanged += txtValorRelativo_TextChanged;
            txtValorAproximado.KeyPress += txtValorRelativo_KeyPress;
            // 
            // txtValorReal
            // 
            txtValorReal.Location = new Point(715, 310);
            txtValorReal.Name = "txtValorReal";
            txtValorReal.Size = new Size(430, 23);
            txtValorReal.TabIndex = 36;
            txtValorReal.TextChanged += txtValorAbsoluto_TextChanged;
            txtValorReal.KeyPress += txtValorAbsoluto_KeyPress;
            // 
            // lblNombreValorAproximado
            // 
            lblNombreValorAproximado.AutoSize = true;
            lblNombreValorAproximado.Location = new Point(133, 203);
            lblNombreValorAproximado.Name = "lblNombreValorAproximado";
            lblNombreValorAproximado.Size = new Size(104, 15);
            lblNombreValorAproximado.TabIndex = 37;
            lblNombreValorAproximado.Text = " Valor Aproximado";
            lblNombreValorAproximado.Click += label1_Click;
            // 
            // lblValorReal
            // 
            lblValorReal.AutoSize = true;
            lblValorReal.Location = new Point(715, 203);
            lblValorReal.Name = "lblValorReal";
            lblValorReal.Size = new Size(61, 15);
            lblValorReal.TabIndex = 38;
            lblValorReal.Text = " Valor Real";
            lblValorReal.Click += label1_Click_1;
            // 
            // lblValor1
            // 
            lblValor1.AutoSize = true;
            lblValor1.Location = new Point(133, 377);
            lblValor1.Name = "lblValor1";
            lblValor1.Size = new Size(86, 15);
            lblValor1.TabIndex = 39;
            lblValor1.Text = "Error Absoluto:";
            lblValor1.Click += lblValor1_Click;
            // 
            // lblErrorAbsoluto
            // 
            lblErrorAbsoluto.Location = new Point(133, 487);
            lblErrorAbsoluto.Name = "lblErrorAbsoluto";
            lblErrorAbsoluto.Size = new Size(411, 100);
            lblErrorAbsoluto.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(715, 377);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 41;
            label5.Text = "Error Relativo:";
            label5.Click += label5_Click;
            // 
            // lblErrorRelativo
            // 
            lblErrorRelativo.Location = new Point(715, 487);
            lblErrorRelativo.Name = "lblErrorRelativo";
            lblErrorRelativo.Size = new Size(430, 100);
            lblErrorRelativo.TabIndex = 42;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(16, 48, 54);
            button1.Location = new Point(188, 643);
            button1.Name = "button1";
            button1.Size = new Size(158, 90);
            button1.TabIndex = 43;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnLimpiarErrores
            // 
            btnLimpiarErrores.BackColor = Color.FromArgb(16, 48, 54);
            btnLimpiarErrores.Location = new Point(896, 643);
            btnLimpiarErrores.Name = "btnLimpiarErrores";
            btnLimpiarErrores.Size = new Size(158, 90);
            btnLimpiarErrores.TabIndex = 44;
            btnLimpiarErrores.Text = "Limpiar";
            btnLimpiarErrores.UseVisualStyleBackColor = false;
            btnLimpiarErrores.Click += btnLimpiarErrores_Click;
            // 
            // ErrorAbsRelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 77, 86);
            Controls.Add(btnLimpiarErrores);
            Controls.Add(button1);
            Controls.Add(lblErrorRelativo);
            Controls.Add(label5);
            Controls.Add(lblErrorAbsoluto);
            Controls.Add(lblValor1);
            Controls.Add(lblValorReal);
            Controls.Add(lblNombreValorAproximado);
            Controls.Add(txtValorReal);
            Controls.Add(txtValorAproximado);
            Controls.Add(BtnVolver);
            Controls.Add(label6);
            Controls.Add(lblTituloErrores);
            Controls.Add(lblFondo);
            Name = "ErrorAbsRelControl";
            Size = new Size(1262, 815);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFondo;
        private Label lblTituloErrores;
        private Label label6;
        private Label label4;
        private Button BtnVolver;
        private TextBox txtValorAproximado;
        private TextBox txtValorReal;
        private Label lblNombreValorAproximado;
        private Label lblValorReal;
        private Label lblValor1;
        private Label lblErrorAbsoluto;
        private Label label5;
        private Label lblErrorRelativo;
        private Button button1;
        private Button btnLimpiarErrores;
    }
}

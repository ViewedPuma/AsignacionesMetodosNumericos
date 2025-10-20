namespace MetodosNumericos_Unidad2.Meotodo_Gauss_Seidel
{
    partial class GaussSeidelControl
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
            btnCalcular = new Button();
            BtnVolver = new Button();
            dgvGaussSeidel = new DataGridView();
            txtEA = new TextBox();
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvGaussSeidel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(16, 48, 54);
            label4.Location = new Point(72, 52);
            label4.Name = "label4";
            label4.Size = new Size(925, 90);
            label4.TabIndex = 123;
            label4.Text = "Gauss-Seidel";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(16, 48, 54);
            btnCalcular.Location = new Point(839, 172);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(158, 90);
            btnCalcular.TabIndex = 121;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.FromArgb(16, 48, 54);
            BtnVolver.Location = new Point(1017, 52);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(158, 90);
            BtnVolver.TabIndex = 119;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // dgvGaussSeidel
            // 
            dgvGaussSeidel.AllowUserToResizeColumns = false;
            dgvGaussSeidel.BackgroundColor = Color.FromArgb(16, 48, 54);
            dgvGaussSeidel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGaussSeidel.Location = new Point(40, 289);
            dgvGaussSeidel.Name = "dgvGaussSeidel";
            dgvGaussSeidel.Size = new Size(1151, 491);
            dgvGaussSeidel.TabIndex = 124;
            // 
            // txtEA
            // 
            txtEA.Location = new Point(527, 224);
            txtEA.Name = "txtEA";
            txtEA.Size = new Size(235, 23);
            txtEA.TabIndex = 126;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 163);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 127;
            label1.Tag = "chico";
            label1.Text = "Tamaño de la matriz (2-40)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(527, 163);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 128;
            label2.Tag = "chico";
            label2.Text = "Error Absoluto (%)";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(72, 225);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(148, 23);
            numericUpDown1.TabIndex = 129;
            numericUpDown1.Tag = "mini";
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // GaussSeidelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 77, 86);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEA);
            Controls.Add(dgvGaussSeidel);
            Controls.Add(label4);
            Controls.Add(btnCalcular);
            Controls.Add(BtnVolver);
            Name = "GaussSeidelControl";
            Size = new Size(1278, 854);
            ((System.ComponentModel.ISupportInitialize)dgvGaussSeidel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnCalcular;
        private Button BtnVolver;
        private DataGridView dgvGaussSeidel;
        private TextBox txtEA;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
    }
}

namespace MetodosDeRegresion
{
    partial class MetodosControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label4 = new Label();
            BtnVolver = new Button();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            crtGrafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dgvRegresion = new DataGridView();
            comboBox1 = new ComboBox();
            label1 = new Label();
            btnGrafica = new Button();
            numFilas = new NumericUpDown();
            label2 = new Label();
            numVariables = new NumericUpDown();
            gradoPolinomio = new NumericUpDown();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)crtGrafica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegresion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFilas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVariables).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradoPolinomio).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(16, 48, 54);
            label4.Location = new Point(42, 57);
            label4.Name = "label4";
            label4.Size = new Size(978, 90);
            label4.TabIndex = 91;
            label4.Text = "Metodos Regresion";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.FromArgb(16, 48, 54);
            BtnVolver.Location = new Point(1040, 57);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(158, 90);
            BtnVolver.TabIndex = 90;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(16, 48, 54);
            btnLimpiar.Location = new Point(1040, 169);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(158, 90);
            btnLimpiar.TabIndex = 93;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(16, 48, 54);
            btnCalcular.Location = new Point(684, 169);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(158, 90);
            btnCalcular.TabIndex = 92;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // crtGrafica
            // 
            chartArea1.Name = "ChartArea1";
            crtGrafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            crtGrafica.Legends.Add(legend1);
            crtGrafica.Location = new Point(378, 392);
            crtGrafica.Name = "crtGrafica";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            crtGrafica.Series.Add(series1);
            crtGrafica.Size = new Size(476, 377);
            crtGrafica.TabIndex = 94;
            crtGrafica.Text = "chart1";
            crtGrafica.Click += chart1_Click;
            // 
            // dgvRegresion
            // 
            dgvRegresion.AllowUserToResizeColumns = false;
            dgvRegresion.BackgroundColor = Color.FromArgb(16, 48, 54);
            dgvRegresion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegresion.Location = new Point(42, 392);
            dgvRegresion.Name = "dgvRegresion";
            dgvRegresion.Size = new Size(297, 377);
            dgvRegresion.TabIndex = 125;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Lineal", "LinealExponencial", "LinealMultiple", "Polinomial" });
            comboBox1.Location = new Point(44, 213);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(266, 23);
            comboBox1.TabIndex = 126;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 158);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 127;
            label1.Tag = "chico";
            label1.Text = "Metodo";
            // 
            // btnGrafica
            // 
            btnGrafica.BackColor = Color.FromArgb(16, 48, 54);
            btnGrafica.Location = new Point(862, 169);
            btnGrafica.Name = "btnGrafica";
            btnGrafica.Size = new Size(158, 90);
            btnGrafica.TabIndex = 129;
            btnGrafica.Text = "Grafica";
            btnGrafica.UseVisualStyleBackColor = false;
            // 
            // numFilas
            // 
            numFilas.Location = new Point(44, 340);
            numFilas.Name = "numFilas";
            numFilas.Size = new Size(216, 23);
            numFilas.TabIndex = 130;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 285);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 131;
            label2.Tag = "chico";
            label2.Text = "Num Filas";
            label2.Click += label2_Click;
            // 
            // numVariables
            // 
            numVariables.Location = new Point(333, 214);
            numVariables.Name = "numVariables";
            numVariables.Size = new Size(216, 23);
            numVariables.TabIndex = 132;
            // 
            // gradoPolinomio
            // 
            gradoPolinomio.Location = new Point(333, 340);
            gradoPolinomio.Name = "gradoPolinomio";
            gradoPolinomio.Size = new Size(216, 23);
            gradoPolinomio.TabIndex = 133;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 158);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 134;
            label3.Tag = "chico";
            label3.Text = "Num Variables";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(333, 285);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 135;
            label5.Tag = "chico";
            label5.Text = "Grado Polinomio";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(879, 407);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 136;
            label6.Text = "Resultados";
            // 
            // MetodosControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 77, 86);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(gradoPolinomio);
            Controls.Add(numVariables);
            Controls.Add(label2);
            Controls.Add(numFilas);
            Controls.Add(btnGrafica);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(dgvRegresion);
            Controls.Add(crtGrafica);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(label4);
            Controls.Add(BtnVolver);
            Name = "MetodosControl";
            Size = new Size(1278, 854);
            Load += MetodosControl_Load;
            ((System.ComponentModel.ISupportInitialize)crtGrafica).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegresion).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFilas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVariables).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradoPolinomio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button BtnVolver;
        private Button btnLimpiar;
        private Button btnCalcular;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtGrafica;
        private DataGridView dgvRegresion;
        private ComboBox comboBox1;
        private Label label1;
        private Button btnGrafica;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Label label3;
        private Label label5;
        private NumericUpDown numFilas;
        private NumericUpDown numVariables;
        private NumericUpDown gradoPolinomio;
        private Label label6;
    }
}

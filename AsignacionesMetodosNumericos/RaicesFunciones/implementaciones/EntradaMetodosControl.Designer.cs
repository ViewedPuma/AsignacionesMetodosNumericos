namespace AsignacionesMetodosNumericos.RaicesFunciones.implementaciones
{
    partial class EntradaMetodosControl
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
            btnBiseccion = new Button();
            btnReglaFalsa = new Button();
            button2 = new Button();
            button4 = new Button();
            label1 = new Label();
            BtnVolver = new Button();
            label4 = new Label();
            label3 = new Label();
            lblFondo = new Label();
            SuspendLayout();
            // 
            // btnBiseccion
            // 
            btnBiseccion.BackColor = Color.FromArgb(16, 48, 54);
            btnBiseccion.Location = new Point(246, 263);
            btnBiseccion.Name = "btnBiseccion";
            btnBiseccion.Size = new Size(207, 138);
            btnBiseccion.TabIndex = 4;
            btnBiseccion.Text = "Biseccion";
            btnBiseccion.UseVisualStyleBackColor = false;
            btnBiseccion.Click += btnBiseccion_Click;
            // 
            // btnReglaFalsa
            // 
            btnReglaFalsa.BackColor = Color.FromArgb(16, 48, 54);
            btnReglaFalsa.Location = new Point(688, 263);
            btnReglaFalsa.Name = "btnReglaFalsa";
            btnReglaFalsa.Size = new Size(207, 138);
            btnReglaFalsa.TabIndex = 5;
            btnReglaFalsa.Text = "ReglaFalsa";
            btnReglaFalsa.UseVisualStyleBackColor = false;
            btnReglaFalsa.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(16, 48, 54);
            button2.Enabled = false;
            button2.Location = new Point(246, 485);
            button2.Name = "button2";
            button2.Size = new Size(207, 138);
            button2.TabIndex = 6;
            button2.Text = "Coming Soon";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(16, 48, 54);
            button4.Enabled = false;
            button4.Location = new Point(688, 485);
            button4.Name = "button4";
            button4.Size = new Size(207, 138);
            button4.TabIndex = 7;
            button4.Text = "Coming Soon";
            button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(16, 48, 54);
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 69);
            label1.Name = "label1";
            label1.Size = new Size(892, 90);
            label1.TabIndex = 8;
            label1.Text = "Raices de Ecuaciones";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.FromArgb(16, 48, 54);
            BtnVolver.Location = new Point(1037, 69);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(158, 90);
            BtnVolver.TabIndex = 28;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(172, 109, 54);
            label4.Location = new Point(980, 701);
            label4.Name = "label4";
            label4.Size = new Size(197, 92);
            label4.TabIndex = 29;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(144, 770);
            label3.Name = "label3";
            label3.Size = new Size(207, 23);
            label3.TabIndex = 30;
            // 
            // lblFondo
            // 
            lblFondo.BackColor = Color.FromArgb(16, 48, 54);
            lblFondo.Location = new Point(123, 199);
            lblFondo.Name = "lblFondo";
            lblFondo.Size = new Size(892, 502);
            lblFondo.TabIndex = 31;
            // 
            // EntradaMetodosControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 77, 86);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(BtnVolver);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(btnReglaFalsa);
            Controls.Add(btnBiseccion);
            Controls.Add(lblFondo);
            Name = "EntradaMetodosControl";
            Size = new Size(1262, 815);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBiseccion;
        private Button btnReglaFalsa;
        private Button button2;
        private Button button4;
        private Label label1;
        private Button BtnVolver;
        private Label label4;
        private Label label3;
        private Label lblFondo;
    }
}

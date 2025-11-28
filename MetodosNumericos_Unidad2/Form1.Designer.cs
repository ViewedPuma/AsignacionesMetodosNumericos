namespace MetodosNumericos_Unidad2
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelContenedor = new Panel();
            btnAsignacion07 = new Button();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnGaussSeidel = new Button();
            SuspendLayout();
            // 
            // PanelContenedor
            // 
            PanelContenedor.Location = new Point(0, 683);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(619, 132);
            PanelContenedor.TabIndex = 28;
            PanelContenedor.Visible = false;
            // 
            // btnAsignacion07
            // 
            btnAsignacion07.BackColor = Color.FromArgb(16, 48, 54);
            btnAsignacion07.Location = new Point(355, 300);
            btnAsignacion07.Name = "btnAsignacion07";
            btnAsignacion07.Size = new Size(207, 138);
            btnAsignacion07.TabIndex = 27;
            btnAsignacion07.Tag = "chico";
            btnAsignacion07.Text = "Gauss,Gauss-Jordan";
            btnAsignacion07.UseVisualStyleBackColor = false;
            btnAsignacion07.Click += btnAsignacion07_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(172, 109, 54);
            label5.Location = new Point(966, 683);
            label5.Name = "label5";
            label5.Size = new Size(197, 92);
            label5.TabIndex = 26;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(140, 752);
            label3.Name = "label3";
            label3.Size = new Size(207, 23);
            label3.TabIndex = 25;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(16, 48, 54);
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 21);
            label1.Name = "label1";
            label1.Size = new Size(1048, 90);
            label1.TabIndex = 18;
            label1.Text = "Metodos Numericos Unidad 2";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.BackColor = Color.FromArgb(16, 48, 54);
            label2.Location = new Point(99, 139);
            label2.Name = "label2";
            label2.Size = new Size(1048, 507);
            label2.TabIndex = 24;
            // 
            // btnGaussSeidel
            // 
            btnGaussSeidel.BackColor = Color.FromArgb(16, 48, 54);
            btnGaussSeidel.Location = new Point(720, 300);
            btnGaussSeidel.Name = "btnGaussSeidel";
            btnGaussSeidel.Size = new Size(207, 138);
            btnGaussSeidel.TabIndex = 31;
            btnGaussSeidel.Text = "Gauss-Seidel";
            btnGaussSeidel.UseVisualStyleBackColor = false;
            btnGaussSeidel.Click += btnGaussSeidel_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 77, 86);
            ClientSize = new Size(1262, 815);
            Controls.Add(PanelContenedor);
            Controls.Add(btnGaussSeidel);
            Controls.Add(btnAsignacion07);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMain";
            Text = "frmMain";
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelContenedor;
        private Button btnAsignacion07;
        private Label label5;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button btnGaussSeidel;
    }
}

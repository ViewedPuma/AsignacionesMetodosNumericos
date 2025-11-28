namespace MetodosNumericosUnidad5
{
    partial class Form1
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
            btnLarange = new Button();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            PanelContenedor = new Panel();
            SuspendLayout();
            // 
            // btnLarange
            // 
            btnLarange.BackColor = Color.FromArgb(16, 48, 54);
            btnLarange.Location = new Point(529, 302);
            btnLarange.Name = "btnLarange";
            btnLarange.Size = new Size(207, 138);
            btnLarange.TabIndex = 35;
            btnLarange.Text = "Larange";
            btnLarange.UseVisualStyleBackColor = false;
            btnLarange.Click += btnGaussSeidel_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(172, 109, 54);
            label5.Location = new Point(966, 692);
            label5.Name = "label5";
            label5.Size = new Size(197, 92);
            label5.TabIndex = 34;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(16, 48, 54);
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 30);
            label1.Name = "label1";
            label1.Size = new Size(1048, 90);
            label1.TabIndex = 32;
            label1.Text = "Metodos Numericos Unidad 2";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.BackColor = Color.FromArgb(16, 48, 54);
            label2.Location = new Point(99, 148);
            label2.Name = "label2";
            label2.Size = new Size(1048, 507);
            label2.TabIndex = 33;
            // 
            // PanelContenedor
            // 
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(0, 0);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(1262, 815);
            PanelContenedor.TabIndex = 36;
            PanelContenedor.Visible = false;
            PanelContenedor.Paint += PanelContenedor_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 77, 86);
            ClientSize = new Size(1262, 815);
            Controls.Add(PanelContenedor);
            Controls.Add(btnLarange);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLarange;
        private Label label5;
        private Label label1;
        private Label label2;
        private Panel PanelContenedor;
    }
}

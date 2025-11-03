namespace MetodosDeRegresion
{
    partial class Metodos
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
            label1 = new Label();
            btnMetodosRegresion = new Button();
            PanelContenedor = new Panel();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(16, 48, 54);
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(-132, -161);
            label1.Name = "label1";
            label1.Size = new Size(1048, 90);
            label1.TabIndex = 18;
            label1.Text = "Metodos Numericos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMetodosRegresion
            // 
            btnMetodosRegresion.BackColor = Color.FromArgb(16, 48, 54);
            btnMetodosRegresion.Location = new Point(503, 312);
            btnMetodosRegresion.Name = "btnMetodosRegresion";
            btnMetodosRegresion.Size = new Size(207, 138);
            btnMetodosRegresion.TabIndex = 31;
            btnMetodosRegresion.Text = "Metodos de Regresion";
            btnMetodosRegresion.UseVisualStyleBackColor = false;
            btnMetodosRegresion.Click += btnMetodosRegresion_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(0, 0);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(1262, 815);
            PanelContenedor.TabIndex = 29;
            PanelContenedor.Visible = false;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(172, 109, 54);
            label5.Location = new Point(966, 683);
            label5.Name = "label5";
            label5.Size = new Size(197, 92);
            label5.TabIndex = 27;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(140, 752);
            label3.Name = "label3";
            label3.Size = new Size(207, 23);
            label3.TabIndex = 26;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(16, 48, 54);
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(99, 21);
            label2.Name = "label2";
            label2.Size = new Size(1048, 90);
            label2.TabIndex = 19;
            label2.Text = "Metodos Numericos";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.BackColor = Color.FromArgb(16, 48, 54);
            label4.Location = new Point(99, 154);
            label4.Name = "label4";
            label4.Size = new Size(1048, 507);
            label4.TabIndex = 25;
            // 
            // Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 77, 86);
            ClientSize = new Size(1262, 815);
            Controls.Add(PanelContenedor);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMetodosRegresion);
            Controls.Add(label4);
            Name = "Metodos";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button btnMetodosRegresion;
        private Panel PanelContenedor;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}

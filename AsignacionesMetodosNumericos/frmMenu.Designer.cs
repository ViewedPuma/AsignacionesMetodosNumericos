
namespace AsignacionesMetodosNumericos
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            label1 = new Label();
            btnErrorAbsolutoRelativo = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            btnAsignacion02 = new Button();
            PanelContenedor = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(16, 48, 54);
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 42);
            label1.Name = "label1";
            label1.Size = new Size(1048, 90);
            label1.TabIndex = 0;
            label1.Text = "Metodos Numericos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // btnErrorAbsolutoRelativo
            // 
            btnErrorAbsolutoRelativo.BackColor = Color.FromArgb(16, 48, 54);
            btnErrorAbsolutoRelativo.Location = new Point(416, 245);
            btnErrorAbsolutoRelativo.Name = "btnErrorAbsolutoRelativo";
            btnErrorAbsolutoRelativo.Size = new Size(207, 138);
            btnErrorAbsolutoRelativo.TabIndex = 2;
            btnErrorAbsolutoRelativo.Text = "Error A y R";
            btnErrorAbsolutoRelativo.UseVisualStyleBackColor = false;
            btnErrorAbsolutoRelativo.Click += btnErrorAbsolutoRelativo_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(16, 48, 54);
            button3.Enabled = false;
            button3.Location = new Point(667, 245);
            button3.Name = "button3";
            button3.Size = new Size(207, 138);
            button3.TabIndex = 3;
            button3.Text = "Coming Soon";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(16, 48, 54);
            button4.Enabled = false;
            button4.Location = new Point(916, 245);
            button4.Name = "button4";
            button4.Size = new Size(207, 138);
            button4.TabIndex = 4;
            button4.Text = "Coming Soon";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(16, 48, 54);
            button5.Enabled = false;
            button5.Location = new Point(160, 444);
            button5.Name = "button5";
            button5.Size = new Size(207, 138);
            button5.TabIndex = 5;
            button5.Text = "Coming Soon";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(16, 48, 54);
            button6.Enabled = false;
            button6.Location = new Point(416, 444);
            button6.Name = "button6";
            button6.Size = new Size(207, 138);
            button6.TabIndex = 6;
            button6.Text = "Coming Soon";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(16, 48, 54);
            button7.Enabled = false;
            button7.Location = new Point(916, 444);
            button7.Name = "button7";
            button7.Size = new Size(207, 138);
            button7.TabIndex = 7;
            button7.Text = "Coming Soon";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(16, 48, 54);
            button8.Enabled = false;
            button8.Location = new Point(667, 444);
            button8.Name = "button8";
            button8.Size = new Size(207, 138);
            button8.TabIndex = 8;
            button8.Text = "Coming Soon";
            button8.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.BackColor = Color.FromArgb(16, 48, 54);
            label2.Location = new Point(119, 160);
            label2.Name = "label2";
            label2.Size = new Size(1048, 507);
            label2.TabIndex = 9;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(160, 773);
            label3.Name = "label3";
            label3.Size = new Size(207, 23);
            label3.TabIndex = 10;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(172, 109, 54);
            label5.Location = new Point(986, 704);
            label5.Name = "label5";
            label5.Size = new Size(197, 92);
            label5.TabIndex = 12;
            // 
            // btnAsignacion02
            // 
            btnAsignacion02.BackColor = Color.FromArgb(16, 48, 54);
            btnAsignacion02.Location = new Point(160, 245);
            btnAsignacion02.Name = "btnAsignacion02";
            btnAsignacion02.Size = new Size(207, 138);
            btnAsignacion02.TabIndex = 13;
            btnAsignacion02.Text = "Asignacion02";
            btnAsignacion02.UseVisualStyleBackColor = false;
            btnAsignacion02.Click += button1_Click_1;
            // 
            // PanelContenedor
            // 
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(0, 0);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(1262, 815);
            PanelContenedor.TabIndex = 14;
            PanelContenedor.Visible = false;
            PanelContenedor.Paint += PanelAsignacion2_Paint;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 77, 86);
            ClientSize = new Size(1262, 815);
            Controls.Add(PanelContenedor);
            Controls.Add(btnAsignacion02);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnErrorAbsolutoRelativo);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPrincipal";
            Text = "Proyectos Metodos Numericos";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Button btnAsignacion02;
        private Button btnErrorAbsolutoRelativo;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label2;
        private Label label3;
        private Label label5;
        private Panel PanelContenedor;
    }
}

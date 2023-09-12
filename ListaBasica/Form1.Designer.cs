namespace ListaBasica
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
            this.Bienvenido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LstRazas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Bienvenido
            // 
            this.Bienvenido.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Bienvenido.AutoSize = true;
            this.Bienvenido.Location = new System.Drawing.Point(57, 48);
            this.Bienvenido.Name = "Bienvenido";
            this.Bienvenido.Size = new System.Drawing.Size(99, 25);
            this.Bienvenido.TabIndex = 0;
            this.Bienvenido.Text = "Bienvenido";
            this.Bienvenido.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Razas";
            // 
            // LstRazas
            // 
            this.LstRazas.FormattingEnabled = true;
            this.LstRazas.ItemHeight = 25;
            this.LstRazas.Location = new System.Drawing.Point(57, 147);
            this.LstRazas.Name = "LstRazas";
            this.LstRazas.Size = new System.Drawing.Size(180, 129);
            this.LstRazas.TabIndex = 2;
            this.LstRazas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstRazas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bienvenido);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "MyApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Bienvenido;
        private Label label1;
        private ListBox LstRazas;
    }
}
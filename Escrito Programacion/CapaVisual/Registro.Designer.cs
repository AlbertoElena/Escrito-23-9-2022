namespace CapaVisual
{
    partial class Registro
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnEntradaPersona = new System.Windows.Forms.Button();
            this.txtBoxCI = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalidaPersona = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Anuncio";
            // 
            // btnEntradaPersona
            // 
            this.btnEntradaPersona.Location = new System.Drawing.Point(179, 114);
            this.btnEntradaPersona.Name = "btnEntradaPersona";
            this.btnEntradaPersona.Size = new System.Drawing.Size(75, 23);
            this.btnEntradaPersona.TabIndex = 10;
            this.btnEntradaPersona.Text = "Entrar";
            this.btnEntradaPersona.UseVisualStyleBackColor = true;
            this.btnEntradaPersona.Click += new System.EventHandler(this.btnAltaRegistroAnuncio_Click);
            // 
            // txtBoxCI
            // 
            this.txtBoxCI.Location = new System.Drawing.Point(73, 133);
            this.txtBoxCI.Name = "txtBoxCI";
            this.txtBoxCI.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCI.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 227;
            this.label11.Text = "CI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSalidaPersona);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtBoxCI);
            this.panel1.Controls.Add(this.btnEntradaPersona);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(47, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 326);
            this.panel1.TabIndex = 8;
            // 
            // btnSalidaPersona
            // 
            this.btnSalidaPersona.Location = new System.Drawing.Point(179, 143);
            this.btnSalidaPersona.Name = "btnSalidaPersona";
            this.btnSalidaPersona.Size = new System.Drawing.Size(75, 23);
            this.btnSalidaPersona.TabIndex = 228;
            this.btnSalidaPersona.Text = "Salida";
            this.btnSalidaPersona.UseVisualStyleBackColor = true;
            this.btnSalidaPersona.Click += new System.EventHandler(this.btnSalidaPersona_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(498, 422);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEntradaPersona;
        private System.Windows.Forms.TextBox txtBoxCI;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalidaPersona;
    }
}
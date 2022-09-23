namespace CapaVisual
{
    partial class GestionPersona
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.txtTelefonoPersona = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificarPersonas = new System.Windows.Forms.Button();
            this.btnEliminarPersonas = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCIPersonaBM = new System.Windows.Forms.TextBox();
            this.btnListarPersonas = new System.Windows.Forms.Button();
            this.dataGridViewPersona = new System.Windows.Forms.DataGridView();
            this.btnGuardarPersonas = new System.Windows.Forms.Button();
            this.txtNombrePersona = new System.Windows.Forms.TextBox();
            this.txtCIPersona = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApellidoPersona = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.YellowGreen;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(27, 23);
            this.btnMenu.TabIndex = 71;
            this.btnMenu.Text = "<";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // txtTelefonoPersona
            // 
            this.txtTelefonoPersona.BackColor = System.Drawing.SystemColors.Info;
            this.txtTelefonoPersona.Location = new System.Drawing.Point(143, 124);
            this.txtTelefonoPersona.Name = "txtTelefonoPersona";
            this.txtTelefonoPersona.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoPersona.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 85;
            this.label4.Text = "Telefono";
            // 
            // btnModificarPersonas
            // 
            this.btnModificarPersonas.BackColor = System.Drawing.Color.YellowGreen;
            this.btnModificarPersonas.Location = new System.Drawing.Point(143, 234);
            this.btnModificarPersonas.Name = "btnModificarPersonas";
            this.btnModificarPersonas.Size = new System.Drawing.Size(100, 23);
            this.btnModificarPersonas.TabIndex = 84;
            this.btnModificarPersonas.Text = "Modificar";
            this.btnModificarPersonas.UseVisualStyleBackColor = false;
            this.btnModificarPersonas.Click += new System.EventHandler(this.btnModificarCuentas_Click);
            // 
            // btnEliminarPersonas
            // 
            this.btnEliminarPersonas.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEliminarPersonas.Location = new System.Drawing.Point(143, 205);
            this.btnEliminarPersonas.Name = "btnEliminarPersonas";
            this.btnEliminarPersonas.Size = new System.Drawing.Size(100, 23);
            this.btnEliminarPersonas.TabIndex = 83;
            this.btnEliminarPersonas.Text = "Eliminar";
            this.btnEliminarPersonas.UseVisualStyleBackColor = false;
            this.btnEliminarPersonas.Click += new System.EventHandler(this.btnEliminarCuentas_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(275, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 82;
            this.label12.Text = "CI";
            // 
            // txtCIPersonaBM
            // 
            this.txtCIPersonaBM.BackColor = System.Drawing.SystemColors.Info;
            this.txtCIPersonaBM.Location = new System.Drawing.Point(256, 202);
            this.txtCIPersonaBM.Name = "txtCIPersonaBM";
            this.txtCIPersonaBM.Size = new System.Drawing.Size(100, 20);
            this.txtCIPersonaBM.TabIndex = 81;
            // 
            // btnListarPersonas
            // 
            this.btnListarPersonas.BackColor = System.Drawing.Color.YellowGreen;
            this.btnListarPersonas.Location = new System.Drawing.Point(442, 176);
            this.btnListarPersonas.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarPersonas.Name = "btnListarPersonas";
            this.btnListarPersonas.Size = new System.Drawing.Size(129, 25);
            this.btnListarPersonas.TabIndex = 80;
            this.btnListarPersonas.Text = "Listar";
            this.btnListarPersonas.UseVisualStyleBackColor = false;
            this.btnListarPersonas.Click += new System.EventHandler(this.btnListarCuentas_Click);
            // 
            // dataGridViewPersona
            // 
            this.dataGridViewPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersona.Location = new System.Drawing.Point(328, 17);
            this.dataGridViewPersona.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPersona.Name = "dataGridViewPersona";
            this.dataGridViewPersona.RowTemplate.Height = 31;
            this.dataGridViewPersona.Size = new System.Drawing.Size(359, 141);
            this.dataGridViewPersona.TabIndex = 79;
            // 
            // btnGuardarPersonas
            // 
            this.btnGuardarPersonas.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGuardarPersonas.Location = new System.Drawing.Point(143, 176);
            this.btnGuardarPersonas.Name = "btnGuardarPersonas";
            this.btnGuardarPersonas.Size = new System.Drawing.Size(100, 23);
            this.btnGuardarPersonas.TabIndex = 78;
            this.btnGuardarPersonas.Text = "Guardar";
            this.btnGuardarPersonas.UseVisualStyleBackColor = false;
            this.btnGuardarPersonas.Click += new System.EventHandler(this.btnGuardarCuentas_Click);
            // 
            // txtNombrePersona
            // 
            this.txtNombrePersona.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombrePersona.Location = new System.Drawing.Point(143, 72);
            this.txtNombrePersona.Name = "txtNombrePersona";
            this.txtNombrePersona.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePersona.TabIndex = 77;
            // 
            // txtCIPersona
            // 
            this.txtCIPersona.BackColor = System.Drawing.SystemColors.Info;
            this.txtCIPersona.Location = new System.Drawing.Point(143, 46);
            this.txtCIPersona.Name = "txtCIPersona";
            this.txtCIPersona.Size = new System.Drawing.Size(100, 20);
            this.txtCIPersona.TabIndex = 75;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 74;
            this.label13.Text = "Nombre";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(43, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 73;
            this.label15.Text = "Apellido";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(43, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 13);
            this.label16.TabIndex = 72;
            this.label16.Text = "CI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 107;
            this.label7.Text = "Administrador crea cuentas";
            // 
            // txtApellidoPersona
            // 
            this.txtApellidoPersona.BackColor = System.Drawing.SystemColors.Info;
            this.txtApellidoPersona.Location = new System.Drawing.Point(143, 98);
            this.txtApellidoPersona.Name = "txtApellidoPersona";
            this.txtApellidoPersona.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoPersona.TabIndex = 108;
            // 
            // GestionPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 282);
            this.ControlBox = false;
            this.Controls.Add(this.txtApellidoPersona);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefonoPersona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnModificarPersonas);
            this.Controls.Add(this.btnEliminarPersonas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCIPersonaBM);
            this.Controls.Add(this.btnListarPersonas);
            this.Controls.Add(this.dataGridViewPersona);
            this.Controls.Add(this.btnGuardarPersonas);
            this.Controls.Add(this.txtNombrePersona);
            this.Controls.Add(this.txtCIPersona);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnMenu);
            this.Name = "GestionPersona";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionPersona";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox txtTelefonoPersona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModificarPersonas;
        private System.Windows.Forms.Button btnEliminarPersonas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCIPersonaBM;
        private System.Windows.Forms.Button btnListarPersonas;
        private System.Windows.Forms.DataGridView dataGridViewPersona;
        private System.Windows.Forms.Button btnGuardarPersonas;
        private System.Windows.Forms.TextBox txtNombrePersona;
        private System.Windows.Forms.TextBox txtCIPersona;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApellidoPersona;
    }
}
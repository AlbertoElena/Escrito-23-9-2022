using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVisual
{
    public partial class Menu : Form
    {

        public string Tipo;

        public Menu()
        {
            InitializeComponent();
        }


        private void btnUsuario_Click(object sender, EventArgs e)
        {
            GestionPersona ventanaPersona = new GestionPersona();
            ventanaPersona.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       private void btnRegistro_Click(object sender, EventArgs e)
       {
         Registro ventanaRegistro = new Registro();
            ventanaRegistro.Show();
         this.Hide();
       }

        private void btnListarRegistroAnuncio_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable TablaRegistro = new DataTable();
                int CI = Int32.Parse(txtBoxCIListar.Text);
                TablaRegistro = RegistroControlador.Listar(CI);

                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = TablaRegistro;
            }
            catch (Exception ex)
            {
                MessageBox.Show("A ocurrido un error vuelva a ingresar la CI");
            }
        }
    }
}

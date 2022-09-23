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
    public partial class GestionPersona : Form
    {
        public GestionPersona()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
                Menu ventanaPrincipal = new Menu();
                ventanaPrincipal.Show();
                this.Dispose();
        }

        private void btnGuardarCuentas_Click(object sender, EventArgs e)
        {
            try
            {
                PersonaControlador.Alta(
                Int32.Parse(txtCIPersona.Text),
                txtNombrePersona.Text,
                txtApellidoPersona.Text,
                Int32.Parse(txtTelefonoPersona.Text)
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("A ocurrido un error vuelva a ingresar los datos");
            }
        }

        private void btnEliminarCuentas_Click(object sender, EventArgs e)
        {
            try
            {
                PersonaControlador.Eliminar(
                Int32.Parse(txtCIPersonaBM.Text)
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("A ocurrido un error vuelva a ingresar los datos");
            }
        }

        private void btnModificarCuentas_Click(object sender, EventArgs e)
        {
            try
            {
                PersonaControlador.Modificar(
                Int32.Parse(txtCIPersonaBM.Text),
                txtNombrePersona.Text,
                txtApellidoPersona.Text,
                Int32.Parse(txtTelefonoPersona.Text)
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("A ocurrido un error vuelva a ingresar los datos");
            } 
        }

        private void btnListarCuentas_Click(object sender, EventArgs e)
        {
            DataTable TablaCuentas = new DataTable();
            TablaCuentas = PersonaControlador.ObtenerTodos();
            dataGridViewPersona.RowHeadersVisible = false;
            dataGridViewPersona.AllowUserToAddRows = false;
            dataGridViewPersona.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPersona.DataSource = TablaCuentas;
        }
    }
}

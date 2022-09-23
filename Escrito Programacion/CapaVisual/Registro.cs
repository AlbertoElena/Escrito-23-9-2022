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
    public partial class Registro : Form
    {
        public int CICargado;
        public string EntradaCargado;

        public Registro()
        {
            InitializeComponent();
        }

        private void btnAltaRegistroAnuncio_Click(object sender, EventArgs e)
        {
            try
            {
                
                int CI = Int32.Parse(txtBoxCI.Text);

                String Fecha = DateTime.Now.ToLongDateString();
                String Hora = DateTime.Now.ToLongTimeString();

                String FechaBien = String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(Fecha));

                String Entrada = FechaBien + " " + Hora;

                RegistroControlador.Alta(
                CI,
                Entrada
                );

                Registro Registro = new Registro();
                Registro.CICargado = CI;
                Registro.EntradaCargado = Entrada;
                Registro.Show();
                this.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("A ocurrido un error vuelva a ingresar los datos");
            }
        }

        private void btnSalidaPersona_Click(object sender, EventArgs e)
        {

            try
            {
                String Fecha = DateTime.Now.ToLongDateString();
                String Hora = DateTime.Now.ToLongTimeString();

                String FechaBien = String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(Fecha));

                String Salida = FechaBien + " " + Hora;

                RegistroControlador.Actualizar(
                CICargado,
                EntradaCargado,
                Salida
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("A ocurrido un error");
            }

            Menu ventana = new Menu();
            ventana.Show();
            this.Dispose();
        }
    }
}

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
    public partial class GestionTorneo : Form
    {
        public string Tipo;
        public GestionTorneo()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            GestionEstadistica ventana = new GestionEstadistica();
            ventana.Tipo = Tipo;
            ventana.Show();
            this.Dispose();
        }

        private void btnAltaTorneo_Click(object sender, EventArgs e)
        {
            try
            {
                TorneoControlador.Alta(
                txtBoxNombreTorneo.Text,
                DateTime.Parse(txtBoxFechaInicioEvento.Text),
                DateTime.Parse(txtBoxFechaFinalizacionEvento.Text),
                txtEstadoEvento.Text,
                txtBoxImagenEvento.Text,
                Int32.Parse(txtBoxDeBaja.Text)
               );
                MessageBox.Show("Torneo Cargado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lleno mal algunos de los campos vuelva a intentarlo");
            }
        }

        private void btnBajaTorneo_Click(object sender, EventArgs e)
        {
            try
            {
                TorneoControlador.Eliminar(
                Int32.Parse(txtBoxIdTorneo.Text)
                );
                MessageBox.Show("Torneo Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lleno mal algunos de los campos vuelva a intentarlo");
            }
        }

        private void btnModificarTorneo_Click(object sender, EventArgs e)
        {
            try
            {
             TorneoControlador.Modificar(
             Int32.Parse(txtBoxIdTorneo.Text),
             txtBoxNombreTorneo.Text,
             DateTime.Parse(txtBoxFechaInicioEvento.Text),
             DateTime.Parse(txtBoxFechaFinalizacionEvento.Text),
             txtEstadoEvento.Text,
             txtBoxImagenEvento.Text,
             Int32.Parse(txtBoxDeBaja.Text)
            );
                MessageBox.Show("Torneo Modificado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lleno mal algunos de los campos vuelva a intentarlo");
            }

        }

        private void btnListarTorneo_Click(object sender, EventArgs e)
        {
            DataTable TablaTorneo = new DataTable();
            TablaTorneo = TorneoControlador.ObtenerTodos();
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.DataSource = TablaTorneo;
        }

        private void btnAltaPartidoDeTorneo_Click(object sender, EventArgs e)
        {
            try
            {
                PartidoTorneoControlador.Alta(
                Int32.Parse(txtBoxIdPartidoAlta.Text),
                Int32.Parse(txtBoxIdTorneoAlta.Text)
              );
                MessageBox.Show("Partido perteneciente a un Evento Cargado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lleno mal algunos de los campos vuelva a intentarlo");
            }

        }

        private void btnBajaPartidoDeTorneo_Click(object sender, EventArgs e)
        {
            try
            {
                PartidoTorneoControlador.Eliminar(
                Int32.Parse(txtBoxIdPartidoAlta.Text)
              );
                MessageBox.Show("Partido perteneciente a un Evento Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lleno mal algunos de los campos vuelva a intentarlo");
            }

        }

        private void btnListarPartidoDeTorneo_Click(object sender, EventArgs e)
        {
            DataTable TablaPartidoTorneo = new DataTable();
            TablaPartidoTorneo = PartidoTorneoControlador.ObtenerTodos();
            dataGridView9.RowHeadersVisible = false;
            dataGridView9.AllowUserToAddRows = false;
            dataGridView9.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView9.DataSource = TablaPartidoTorneo;
        }

        private void btnAltaPosicionDeParticipante_Click(object sender, EventArgs e)
        {
            try
            {
               PosicionParticipanteTorneoControlador.Alta(
               Int32.Parse(txtBoxIdParticipanteAlta.Text),
               Int32.Parse(txtBoxIdTorneoPosicionAlta.Text),
               Int32.Parse(txtBoxPosicionParticipante.Text),
               Int32.Parse(txtBoxPuntajeParticipante.Text)
              );
                MessageBox.Show("Posicion del Participante Cargado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lleno mal algunos de los campos vuelva a intentarlo");
            }

        }

        private void btnBajaPosicionDeParticipante_Click(object sender, EventArgs e)
        {
            try
            {
             PosicionParticipanteTorneoControlador.Eliminar(
             Int32.Parse(txtBoxIdParticipanteBaja.Text),
             Int32.Parse(txtBoxIdTorneoPosicionBaja.Text)
            );
                MessageBox.Show("Posicion del Participante Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lleno mal algunos de los campos vuelva a intentarlo");
            }

        }

        private void btnModificarPosicionDeParticipante_Click(object sender, EventArgs e)
        {
            try
            {
             PosicionParticipanteTorneoControlador.Modificar(
             Int32.Parse(txtBoxIdParticipanteBaja.Text),
             Int32.Parse(txtBoxIdTorneoPosicionBaja.Text), 
             Int32.Parse(txtBoxPosicionParticipante.Text),
             Int32.Parse(txtBoxPuntajeParticipante.Text)
            );
                MessageBox.Show("Posicion del Participante Modificado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lleno mal algunos de los campos vuelva a intentarlo");
            }

        }

        private void btnListarPosicionDeParticipante_Click(object sender, EventArgs e)
        {
            DataTable TablaPartidoTorneo = new DataTable();
            TablaPartidoTorneo = PosicionParticipanteTorneoControlador.ObtenerTodos();
            dataGridView10.RowHeadersVisible = false;
            dataGridView10.AllowUserToAddRows = false;
            dataGridView10.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView10.DataSource = TablaPartidoTorneo;
        }

        private void btnAltaDeporteEvento_Click(object sender, EventArgs e)
        {
            DeporteEventoControlador.Alta(
            Int32.Parse(IdBoxEventoDeporte.Text),
            Int32.Parse(IdBoxDeporteEvento.Text)
           );
        }

        private void btnBajaDeporteEvento_Click(object sender, EventArgs e)
        {
            DeporteEventoControlador.Eliminar(
            Int32.Parse(IdBoxEventoDeporte.Text),
            Int32.Parse(IdBoxDeporteEvento.Text)
           );
        }

        private void btnListarDeporteEvento_Click(object sender, EventArgs e)
        {
            DataTable TablaDeporteEvento = new DataTable();
            TablaDeporteEvento = DeporteEventoControlador.ObtenerTodos();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = TablaDeporteEvento;
        }
    }  
}

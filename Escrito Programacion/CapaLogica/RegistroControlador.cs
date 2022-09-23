using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;
using System.Windows.Forms;

namespace CapaLogica
{
    public class RegistroControlador
    {
        public static void Alta(int CI, String Entrada)
        {
            try
            {
                ModeloRegistro p = new ModeloRegistro();

                p.CI = CI;
                p.Entrada = Entrada;
                p.Salida = Entrada;
                p.Insertar();
                MessageBox.Show("Los datos se Cargaron exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registar la Entrada");
  
            }

        }

        public static void Actualizar(int CI, String Entrada, String Salida)
        {
            try
            {
                ModeloRegistro p = new ModeloRegistro();

                p.CI = CI;
                p.Entrada = Entrada;
                p.Salida = Salida;
                p.Actualizar();
                MessageBox.Show("Los datos se Cargaron exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registar la Salida");
            }

        }


        
        private static void llenarTablaArbitro(DataTable tablaGeneral, int CI)
        {
            ModeloRegistro p = new ModeloRegistro();
            List<ModeloRegistro> tablas = p.Obtener(CI);
            cargarFilasDesdeModelo(tablaGeneral, tablas);
        }

        public static DataTable Listar(int CI)
        {
            DataTable tablaArbitro = crearTablaDigitador();
            llenarTablaArbitro(tablaArbitro, CI);
            return tablaArbitro;
        }

        private static void cargarFilasDesdeModelo(DataTable proyecto, List<ModeloRegistro> tablas)
        {
            foreach (ModeloRegistro tabla in tablas)
            {
                DataRow fila = proyecto.NewRow();
                fila["CIPersona"] = tabla.CI;
                fila["FechaHoraEntrada"] = tabla.Entrada;
                fila["FechaHoraSalida"] = tabla.Salida;
                proyecto.Rows.Add(fila);
            }
        }

        private static DataTable crearTablaDigitador()
        {
            DataTable proyecto = new DataTable();
            proyecto.Columns.Add("CIPersona", typeof(int));
            proyecto.Columns.Add("FechaHoraEntrada", typeof(string));
            proyecto.Columns.Add("FechaHoraSalida", typeof(string));
            return proyecto;
        }

    }  
}

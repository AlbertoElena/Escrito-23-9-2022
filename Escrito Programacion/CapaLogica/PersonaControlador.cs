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
    public class PersonaControlador
    {
        public static void Alta(int CI, string Nombre, string Apellido, int Telefono)
        {
            try
            {
                ModeloPersona p = new ModeloPersona();
                p.CI = CI;
                p.Nombre = Nombre;
                p.Apellido = Apellido;
                p.Telefono = Telefono;
                p.Insertar();
                MessageBox.Show("Los datos de las Cuentas se Cargaron");
            }
            catch (Exception ex)
            {
                MessageBox.Show("A ocurrido algun error");
            }

        }

        public static void Modificar(int CI, string Nombre, string Apellido, int Telefono)
        {
            try
            {
                ModeloPersona p = new ModeloPersona();
                p.CI = CI;
                p.Nombre = Nombre;
                p.Apellido = Apellido;
                p.Telefono = Telefono;
                p.Actualizar();
                MessageBox.Show("Los datos de las Cuentas se Modificaron");
            }
            catch (Exception ex)
            {
                MessageBox.Show("A ocurrido algun error");
            } 
        }

        public static void Eliminar(int CI)
        {
            try
            {
                ModeloPersona p = new ModeloPersona();
                p.CI = CI;
                p.Eliminar();
                MessageBox.Show("Los datos de las Cuentas se Eliminaron");
            }
            catch (Exception ex)
            {
                MessageBox.Show("A ocurrido algun error");
            }
        }
 
        public static DataTable ObtenerTodos()
        {
            DataTable tablaDePersonas = crearTablaDePersonas();
            llenarTablaDePersonas(tablaDePersonas);
            return tablaDePersonas;
        }
        
        private static void llenarTablaDePersonas(DataTable tablaGeneral)
        {
            ModeloPersona p = new ModeloPersona();
            List<ModeloPersona> tablas = p.Obtener();
            cargarFilasDesdeModelo(tablaGeneral, tablas);
        }

        private static void cargarFilasDesdeModelo(DataTable proyecto, List<ModeloPersona> tablas)
        {
            foreach (ModeloPersona tabla in tablas)
            {
                DataRow fila = proyecto.NewRow();
                fila["CI"] = tabla.CI;
                fila["Nombre"] = tabla.Nombre;
                fila["Apellido"] = tabla.Apellido;
                fila["Telefono"] = tabla.Telefono;
                proyecto.Rows.Add(fila);
            }
        }

        private static DataTable crearTablaDePersonas()
        {
            DataTable proyecto = new DataTable();
            proyecto.Columns.Add("CI", typeof(int));
            proyecto.Columns.Add("Nombre", typeof(string));
            proyecto.Columns.Add("Apellido", typeof(string));
            proyecto.Columns.Add("Telefono", typeof(int));
            return proyecto;
        }
    }
}

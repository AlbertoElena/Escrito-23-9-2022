using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
    public class ModeloPersona : Modelo
    {

        public int CI;
        public string Nombre;
        public string Apellido;
        public int Telefono;

        
        public ModeloPersona(int CI)
        {
            this.Obtener(CI);
        }
        
        public ModeloPersona()
        {

        }

        public void Insertar()
        {
            this.comando.CommandText = "INSERT INTO persona VALUES (@CI,@Nombre,@Apellido,@Telefono)";
            this.comando.Parameters.AddWithValue("@CI", this.CI);
            this.comando.Parameters.AddWithValue("@Nombre", this.Nombre);
            this.comando.Parameters.AddWithValue("@Apellido", this.Apellido);
            this.comando.Parameters.AddWithValue("@Telefono", this.Telefono);
            this.comando.Prepare();
            this.comando.ExecuteNonQuery();

        }
        /*
        
        public void ObtenerPorNombre()
        {
            this.comando.CommandText = "SELECT Nombrecuenta,ContrasenaCuenta FROM cuenta WHERE NombreCuenta = @NombreCuenta";
            this.comando.Parameters.AddWithValue("@NombreCuenta", this.NombreCuenta);
            this.comando.Prepare();
            this.dataReader = this.comando.ExecuteReader();

            if (!this.dataReader.HasRows) return;

            this.dataReader.Read();
            this.NombreCuenta = this.dataReader["NombreCuenta"].ToString();
            this.ContrasenaCuenta = this.dataReader["ContrasenaCuenta"].ToString();
        } */
        
        public void Obtener(int CI)
        {
            obtenerFilaPorId(CI);
            llenarCamposDesdeDataReader();
        }

        private void llenarCamposDesdeDataReader()
        {
            this.CI = Int32.Parse(this.dataReader["CI"].ToString());
            this.Nombre = this.dataReader["Nombre"].ToString();
            this.Apellido = this.dataReader["Apellido"].ToString();
            this.Telefono = Int32.Parse(this.dataReader["Telefono"].ToString());
        }

        private void obtenerFilaPorId(int id)
        {
            this.comando.CommandText = "SELECT * FROM persona WHERE CI = @CI";
            this.comando.Parameters.AddWithValue("@CI", CI);
            this.comando.Prepare();
            this.dataReader = this.comando.ExecuteReader();
            this.dataReader.Read();
        }

        public void Actualizar()
        {
            this.comando.CommandText = "UPDATE persona SET " +
                "Nombre = @Nombre," +
                "Apellido = @Apellido," +
                "Telefono = @Telefono" +
                " WHERE CI = @CI";
            this.comando.Parameters.AddWithValue("@Nombre", this.Nombre);
            this.comando.Parameters.AddWithValue("@Apellido", this.Apellido);
            this.comando.Parameters.AddWithValue("@Telefono", this.Telefono);
            this.comando.Parameters.AddWithValue("@CI", this.CI);
            this.comando.Prepare();
            this.comando.ExecuteNonQuery();        
        }       
        public void Eliminar()
        {
            this.comando.CommandText = "DELETE FROM persona WHERE CI = @CI";
            this.comando.Parameters.AddWithValue("@CI", this.CI);
            this.comando.Prepare();
            this.comando.ExecuteNonQuery();
        }

        
        public List<ModeloPersona> Obtener()
        {
            List<ModeloPersona> persona = obtenerTodasLasFilas();
            crearArrayDePersonas(persona);
            return persona;

        }

        private void crearArrayDePersonas(List<ModeloPersona> persona)
        {
            while (this.dataReader.Read())
            {
                ModeloPersona p = new ModeloPersona();
                p.CI = Int32.Parse(dataReader["CI"].ToString());
                p.Nombre = dataReader["Nombre"].ToString();
                p.Apellido = dataReader["Apellido"].ToString();
                p.Telefono = Int32.Parse(dataReader["Telefono"].ToString());

                persona.Add(p);
            }
        }

        private List<ModeloPersona> obtenerTodasLasFilas()
        {
            List<ModeloPersona> persona = new List<ModeloPersona>();
            this.comando.CommandText = "SELECT * FROM persona";
            this.dataReader = this.comando.ExecuteReader();
            return persona;
        } 
    }
}

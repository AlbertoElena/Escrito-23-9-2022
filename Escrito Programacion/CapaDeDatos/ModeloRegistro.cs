using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
    public class ModeloRegistro : Modelo
    {

        public int CI;
        public String Entrada;
        public String Salida;
 
        public ModeloRegistro()
        {

        }

    
        public void Insertar()
        {
                                                 
            this.comando.CommandText = "INSERT INTO marca VALUES (@CIPersona,@FechaHoraEntrada,@FechaHoraSalida)"; 
            this.comando.Parameters.AddWithValue("@CIPersona", this.CI);
            this.comando.Parameters.AddWithValue("@FechaHoraEntrada", this.Entrada);
            this.comando.Parameters.AddWithValue("@FechaHoraSalida", this.Salida);
            this.comando.Prepare();
            this.comando.ExecuteNonQuery();

        }

        public void Actualizar()
        {
            this.comando.CommandText = "UPDATE marca SET " +
                "FechaHoraEntrada = @FechaHoraEntrada," +
                "FechaHoraSalida = @FechaHoraSalida" +
                " WHERE CIPersona = @CIPersona";
            this.comando.Parameters.AddWithValue("@FechaHoraEntrada", this.Entrada);
            this.comando.Parameters.AddWithValue("@FechaHoraSalida", this.Salida);
            this.comando.Parameters.AddWithValue("@CIPersona", this.CI);
            this.comando.Prepare();
            this.comando.ExecuteNonQuery();
        }


        //***************************************************************************************************************************************************
        /*
        public void Obtener(int CI)
        {
            obtenerFilaPorCI(CI);
            llenarCamposDesdeDataReader();

        } 
        */
        private void llenarCamposDesdeDataReader()
        {
            this.CI = Int32.Parse(this.dataReader["CIPersona"].ToString());
            this.Entrada = this.dataReader["FechaHoraEntrada"].ToString();
            this.Salida = this.dataReader["FechaHoraSalida"].ToString();
        }

     /*   
        private void obtenerFilaPorCI(int CI)
        {
            this.comando.CommandText = "SELECT * FROM marca WHERE CI = @CIPersona";
            this.comando.Parameters.AddWithValue("@CIPersona", this.CI);
            this.comando.Prepare();
            this.dataReader = this.comando.ExecuteReader();
            this.dataReader.Read();
        }
      */
        
        public List<ModeloRegistro> Obtener(int CI)
        {
            List<ModeloRegistro> Registro = obtenerTodasLasFilas(CI);
            crearArrayPais(Registro);
            return Registro;

        }
        
        private void crearArrayPais(List<ModeloRegistro> Registro)
        {
            while (this.dataReader.Read())
            {
                ModeloRegistro p = new ModeloRegistro();
                p.CI = Int32.Parse(dataReader["CIPersona"].ToString());
                p.Entrada = dataReader["FechaHoraEntrada"].ToString();
                p.Salida = dataReader["FechaHoraSalida"].ToString();
                Registro.Add(p);
            }
        }
        
        private List<ModeloRegistro> obtenerTodasLasFilas(int CI)
        {
            List<ModeloRegistro> Registro = new List<ModeloRegistro>();
            this.comando.CommandText = "SELECT * FROM marca where CIPersona = @CIPersona";
            comando.Parameters.AddWithValue("@CIPersona", CI);
            this.dataReader = this.comando.ExecuteReader();
            return Registro;
        }

    }
}

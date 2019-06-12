using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary_BaseDeDatos
{
    public class AccesoDatos
    {

        private SqlConnection _conexion;
        private SqlCommand _comando;

        public AccesoDatos()
        {
            this._conexion = new SqlConnection(Properties.Settings.Default.Coneccion_db);          
        }
        #region Metodos
        public List<Persona> TraerTodos()
        {
            List < Persona > personas = new List<Persona>();
            this._comando = new SqlCommand();
            this._comando.Connection = this._conexion; //
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "SELECT id, nombre, apellido, edad   FROM [Padron].[dbo].[Personas]";
            
            try
            {
                this._conexion.Open();
                SqlDataReader sqlReader= this._comando.ExecuteReader();
                while(sqlReader.Read())
                {
                    /*int auxId = (int)sqlReader["Id"];
                    string auxNombre =sqlReader["Nombre"].ToString(); // sqlReader[0] Tambien se puede por indice de objeto que accedera al registro de la base de datos (columna 0, )
                    string auxApellido =sqlReader["Apellido"].ToString();
                    int auxEdad = (int)sqlReader["Edad"];
                    

                    Persona p = new Persona(auxId, auxNombre, auxApellido, auxEdad);
                    personas.Add(p);*/
                    personas.Add(new Persona((int)sqlReader["id"], sqlReader["nombre"].ToString(), sqlReader["apellido"].ToString(), (int)sqlReader["edad"]));

                }
                this._conexion.Close();
            }
            catch (Exception e)
            {
               // Console.Write(e.ToString());
            }

            return personas;
        }

        public bool AgregarPersona (Persona p)
        {
            List<Persona> listaPersona = new List<Persona>();
            bool retorno = false;
            this._comando = new SqlCommand();
            this._comando.Connection = this._conexion; //
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "INSERT INTO [Padron].[dbo].[Persona](nombre, apellido, edad) VALUES ('" + p._nombre + "','" + p._apellido + "'," + p._edad.ToString() + ")";

            try
            {
                this._conexion.Open();
                int i = this._comando.ExecuteNonQuery();
                if(i>0)
                {
                    retorno = true;
                }
                this._conexion.Close();
            }
            catch
            {

            }
            return retorno;
        }
        public bool ModificarPersona(Persona p)
        {
            List<Persona> listaPersona = new List<Persona>();
            bool retorno = false;
            this._comando = new SqlCommand();
            this._comando.Connection = this._conexion; //
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "UPDATE [Padron].[dbo].[Persona] SET nombre= ('" + p._nombre + "',apellido='" + p._apellido + "',edad=" + p._edad.ToString() + ")";

            try
            {
                this._conexion.Open();
                int i = this._comando.ExecuteNonQuery();
                if (i > 0)
                {
                    retorno = true;
                }
                this._conexion.Close();
            }
            catch
            {

            }


            return retorno;

        }
        public bool EliminarPersona(Persona p)
        {
            List<Persona> listaPersona = new List<Persona>();
            bool retorno = false;
            this._comando = new SqlCommand();
            this._comando.Connection = this._conexion; //
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "DELETE FROM [Padron].[dbo].[Persona] WHERE id= ('" + p._id +"')";

            try
            {
                this._conexion.Open();
                int i = this._comando.ExecuteNonQuery();
                if (i > 0)
                {
                    retorno = true;
                }
                this._conexion.Close();
            }
            catch
            {

            }


            return retorno;

        }
        public DataTable TraerTablaPersona()
        {
            DataTable dataTable = new DataTable("Padron.dbo.Personas");
            
            List<Persona> personas = new List<Persona>();
            this._comando = new SqlCommand();
            this._comando.Connection = this._conexion; 
            this._comando.CommandType = CommandType.Text;



            this._comando.CommandText = "SELECT id, nombre, apellido, edad   FROM [Padron].[dbo].[Personas]";

            //dataTable.Load(dataTable);

            try
            {
                this._conexion.Open();
                SqlDataReader dataReader = this._comando.ExecuteReader();
                dataTable.Load(dataReader);

                this._conexion.Close();
            }
            catch
            {

            }
            return dataTable;
        }
        #endregion
    }
}

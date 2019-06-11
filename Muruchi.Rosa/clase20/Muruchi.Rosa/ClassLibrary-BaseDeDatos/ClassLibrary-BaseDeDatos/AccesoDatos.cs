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
            List < Persona > personas = null;
            this._comando = new SqlCommand();
            this._comando.Connection = this._conexion; //
            this._comando.CommandType = System.Data.CommandType.Text;
            this._comando.CommandText = "SELECT id, nombre, apellido, edad   FROM Patron.dbo.Personas";
            
            try
            {
                this._conexion.Open();
                SqlDataReader sqlReader= this._comando.ExecuteReader();
                while(sqlReader.Read())
                {
                    int auxId = (int)sqlReader["Id"];
                    string auxNombre =(string) sqlReader["Nombre"]; // sqlReader[0] Tambien se puede por indice de objeto que accedera al registro de la base de datos (columna 0, )
                    string auxApellido =(string) sqlReader["Apellido"];
                    int auxEdad = (int)sqlReader["Edad"];
                    

                    Persona p = new Persona(auxId, auxNombre, auxApellido, auxEdad);
                    personas.Add(p);
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
            bool retorno = false;
            this._comando = new SqlCommand();
            this._comando.Connection = this._conexion; //
            this._comando.CommandType = System.Data.CommandType.Text;
            //this._comando.CommandText = "INSERT INTO Patron.dbo.Personas (nombre, apellido, edad)  VALUES ('" +   )";

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
        #endregion
    }
}

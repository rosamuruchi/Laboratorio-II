using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class PaqueteDAO
    {
        #region Atributos
        private static SqlCommand comando;
        private static SqlConnection conexion;
        #endregion

        #region Constructor
        static PaqueteDAO()
        {           
            PaqueteDAO.conexion = new SqlConnection(Properties.Settings.Default.conexion);
            PaqueteDAO.comando = new SqlCommand();
        }
        #endregion

        #region Metodo
        /// <summary>
        /// Metodo estatico que Inserta un paquete en la Base de Datos
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Devuelve true si inserto el paquete, caso contrario false</returns>
        public static bool Insertar(Paquete p)
        {
            bool retorno = false;
            PaqueteDAO.comando.CommandType = CommandType.Text;
            PaqueteDAO.comando.CommandText= String.Format("INSERT INTO Paquetes values('{0}','{1}','{2}')", p.DireccionEntrega, p.TrackingID, "Muruchi Rosa");
            PaqueteDAO.comando.Connection = PaqueteDAO.conexion;
            try
            {
                PaqueteDAO.conexion.Open();
                PaqueteDAO.comando.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if(!(conexion is null))
                {
                    PaqueteDAO.conexion.Close();
                }
            }

            return retorno;
        }
        #endregion
    }
}

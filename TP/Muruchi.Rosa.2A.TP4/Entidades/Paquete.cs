using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        #region Atributos
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;
        #endregion

        #region Delegados
        public event DelegadoEstado InformarEstado;

        public delegate void DelegadoEstado(object sender, EventArgs e);
        #endregion

        #region Propiedades
        public string DireccionEntrega
        {
            get { return this.direccionEntrega; }
            set { this.direccionEntrega = value; }
        }
        public EEstado Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        public string TrackingID
        {
            get { return this.trackingID; }
            set { this.trackingID = value; }
        }
        #endregion

        #region Constructor
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Hace que el paquete cambie de Estado
        /// </summary>
        public void MockCicloDeVida()
        {
            while (this.estado != EEstado.Entregado)
            {
                Thread.Sleep(4000);
                this.estado++;
                this.InformarEstado(this.estado, EventArgs.Empty);
            } 
            try
            {
                if (this.estado == EEstado.Entregado)
                {
                    PaqueteDAO.Insertar(this);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        /// <summary>
        /// Muestra los Datos del paquete
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns>Devuelve una cadena con la informacion del paquete</returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete p = (Paquete)elemento;
            return string.Format("{0} para {1}", p.trackingID, p.direccionEntrega);
        }
        /// <summary>
        /// Sobrecarga ToString de Paquete
        /// </summary>
        /// <returns>Devuelve String con informacion del paquete</returns>
        public override string ToString()
        {
            return this.MostrarDatos(this);
        }
        /// <summary>
        /// Sobrecarga de Operador == de Dos paquetes si tienen el mismo trackingID
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>Devuelve Verdadero si son iguales, caso contrario false</returns>
        public static bool operator == (Paquete p1, Paquete p2)
        {
            bool retorno = false;
            if(p1.trackingID == p2.trackingID)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }
        #endregion

        #region Enumerado
        public enum EEstado { Ingresado, EnViaje, Entregado}
        #endregion
    }
}

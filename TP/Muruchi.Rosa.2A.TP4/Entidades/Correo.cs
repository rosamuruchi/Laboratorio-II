using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        #region Atributos
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;
        #endregion

        #region Propiedades
        public List<Paquete> Paquetes
        {
            get { return this.paquetes; }
            set { this.paquetes = value; }
        }
        #endregion
        #region Constructor
        public Correo()
        {
            this.Paquetes = new List<Paquete>();
            this.mockPaquetes = new List<Thread>();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Cierra todos los Hilos si estan abiertos
        /// </summary>
        public void FinEntregas()
        {
            foreach(Thread hilo in this.mockPaquetes)
            {
                if(hilo.IsAlive)
                {
                    hilo.Abort();
                }
            }
        }
        /// <summary>
        /// Muestra todos los paquetes de un Correo
        /// </summary>
        /// <param name="elementos"></param>
        /// <returns>devuelve la cadena con informacion del paquete</returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            List<Paquete> paquetes = (List<Paquete>)((Correo)elementos).Paquetes;
            StringBuilder sb = new StringBuilder();

            foreach(Paquete p in paquetes)
            {
                sb.AppendLine(string.Format("{0} para {1} ({2}) \n", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()));
            }
            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga de Operador que agrega un paquete en la lista de Correo
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns>Devuelve el correo con el paquete agregado</returns>
        public static Correo operator + (Correo c, Paquete p)
        {
            foreach(Paquete paquete in c.paquetes)
            {
                if(paquete == p)
                {
                    throw new TrackingIdRepetidoException(String.Format("\nEl TrackingID {0} ya figura en la lista de Envios",p.TrackingID));
                }
            }
            c.paquetes.Add(p);
            Thread hilo = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(hilo);
            hilo.Start();
            return c;
        }
        #endregion
    }
}

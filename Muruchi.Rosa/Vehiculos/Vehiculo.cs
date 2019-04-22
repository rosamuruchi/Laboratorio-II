using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Vehiculo
    {
        protected string patente;
        protected EMarca marca;
        protected Byte cantidadRuedas;



        protected string MostrarVehiculo()
        {
            return this.patente.ToString() + "-" + this.marca.ToString() + "-" + this.cantidadRuedas.ToString();
        }

        public Vehiculo(string cadena ,Byte num, EMarca marca)
        {
            this.cantidadRuedas = num;
            this.marca = marca;
            this.patente = cadena;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;
            if (Equals(v1, null) && Equals(v2, null))
            {
                retorno = true;
            }
            else
            {
                if (!Equals(v1, null) && !Equals(v2, null))
                {
                    if ( v1.marca == v2.marca &&  v1.patente == v2.patente)
                    {
                        retorno = true;
                    }
                }
                else
                {
                    retorno = false;
                }
            }
            return retorno;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}

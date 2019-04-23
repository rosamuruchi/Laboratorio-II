using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public abstract class Vehiculo
    {
        protected string _patente;
        protected EMarca _marca;
        protected Byte cantidadRuedas;

        protected double _precio;

        public abstract double Precio
        {
            get;  set;
        }

        public string patente
        {
            get { return this._patente; }
            set { this._patente = value; }
        }

        public string marca
        {
            get { return this._marca; }
            set { this._marca = value; }
        }

        public abstract double CalcularPrecioConIva();

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

        public override string ToString()
        {
            return this.MostrarVehiculo();
        }

        
    }
}

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
        protected Byte _cantidadRuedas;
        protected double _precio;
        //Propiedades
        public abstract double Precio
        {
            get;  set;
        }

        public string patente
        {
            get { return this._patente; }
            set { this._patente = value; }
        }

        public EMarca marca
        {
            get { return this._marca; }
            set { this._marca = value; }
        }

        public Byte Ruedas
        {
            get { return this._cantidadRuedas; }
            set { this._cantidadRuedas = value; }
        }

        public abstract double CalcularPrecioConIva();

        protected string MostrarVehiculo()
        {
            return this._patente.ToString() + "-" + this._marca.ToString() + "-" + this._cantidadRuedas.ToString();
        }

        public Vehiculo(string cadena ,Byte num, EMarca marca)
        {
            this._cantidadRuedas = num;
            this._marca = marca;
            this._patente = cadena;
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
                    if ( v1._marca == v2._marca &&  v1._patente == v2._patente)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vehiculos
{
    public class Auto : Vehiculo
    {
        protected int cantidadAsientos;

        public override double Precio
        {
            get { return base._precio; }
            set { base._precio = value; }
        }

        public override double CalcularPrecioConIva()
        {
            return base._precio * 0.21 + this._precio;
        }

        public string MostrarAuto()
        {
            return base.MostrarVehiculo() + "-" + this.cantidadAsientos.ToString();
        }

        public Auto(string cadena, Byte num, EMarca marca,int asientos) :base(cadena,num,marca)
        {
            this.cantidadAsientos = asientos;
        }

        public override string ToString()
        {
            return this.MostrarAuto();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Camion : Vehiculo
    {
        protected float tara;

        public override double Precio
        {
            get { return base._precio; }
            set { base._precio = value; }
        }

        public override double CalcularPrecioConIva()
        {
            return base._precio * 0.21 + this._precio;
        }

        public string MostrarCamion ()
        {
            return base.MostrarVehiculo() + "-" + this.tara.ToString();
        }

        public Camion (string cadena, Byte num, EMarca marca, float tara) : base(cadena, num, marca)
        {
            this.tara = tara;
        }
        public override string ToString()
        {
            return this.MostrarCamion();
        }
    }
}

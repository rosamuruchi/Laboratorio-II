using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Moto : Vehiculo
    {
        protected float cilindrada;

        public override double Precio {
            get { return base._precio; }
            set { base._precio = value; }
        }

        public override double CalcularPrecioConIva ()
        {
            return base._precio * 0.21 + this._precio;
        }

        public string MostrarMoto()
        {
            return base.MostrarVehiculo() + "-" + this.cilindrada.ToString();
        }

        public Moto (string cadena, Byte num, EMarca marca, float cilindros) : base(cadena, num, marca)
        {
            this.cilindrada = cilindros;
        }

        public override string ToString()
        {
            return this.MostrarMoto();
        }
    }
}

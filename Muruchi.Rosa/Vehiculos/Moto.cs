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

        public string MostrarMoto()
        {
            return base.MostrarVehiculo() + "-" + this.cilindrada.ToString();
        }

        public Moto (string cadena, Byte num, EMarca marca, float cilindros) : base(cadena, num, marca)
        {
            this.cilindrada = cilindros;
        }
    }
}

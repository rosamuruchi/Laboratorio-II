using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Importador :Comercio
    {
        public EPaises paisOrigen;

        public Importador(string nombreComercio, float precioAlquiler, Comerciante comerciante , EPaises paisOrigen):base(nombreComercio,comerciante,precioAlquiler)
        {
            this.paisOrigen = paisOrigen;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine((string)this);
            sb.AppendFormat("Tipo: {0}\n", this.paisOrigen.ToString());

            return sb.ToString();
        }
        public static implicit operator double(Importador n)
        {
            return n._precioAlquiler;
        }
        public static bool operator ==(Importador a, Importador b)
        {
            bool retorno = false;

            if (a.paisOrigen == b.paisOrigen && (Comercio)a == (Comercio)b )
            {
                retorno = true;
            }

            return retorno;
        }
        public static bool operator !=(Importador a, Importador b)
        {
            return !(a == b);
        }
    }
}

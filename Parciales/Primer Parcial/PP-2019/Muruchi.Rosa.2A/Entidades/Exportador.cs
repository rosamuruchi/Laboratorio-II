using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Exportador :Comercio
    {
        public ETipoProducto tipo;

        public Exportador( string nombreComercio, float precioAlquiler, string nombre, string apellido,ETipoProducto tipo) :base(precioAlquiler,nombreComercio,nombre,apellido)
        {
            this.tipo = tipo;
        }
        public string Mostrar ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine((string)this);
            sb.AppendFormat("Tipo :{0}\n", this.tipo.ToString());

            return sb.ToString();
        }
        public static implicit operator double(Exportador m)
        {
            return m._precioAlquiler;
        }
        public static bool operator ==(Exportador a, Exportador b)
        {
            bool retorno = false;

            if (a.tipo == b.tipo && (Exportador)a == (Exportador)b)
            {
                retorno = true;
            }

            return retorno;
        }
        public static bool operator !=(Exportador a, Exportador b)
        {
            return !(a == b);
        }
    }
}

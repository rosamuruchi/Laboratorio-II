using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manual :Libro
    {
        public ETipo _tipo;

        /*public enum ETipo
        {
            Tecnico,
            Escolar,
            Finanzas
        }*/

        public Manual (string titulo, float precio, string nombre, string apellido, ETipo tipo):base(precio,titulo,nombre,apellido)
        {
            this._tipo = tipo;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine((string)this);
            sb.AppendFormat("TIPO :{0}\n", this._tipo.ToString());

            return sb.ToString();
        }
        public static implicit operator double (Manual m)
        {
            return m._precio;
        }
        public static bool operator == (Manual a, Manual b)
        {
            bool retorno = false;

            if(a._tipo == b._tipo && (Libro)a == (Libro)b)
            {
                retorno = true;
            }

            return retorno;
        }
        public static bool operator !=(Manual a, Manual b)
        {
            return !(a == b);
        }
    }
}

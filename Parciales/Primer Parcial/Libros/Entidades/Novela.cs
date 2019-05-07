using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Novela :Libro
    {
        public EGenero _genero;

        /*public enum EGenero
        {
            Accion,
            Romantica,
            CienciaFiccion
        }*/

        public Novela(string titulo, float precio, Autor autor, EGenero genero):base(titulo,autor,precio)
        {
            this._genero = genero;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine( (string)this);
            sb.AppendFormat("GENERO: {0}\n", this._genero.ToString());

            return sb.ToString();
        }
        public static implicit operator double(Novela n)
        {
            return n._precio;
        }
        public static bool operator ==(Novela a, Novela b)
        {
            bool retorno = false;

            if (a._genero == b._genero && (Libro)a == (Libro)b)
            {
                retorno = true;
            }

            return retorno;

        }
        public static bool operator !=(Novela a, Novela b)
        {
            return !(a == b);
        }

    }
}

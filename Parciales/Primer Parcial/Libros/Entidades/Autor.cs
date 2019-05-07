using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        private string _apellido;
        private string _nombre;

        public Autor (string nombre, string apellido)
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }

        public static implicit operator string (Autor a)
        {
            return a._nombre + "-" + a._apellido;
        }
        public static bool operator == (Autor a, Autor b)
        {
            bool retorno = false;
            if (Equals(a, null) && Equals(b, null))
            {
                retorno = true;
            }
            else
            {
                if (!Equals(a, null) && !Equals(b, null))
                {
                    if (a._nombre == b._nombre && a._apellido == b._apellido)
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
        public static bool operator !=(Autor a, Autor b)
        {
            return !(a == b);
        }
    }
}

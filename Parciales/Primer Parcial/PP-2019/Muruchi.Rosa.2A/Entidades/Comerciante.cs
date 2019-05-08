using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comerciante
    {
        private string _apellido;
        private string _nombre;

        public Comerciante(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }    
        public static bool operator == (Comerciante a, Comerciante b)
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
        public static bool operator !=(Comerciante a, Comerciante b)
        {
            return !(a == b);
        }
        public static implicit operator string(Comerciante a)
        {
            return a._nombre + "-" + a._apellido;
        }
    }
}

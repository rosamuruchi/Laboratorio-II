using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muruchi.Rosa._2A
{
    public class Perro : Mascota
    {
        private int _edad;
        private bool _esAlfa;

        public Perro (string nombre, string raza):this(nombre,raza,0,false)
        {
  
        }
        public Perro (string nombre, string raza, int edad, bool esAlfa) :base(nombre,raza)
        {
            this._edad = edad;
            this._esAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            string cadena;
            if(this._esAlfa==true)
            {
                cadena = base.nombre + base.raza + "Alfa de la manada" + this._edad;
            }
            else
            {
                cadena = base.nombre + base.raza + "," + this._edad;
            }
            return cadena;
        }
        public static bool operator == (Perro p1, Perro p2)
        {
            bool retorno = false;
            if (Equals(p1, null) && Equals(p2, null))
            {
                retorno = true;
            }
            else
            {
                if (!Equals(p1, null) && !Equals(p2, null))
                {
                    if (p1._edad == p2._edad && p1.nombre == p2.nombre && p1.raza == p2.raza)
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
        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator int (Perro p)
        {
            return p._edad;
        }
        
        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muruchi.Rosa._2A
{
    public class Gato : Mascota
    {
        public Gato (string nombre, string raza):base(nombre,raza)
        {

        }

        protected override string Ficha()
        {
            return this.DatosCompletos();
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            bool retorno = false;
            if (Equals(g1, null) && Equals(g2, null))
            {
                retorno = true;
            }
            else
            {
                if (!Equals(g1, null) && !Equals(g2, null))
                {
                    if (g1.nombre == g2.nombre && g1.raza == g2.raza)
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
        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
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

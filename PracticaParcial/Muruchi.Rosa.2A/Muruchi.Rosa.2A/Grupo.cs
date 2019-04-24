using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muruchi.Rosa._2A
{
    public class Grupo
    {
        private List<Mascota> _manada;
        private string _nombre;
        private static EtipoManada _tipo;

        public static EtipoManada tipo
        {
            set { Grupo._tipo = value; }
        }

        static Grupo ()
        {
            Grupo._tipo = EtipoManada.Unica;
        }
        private Grupo ()
        {
            this._manada = new List<Mascota>();
        }
        
        public Grupo (string nombre) :this()
        {
            this._nombre = nombre;
        }
        public Grupo (string nombre, EtipoManada tipo):this(nombre)
        {
            Grupo._tipo = tipo;
        }

        public static bool operator ==(Grupo g, Mascota m)
        {
            bool retorno = false;
            foreach (Mascota item in g._manada)
            {
                if (m == item)
                {
                    retorno = true;
                    break;

                }
            }
            return retorno;

        }
        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        public static Grupo operator + (Grupo g, Mascota m)
        {
            if(g != m)
            {
                g._manada.Add(m);
            }
            else
            {
                Console.WriteLine("Ya esta el {0} en el grupo ", m);
            }
            return g;
        }
        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g == m)
            {
                g._manada.Add(m);
            }
            else
            {
                Console.WriteLine("No esta el {0} en el grupo ", m);
            }
            return g;
        }

        public static implicit operator string (Grupo g)
        {
            string cadena = "Grupo : " + g._nombre + "-" + Grupo._tipo.ToString() + "\nIntegrandes (" + g._manada.LongCount() + "): \n" ;

            foreach (Mascota m in g._manada)
            {
                cadena += m.ToString() + "\n";
            }

            return cadena;
        }
    }
}

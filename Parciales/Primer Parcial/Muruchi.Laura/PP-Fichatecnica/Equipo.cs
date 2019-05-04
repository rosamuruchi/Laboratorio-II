using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Fichatecnica
{
    public class Equipo
    {
        private List<Jugador> _jugadores;
        private DirectorTecnico _dt;
        private static Deportes _deporte;
        private string _nombre;

        public static Deportes Deportes
        {
            set { Equipo._deporte = value; }
        }

         static Equipo()
        {
            Deportes =Deportes.Futbol;
        }
        private Equipo()
        {
            this._jugadores = new List<Jugador>();
        }
        private Equipo(string nombre, DirectorTecnico dt)
        {
            this._nombre = nombre;
            this._dt = dt;
        }
        private Equipo(string nombre, DirectorTecnico dt,Deportes deporte):this(nombre,dt)
        {
            Deportes = deporte;
        }
        public static implicit operator string (Equipo e)
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendFormat("**{0} {1}**", e._nombre,Equipo._deporte);
            cadena.AppendLine("Nomina de Jujadores: ");

            foreach(Jugador j in e._jugadores)
            {
                cadena.AppendLine(j.ToString());

            }
            cadena.AppendFormat("Dirigido por: {0} ", e._dt);

            return cadena.ToString();
        }
        public static bool operator == (Equipo e, Jugador j)
        {
            bool retorno = false;
            foreach (Jugador item in e._jugadores)
            {
                if (j == item)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if(e != j)
            {
                e._jugadores.Add(j);
            }
            return e;
        }
        public static Equipo operator -(Equipo e, Jugador j)
        {
            if (e == j)
            {
                e._jugadores.Remove(j);
            }
            return e;
        }
    }
}

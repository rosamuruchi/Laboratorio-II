using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Fichatecnica
{
    public class Jugador : Persona
    {
        private bool _esCapitan;
        private int _numero;

        public bool EsCapitan
        {
            get { return this._esCapitan; }
            set { this._esCapitan = value; }
        }
        public int Numero
        {
            get { return this._numero; }
            set { this._numero = value; }
        }

        public Jugador (string nombre, string apellido):base(nombre,apellido)
        {
            this._numero = 0;
            this._esCapitan = false;
        }
        public Jugador(string nombre, string apellido, int numero):this(nombre,apellido)
        {
           
        }

        protected override string FichaTecnica()
        {
            string cadena = "";
            string nombreComp = this.NombreCompleto();

            if(this._esCapitan==true)
            {
                cadena= nombreComp + ",Capitan del equipo, camiseta numero " + this.Numero.ToString();
            }
            else
            {
                cadena =nombreComp + this.Numero.ToString();
            }
            return cadena;
        }
        public override string ToString()
        {
            return this.FichaTecnica();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public static explicit operator int (Jugador jugador)
        {
            return jugador.Numero;
        }
        
        public static bool operator == (Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if (Equals(j1, null) && Equals(j2, null))
            {
                retorno = true;
            }
            else
            {
                if (!Equals(j1, null) && !Equals(j2, null))
                {
                    if (j1.Nombre ==j2.Nombre && j1.Apellido ==j2.Apellido && j1._numero == j2._numero)
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
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

    }
}

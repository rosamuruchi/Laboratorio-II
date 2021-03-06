﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        public Universitario()
        {

        }
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad):base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Universitario && ((Universitario)obj == this))
            {
                retorno =true;

            }
            return retorno;
        }
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendFormat("LEGAJO NUMERO: {0}", this.legajo);
            return sb.ToString();
        }

        protected abstract string ParticiparEnClase();

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool retorno = false;
            if((pg1.legajo==pg2.legajo || pg1.DNI==pg2.DNI)) 
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
    }
}

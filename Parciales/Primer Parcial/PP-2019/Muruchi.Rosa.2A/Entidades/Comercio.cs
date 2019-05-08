using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comercio
    {
        protected int _cantidadDeEmpleados;
        protected Comerciante _comerciante;
        protected static Random _generadorDeEmpleados;
        protected string _nombre;
        protected float _precioAlquiler;

        public int CantidadDeEmpleados
        {
            get
            {
                if(this._cantidadDeEmpleados==0)
                {
                    this._cantidadDeEmpleados = Comercio._generadorDeEmpleados.Next(1, 100);
                }
                return this._cantidadDeEmpleados;
            }
        }

        static Comercio()
        {
            Comercio._generadorDeEmpleados = new Random();
        }
        public Comercio (float precioAlquiler, string nombreComercio, string nombre, string apellido):this(nombreComercio,new Comerciante(nombre,apellido),precioAlquiler)
        {

        }
        public Comercio (string nombre, Comerciante comerciante, float precioAlquiler)
        {
            this._nombre = nombre;
            this._comerciante = comerciante;
            this._precioAlquiler = precioAlquiler;
        }
        private static string Mostrar(Comercio c)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("NOMBRE: {0}\n", c._nombre);
            sb.AppendFormat("CANT DE EMPLEADOS: {0}\nCOMERCIANTE:", c.CantidadDeEmpleados);

            sb.AppendLine(c._comerciante);
            sb.AppendFormat("PRECIO ALQUILER: {0}", c._precioAlquiler);

            return sb.ToString();
        }
        public static explicit operator string(Comercio c)
        {
            return Comercio.Mostrar(c);
        }
        public static bool operator ==(Comercio a, Comercio b)
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
                    if (a._comerciante == b._comerciante && a._nombre == b._nombre)
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
        public static bool operator !=(Comercio a, Comercio b)
        {
            return !(a == b);
        }
    }
}

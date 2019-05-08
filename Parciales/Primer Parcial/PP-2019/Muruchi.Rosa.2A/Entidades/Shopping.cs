using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Shopping
    {
        private int _capacidad;
        private List<Comercio> _comercios;

        public double PrecioDeExportadores
        {
            get
            {
                return this.ObtenerPrecio(EComercio.Exportador);
            }
        }
        public double PrecioDeImportadores
        {
            get
            {
                return this.ObtenerPrecio(EComercio.Importador);
            }
        }
        public double PrecioTotal
        {
            get
            {
                return this.ObtenerPrecio(EComercio.Importador) + this.ObtenerPrecio(EComercio.Exportador);
            }
        }

        private Shopping()
        {
            this._comercios = new List<Comercio>();
        }
        private Shopping(int capacidad):this()
        {
            this._capacidad = capacidad;
        }
        public static string Mostrar(Shopping s)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad del Shopping {0}\n", s._capacidad);
            sb.AppendFormat("Total por Importadores: {0}\n", s.PrecioDeImportadores);
            sb.AppendFormat("Total por Exportadores: {0}\n", s.PrecioDeExportadores);
            sb.AppendFormat("Total: {0}\n", s.PrecioTotal);
            sb.AppendLine("***********************");
            sb.AppendLine("LISTADO DE COMERCIOS");
            sb.AppendLine("***********************");


            foreach (Comercio comercio in s._comercios)
            {
                if (comercio is Importador)
                {
                    sb.AppendLine(((Importador)comercio).Mostrar());
                }
                if (comercio is Exportador)
                {
                    sb.AppendLine(((Exportador)comercio).Mostrar());
                }

            }
            return sb.ToString();
        }
        public static implicit operator Shopping (int capacidad)
        {

            return new Shopping(capacidad);
        }
        public static bool operator ==(Shopping s, Comercio c)
        {
            bool retorno = false;
            foreach (Comercio item in s._comercios)
            {
                if (item == c)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Shopping s, Comercio c)
        {
            return !(s == c);
        }
        public static Shopping operator +(Shopping s, Comercio c)
        {
            if (s._comercios.Count < s._capacidad)
            {
                if (s != c)
                {
                    s._comercios.Add(c);
                }
                else
                {
                    Console.WriteLine("El Comercio ya esta en el Shopping!!!");
                }
            }
            else
            {
                Console.WriteLine("No hay mas lugar en el Shopping!!!");

            }
            return s;

        }
        private double ObtenerPrecio(EComercio tipoComercio)
        {
            double retorno = 0;
            foreach (Comercio c in this._comercios)
            {
               
                switch (tipoComercio)
                {
                    case EComercio.Importador:
                        if (c is Importador)
                        {
                            
                            retorno += (Importador)c;
                        }

                        break;
                    case EComercio.Exportador:
                        if (c is Exportador)
                        {
                            retorno += (Exportador)c;
                        }

                        break;
                    default:
                        break;
                }
            }
            return retorno;
        }
    }
}

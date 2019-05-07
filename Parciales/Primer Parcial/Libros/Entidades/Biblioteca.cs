using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        private int _capacidad;
        private List<Libro> _libros;

        public double PrecioDeManuales
        {
            get
            {
                return this.ObtenerPrecio(ELibro.Manual);
            }
        }
        public double PrecioDeNovelas
        {
            get
            {
                return this.ObtenerPrecio(ELibro.Novela);
            }
        }
        public double PrecioTotal
        {
            get
            {
                return this.ObtenerPrecio(ELibro.Manual) + this.ObtenerPrecio(ELibro.Novela);
            }
        }
        public enum ELibro
        {
            Manual,
            Novela,
            Ambos
        }
        private Biblioteca()
        {
            this._libros = new List<Libro>();
        }
        private Biblioteca(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }
        public static string Mostrar(Biblioteca e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad de la Biblioteca {0}\n", e._capacidad);
            sb.AppendFormat("Total por Manuales: {0}\n", e.PrecioDeManuales);
            sb.AppendFormat("Total por Novelas: {0}\n", e.PrecioDeNovelas);
            sb.AppendFormat("Total: {0}\n", e.PrecioTotal);
            sb.AppendLine("***********************");
            sb.AppendLine("LISTADO DE LIBROS");
            sb.AppendLine("***********************");


            foreach (Libro libro in e._libros)
            {
                if(libro is Manual)
                {
                    sb.AppendLine(((Manual)libro).Mostrar());
                }
                if(libro is Novela)
                {
                    sb.AppendLine(((Novela)libro).Mostrar());
                }
                
            }
            return sb.ToString();
        }
        private double ObtenerPrecio(ELibro tipoLibro)
        {
            double retorno = 0;
            foreach (Libro l in this._libros)
            {
                //Manual m;
                switch (tipoLibro)
                {
                    case ELibro.Manual:
                        if (l is Manual)
                        {
                            //m = (Manual)l;
                            retorno += (Manual)l;
                        }

                        break;
                    case ELibro.Novela:
                        if(l is Novela)
                        {
                            retorno += (Novela)l;
                        }
                        
                        break;
                    default:
                        break;
                }
            }
            return retorno;
        }
        public static bool operator ==(Biblioteca e, Libro l)
        {
            bool retorno = false;
            foreach (Libro item in e._libros)
            {
                if (item == l)// falta separar por casos de manual y novela;
                {
                    if(l is Manual && item is Manual )
                    {
                        if((Manual)l == (Manual)item)
                        {
                            retorno = true;
                            break;
                        }
                    }
                    if(l is Novela && item is Novela)
                    {
                        if((Novela)l == (Novela)item)
                        {
                            retorno = true;
                            break;
                        }
                    }
                }

            }
            return retorno;
        }
        public static bool operator !=(Biblioteca e, Libro l)
        {
            return !(e == l);
        }
        public static Biblioteca operator +(Biblioteca e, Libro l)
        {
            if (e._libros.Count < e._capacidad)
            {
                if (e != l)
                {
                    e._libros.Add(l);
                }
                else
                {
                    Console.WriteLine("El Libro ya esta en la Biblioteca!!!");
                }
            }
            else
            {
                Console.WriteLine("No hay mas lugar en la Biblioteca!!!");

            }
            return e;
        }
        public static implicit operator Biblioteca(int capacidad)
        {
            return new Biblioteca(capacidad);//devuelve 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        protected Autor _autor;
        protected int _cantidadDePaginas;
        protected float _precio;
        protected string _titulo;
        protected static Random _generadorDePaginas;

        public int CantidadDePaginas
        {
            get {
                if(this._cantidadDePaginas==0)
                {
                    this._cantidadDePaginas = Libro._generadorDePaginas.Next(10, 580);
                }
                return this._cantidadDePaginas;
            }
        }

        static Libro()
        {
            Libro._generadorDePaginas = new Random();
        }
        public Libro(float precio, string titulo, string nombre, string apellido):this(titulo,(new Autor(nombre,apellido)),precio)
        {

        }
        public Libro(string titulo , Autor autor, float precio)
        {
            this._titulo = titulo;
            this._precio = precio;
            this._autor = autor;
        }

        private static string Mostrar(Libro l)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("TITULO: {0}\n", l._titulo);
            sb.AppendFormat("CANT DE PAGINAS: {0}\nAUTOR:", l.CantidadDePaginas);

            sb.AppendLine(l._autor);
            sb.AppendFormat("PRECIO: {0}", l._precio.ToString());

            return sb.ToString(); 
        }

        public static explicit operator string(Libro l)
        {
            return Libro.Mostrar(l);
        }
        public static bool operator ==(Libro a, Libro b)
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
                    if (a._titulo == b._titulo && a._autor == b._autor)
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
        public static bool operator !=(Libro a, Libro b)
        {
            return !(a == b);
        }
    }
}

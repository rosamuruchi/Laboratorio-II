using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito <T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }
        public bool Agregar (T a)
        {
            return this + a;
        }
        public bool Remover(T a)
        {
            return this - a;
        }
        private int GetIndice(T a)
        {
            int retorno = -1;
            int i = 0;

            if (this._lista.Count != 0)
            {
                foreach (T aux in this._lista)
                {
                    if (aux.Equals(a))
                    {
                        retorno = i;
                        break;
                    }
                    if (i >= this._capacidadMaxima)
                    {
                        break;
                    }
                    i++;
                }
            }

            return retorno;
        }
        public static bool operator +(Deposito<T> d, T a)
        {
            bool retorno = false;
            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
                retorno = true;
            }
            return retorno;
        }
        public static bool operator -(Deposito<T> d, T a)
        {
            bool retorno = false;
            int indice = d.GetIndice(a);
            if (indice != -1)
            {
                d._lista.Remove(d._lista[indice]);
                retorno = true;
            }

            return retorno;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad Maxima: {0}\n", this._capacidadMaxima);
            sb.AppendFormat("Listado de {0}: \n",typeof(T).Name);

            foreach (T a in this._lista)
            {
                sb.AppendFormat("{0}", a.ToString());
            }

            return sb.ToString();
        }
    }
}

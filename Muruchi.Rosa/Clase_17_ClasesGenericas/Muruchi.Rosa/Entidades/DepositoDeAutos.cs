using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos (int capacidad)
        {
            this._lista = new List<Auto>();
            this._capacidadMaxima = capacidad;
        }

        public bool Agregar (Auto a)
        {
            return this + a;
        }
        public bool Remover (Auto a)
        {
            return this - a;
        }
        private int GetIndice (Auto a)
        {
            int retorno =-1;
            int i = 0;

            if(this._lista.Count !=0)
            {
                foreach(Auto auto in this._lista)
                {
                    if(Equals (auto,a)==true)
                    {
                        retorno = i;
                        break;
                    }
                    if(i>= this._capacidadMaxima)
                    {
                        break;
                    }
                    i++;
                }
            }

            return retorno;
        }
        public static bool operator + (DepositoDeAutos d, Auto a)
        {
            bool retorno = false;
            if(d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
                retorno = true;
            }
            return retorno;
        }
        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;
            int indice = d.GetIndice(a);
            if (indice!= -1)
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
            sb.AppendLine("Listado de Autos:\n");

            foreach( Auto auto in this._lista)
            {
                sb.AppendFormat("{0}", auto.ToString());
            }

            return sb.ToString();
        }
    }
}

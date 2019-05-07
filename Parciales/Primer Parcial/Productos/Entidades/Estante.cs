using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        protected sbyte _capacidad;
        protected List<Producto> _productos;

        public float ValorEstanteTotal
        {
            get { return this.GetValorEstante(); }
        }
            

        public List<Producto> GetProductos()
        {
            return this._productos; 
        }
        private float GetValorEstante()
        {
            return GetValorEstante(ETipoProducto.Todos);
        }
        public float GetValorEstante(ETipoProducto tipo)
        {
            float retorno = 0;
            foreach (Producto prod in this._productos)
            {
                switch(tipo)
                {
                    case ETipoProducto.Galletita:
                        if(prod is Galletita)
                        {
                            retorno = prod.CalcularCostoDeProduccion;
                        }
                        break;
                    case ETipoProducto.Gaseosa:
                        if (prod is Gaseosa)
                        {
                            retorno = prod.CalcularCostoDeProduccion;
                        }
                        break;
                    case ETipoProducto.Harina:
                        if (prod is Harina)
                        {
                            retorno = prod.CalcularCostoDeProduccion;
                        }
                        break;
                    case ETipoProducto.Jugo:
                        if (prod is Jugo)
                        {
                            retorno = prod.CalcularCostoDeProduccion;
                        }
                        break;
                    case ETipoProducto.Todos:
                            retorno = prod.CalcularCostoDeProduccion;
                        
                        break;
                    default:
                        break;
                }
            }
            return retorno;

        }
        private Estante ()
        {
            this._productos = new List<Producto>();
        }
        public Estante(sbyte capacidad):this()
        {
            this._capacidad = capacidad;
        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Estante\nCantidad de espacios {0}", e._capacidad);
            foreach (Producto item in e._productos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        public static bool operator ==(Estante e, Producto prod)
        {
            bool retorno = false;
            foreach (Producto item in e._productos)
            {
                if (item == prod)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Estante e, Producto prod)
        {
            return !(e == prod);
        }
        public static bool operator + (Estante e, Producto prod)
        {
            bool retorno = false;
            if((e != prod) && ( e._capacidad - e._productos.Count >= 1))
            {
                e._productos.Add(prod);
                retorno = true;
            }
            return retorno; 
        }
        public static Estante operator -(Estante e, Producto prod)
        {
            if(e==prod)
            {
                e._productos.Remove(prod);
            }
            return e;
        }
        public static Estante operator -(Estante e, ETipoProducto tipo)
        {
            bool aux=false;
            foreach (Producto prod in e._productos)
            {
                switch (tipo)
                {
                    case ETipoProducto.Galletita:
                        if (prod is Galletita)
                        {
                            e._productos.Remove(prod);
                            aux = true;
                        }
                        break;
                    case ETipoProducto.Gaseosa:
                        if (prod is Gaseosa)
                        {
                            e._productos.Remove(prod);
                            aux = true;
                        }
                        break;
                    case ETipoProducto.Harina:
                        if (prod is Harina)
                        {
                            e._productos.Remove(prod);
                            aux = true;
                        }
                        break;
                    case ETipoProducto.Jugo:
                        if (prod is Jugo)
                        {
                            e._productos.Remove(prod);
                            aux = true;
                        }
                        break;
                    case ETipoProducto.Todos:
                        e._productos.Remove(prod);
                        aux = true;
                        break;
                }
                if(aux)
                {
                    break;
                }
            }
            return e;
        }
    }
}

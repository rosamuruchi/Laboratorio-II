using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        protected int _codigoBarra;
        protected float _precio;
        protected EMarcaProducto _marca;

        public enum EMarcaProducto { Manaos, Pitusas, Naranjú, Diversión, Swift, Favorita }
        public enum ETipoProducto { Galletita, Gaseosa, Jugo, Harina, Todos }

        public abstract float CalcularCostoDeProduccion
        {
            get;
        }
        public EMarcaProducto Marca
        {
            get { return this._marca; }
        }
        public float Precio
        {
            get { return this._precio; }
        }

        public Producto (int codigoBarra, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codigoBarra;
            this._marca = marca;
            this._precio = precio;
        }
        public virtual string Consumir()
        {
            return "Parte de una mezcla ..";
        }
        private static string MostrarProducto (Producto p)
        {
            return string.Format("\nCodigo de barras {0}\nMarca {1}\nPrecio {2}\n", p._codigoBarra, p.Marca, p.Precio);
            //return p._marca.ToString()+ "-" + p._precio.ToString()+ "-" + p._codigoBarra.ToString();
        }
        public static bool operator == (Producto prodUno, Producto prodDos)
        {
            bool retorno = false;
            if (Equals(prodUno, null) && Equals(prodDos, null))
            {
                retorno = true;
            }
            else
            {
                if (!Equals(prodUno, null) && !Equals(prodDos, null))
                {
                    if (prodUno._codigoBarra == prodDos._codigoBarra && prodUno._marca == prodDos._marca)
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
        public static bool operator !=(Producto prodUno, Producto prodDos)
        {
            return !(prodUno == prodDos);
        }
        public static bool operator ==(Producto prodUno, EMarcaProducto marca)
        {
            bool retorno = false;
            
                if (prodUno._marca == marca)
                {
                    retorno = true;

                }
            
            return retorno;
        }
        public static bool operator !=(Producto prodUno, EMarcaProducto marca)
        {
            return !(prodUno==marca);
        }
        public static implicit operator string (Producto p)
        {
            return Producto.MostrarProducto(p);
        }
        public static explicit operator int (Producto p)
        {
            return p._codigoBarra;
        }
        public override bool Equals(object obj)
        {
            return (obj is Producto && (Producto)obj == this);
        }
    }
}


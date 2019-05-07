using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Harina : Producto
    {
        private ETipoHarina _tipo;
        protected static bool DeConsumo;

        public enum ETipoHarina { CuatroCeros, TresCeros, Integral }

        public override float CalcularCostoDeProduccion
        {
            get { return this._precio * (float)0.6; }
        }

        static Harina ()
        {
            Harina.DeConsumo = false;
        }
        public Harina (int codigo, float precio, EMarcaProducto marca, ETipoHarina tipo):base(codigo,marca,precio)
        {
            this._tipo = tipo;
        }
        private string MostrarHarina()
        {
            string cadena;
            cadena = this;
            cadena += string.Format("\nTipo {0}", this._tipo);
            return cadena;
        }
        public override string ToString()
        {
            return this.MostrarHarina();
        }
    }
}

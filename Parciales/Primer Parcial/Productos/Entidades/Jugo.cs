using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugo : Producto
    {
        protected ESaborJugo _sabor;
        protected static bool DeConsumo;

        public enum ESaborJugo { Asqueroso, Pasable, Rico }

        public override float CalcularCostoDeProduccion
        {
            get { return this._precio * (float)0.4; }
        }

        static Jugo()
        {
            Jugo.DeConsumo = true;
        }
        public Jugo (int codigoBarra, float precio, EMarcaProducto marca, ESaborJugo sabor):base(codigoBarra,marca,precio)
        {
            this._sabor = sabor;
        }
        public override string Consumir()
        {
            return base.Consumir() + "Bebible";
        }
        private string MostrarJugo()
        {
            //return base.ToString()+ " " + this._sabor.ToString();
            string cadena;
            cadena = this;
            cadena += string.Format("\nSabor de jugo {0}\n", this._sabor);
            return cadena;
        }
        public override string ToString()
        {
            return this.MostrarJugo();
        }
    }
}

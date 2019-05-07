using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Galletita : Producto
    {
        protected float _peso;
        protected static bool DeConsumo;

        public override float CalcularCostoDeProduccion
        {
            get { return this._precio * (float)0.33; }
        }
        static Galletita()
        {
            Galletita.DeConsumo = true;
        }
        public Galletita (int codigoBarra, float precio, EMarcaProducto marca, float peso) :base(codigoBarra,marca,precio)
        {
            this._peso = peso;
        }
        private static string MostrarGalletita (Galletita g)
        {
            return (Producto)g + g._precio.ToString();
        }
        public override string ToString()
        {
            return Galletita.MostrarGalletita(this);
        }
        public override string Consumir()
        {
            return base.Consumir() + "Comestible";
        }
    }
}

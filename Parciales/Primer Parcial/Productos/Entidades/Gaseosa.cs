using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gaseosa : Producto
    {
        protected float _litros;
        protected static bool DeConsumo;


        public override float CalcularCostoDeProduccion
        {
            get { return this._precio * (float)0.42; }
        }
        static Gaseosa()
        {
            Gaseosa.DeConsumo = true;
        }
        public Gaseosa (int codigoBarra, float precio, EMarcaProducto marca, float litros):base(codigoBarra,marca,precio)
        {
            this._litros = litros;
        }
        public Gaseosa (Producto p, float litros):this((int)p,p.Precio,p.Marca,litros)
        {
            
        }
        private string MostrarGaseosa()
        {
            return base.ToString() + " " + this._litros.ToString();
        }
        public override string ToString()
        {
            return this.MostrarGaseosa();
        }
        public override string Consumir()
        {
            return base.Consumir() + "Bebible";
        }
    }
}

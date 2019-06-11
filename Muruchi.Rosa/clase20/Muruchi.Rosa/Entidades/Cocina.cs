using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        public int Codigo
        {
            get
            {
                return this._codigo;
            }
        }
        public bool EsIndustrial
        {
            get
            {
                return this._esIndustrial;
            }
        }
        public double Precio
        {
            get
            {
                return this._precio;
            }
        }
        public Cocina (int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._esIndustrial = esIndustrial;
            this._precio = precio;
        }
        public override bool Equals(object obj)
        {
            return (obj is Cocina && (Cocina)obj == this);
        }
        public override string ToString()
        {
            return "Codigo: " + this._codigo + "- Precio: " + this._precio+"- Es Industrial?" + this._esIndustrial + "\n";
        }
        public static bool operator == (Cocina a, Cocina b)
        {
            bool retorno = false;
            if(a.Codigo== b.Codigo && a.EsIndustrial==b.EsIndustrial && a.Precio==b.Precio)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }
    }
}

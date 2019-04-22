using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        public Pluma ()
        {
            this._cantidad = 0;
            this._marca = "Sin marca";
            this._tinta = null;
        }
        public Pluma (Tinta tinta):this()
        {
            this._tinta = tinta;
        }
        public Pluma(Tinta tinta, int cant): this(tinta)
        {
            this._cantidad = cant;
        }

        public Pluma(string marca, Tinta tinta, int cant):this(tinta,cant)
        {
            this._marca = marca;
        }

        private string mostrar()
        {
            return this._marca.ToString() + "-" + this._cantidad.ToString() + "-" + Tinta.mostrar(this._tinta);
        }

        public static bool operator ==(Pluma p1, Tinta t1)
        {
            return p1._tinta == t1;
        }
        public static bool operator !=(Pluma p1, Tinta t1)
        {
            return !(p1._tinta == t1);
        }

        public static implicit operator string (Pluma p)
        {
            return p.mostrar(); 
        }
       public static Pluma operator + (Pluma p, Tinta t)
        {
            if (p._tinta == t)
            {
                p._cantidad += 10;
                if (p._cantidad == 100)
                    p._cantidad = 100;
            }

            return p;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muruchi.Rosa._2A
{
    public abstract class Mascota
    {
        private string _raza;
        private string _nombre;

        public Mascota(string nombre, string raza)
        {
            this._nombre = nombre;
            this._raza = raza;
        }

        public string raza
        {
            get { return this._raza; }
        }
        public string nombre
        {
            get { return this._nombre; }
        }

        protected abstract string Ficha();
   

        protected virtual string DatosCompletos()
        {
            return this._nombre + " " +this._raza;
        }
    }
}

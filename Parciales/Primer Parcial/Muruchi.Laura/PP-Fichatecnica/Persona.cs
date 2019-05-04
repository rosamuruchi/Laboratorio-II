using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Fichatecnica
{
    public abstract class Persona
    {
        private string _apellido;
        private string _nombre;

        public string Apellido
        {
            get { return this._apellido; }
        }
        public string Nombre
        {
            get { return this._nombre; }
        }

        public Persona (string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }
        protected abstract string FichaTecnica();

        protected virtual string NombreCompleto()
        {
            //utilizar el metodo Format de la clase String
            return string.Format("{0} {1}",this.Nombre,this.Apellido);
        }
    }
}

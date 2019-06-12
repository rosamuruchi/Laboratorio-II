using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_BaseDeDatos
{
    public class Persona
    {
        public int _id;
        public string _nombre;
        public string _apellido;
        public int _edad;

        public Persona (int id, string nombre, string apellido, int edad)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Persona: {0}, {1}, {2}, {3}\n", this._id, this._nombre, this._apellido, this._edad);
            return sb.ToString();
            //return "id:" + this._id.ToString() + " nombre: " + this._nombre + " apellido: " + this._apellido + " edad: " + this._edad.ToString();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Xml;
using System.Xml.Serialization;

namespace EntidadesAbstractas
{
    [XmlInclude(typeof(Persona))]
    [XmlInclude(typeof(Universitario))]

    public abstract class Persona
    {
        #region METODOS
        private string apellido;
        private string nombre;
        private int dni;
        private ENacionalidad nacionalidad;
        #endregion

        #region Propiedades
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = ValidarNombreApellido(value) ; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = ValidarNombreApellido(value) ; }
        }
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = ValidarDni(this.nacionalidad, value); }
        }
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }
        public string StringToDNI
        {
            set
            {
                this.dni = this.ValidarDni(this.Nacionalidad, value);
            } 
        }
        #endregion

        #region Constructores
        public Persona() 
        {

        }
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion

        #region Validaciones
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            int retorno=-1;
            
            switch (nacionalidad)
            {
                case ENacionalidad.Argentino:
                    if (dato>0 && dato<90000000)
                    {
                        retorno = dato;
                    }
                    else
                    {
                        throw new NacionalidadInvalidaException();
                    }
                    break;
                case ENacionalidad.Extranjero:
                    if (dato >= 90000000 && dato<=99999999)
                    {
                        retorno = dato;
                    }
                    else
                    {
                        throw new NacionalidadInvalidaException();
                    }
                    break;
            }

            return retorno;
        }
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dniValido;
            if(Int32.TryParse(dato,out dniValido)==true)
            {
                if(dato.Length<9)
                {
                    dniValido = ValidarDni(nacionalidad, dniValido);
                }
                
            }
            else
            {
                throw new DniInvalidoException();
            }

            return dniValido;
        }
        private string ValidarNombreApellido(string dato)
        {
            string nombreValido = "";
            if(dato.Length>2)
            {
                foreach (char letter in dato)
                {
                    if (char.IsLetter(letter) == true)
                    {
                        nombreValido = dato;
                    }
                }
            }
            return nombreValido;
        }
        #endregion Validaciones

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("NOMBRE COMPLETO: {0}, {1}\nNACIONALIDAD:{2}\n", this.Nombre, this.Apellido, this.nacionalidad);

            return sb.ToString();
        }

        public enum ENacionalidad { Argentino, Extranjero }

    }
}


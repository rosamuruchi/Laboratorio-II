using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using System.Xml;
using System.Xml.Serialization;


namespace EntidadesInstanciables
{
    [XmlInclude(typeof(Universitario))]
    [XmlInclude(typeof(Alumno))]
    public sealed class Alumno : Universitario
    {
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        #region Constructores
        public Alumno()
        {

        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta):this(id,nombre,apellido,dni,nacionalidad,claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        protected override string ParticiparEnClase()
        {
            return "TOMA CLASE DE " + this.claseQueToma + "\n";
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendFormat("Estado de cuenta: {0}", this.estadoCuenta);
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }
        public static bool operator ==(Alumno a,Universidad.EClases clase)
        {
            bool retorno = false;
            if(a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Alumno a,Universidad.EClases clase)
        {
            return !(a.claseQueToma == clase);
        }
        #region Enumerados
        public enum EEstadoCuenta { AlDia, Deudor, Becado }
        #endregion
    }
}

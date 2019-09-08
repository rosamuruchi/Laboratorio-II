using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;


namespace EntidadesInstanciables
{
    public class Jornada
    {
        #region Metodos
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        #endregion

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get{ return this.alumnos; }
            set{ this.alumnos = value; }
        }
        public Universidad.EClases Clase
        {
            get { return this.clase; }
            set { this.clase= value; }
        }
        public Profesor Instructor
        {
            get { return this.instructor; }
            set { this.instructor = value; }
        }
        #endregion
        #region Constructores
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }
        public Jornada(Universidad.EClases clase, Profesor instructor):this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }
        #endregion
        #region Metodos
        public static bool Guardar(Jornada jornada)
        {
            Texto texto = new Texto();
            return texto.Guardar("Jornada.txt", jornada.ToString());
        }
        public static string Leer()
        {
            string cadena = "";
            Texto texto = new Texto();
            texto.Leer("Jornada.txt", out cadena);
            return cadena;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CLASE DE {0} POR {1}", this.clase.ToString(), this.instructor.ToString());
            sb.AppendLine("ALUMNOS: ");
            foreach (Alumno alumnoAux in this.Alumnos)
            {
                sb.AppendLine(alumnoAux.ToString());
            }
            sb.AppendLine("<-------------------------------------------------------------->");
            return sb.ToString();
        }
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool retorno = false;
            foreach(Alumno alumnoAux in j.alumnos)
            {
                if(alumnoAux==a)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if(j!=a)
            {
                j.alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            return j;
        }
        #endregion
    }
}

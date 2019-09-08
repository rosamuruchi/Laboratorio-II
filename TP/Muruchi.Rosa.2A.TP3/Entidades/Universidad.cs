using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

namespace EntidadesInstanciables
{
    public class Universidad
    {
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }
        public List<Jornada> Jornadas
        {
            get { return this.jornada; }
            set { this.jornada = value; }
        }
        public List<Profesor> Instructores
        {
            get { return this.profesores; }
            set { this.profesores = value; }
        }
        public Jornada this[int i]
        {
            get
            {
                if(i>=0 && i<this.jornada.Count)
                {
                    return this.jornada[i];
                }
                else
                {
                    return null;
                }
                
            }
            set
            {
                this.jornada[i] = value;
            }
        }
        #endregion
        #region Metodos
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }

        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Jornadas:");
            foreach(Jornada jAux in uni.jornada)
            {
                sb.AppendLine(jAux.ToString());
                //sb.AppendLine("<----------------------------------->");
            }
            return sb.ToString();
        }
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool retorno = false;
            foreach(Alumno alumAux in g.alumnos)
            {
                if(alumAux == a)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }
        public static bool operator ==(Universidad g, Profesor i)
        {
            bool retorno = false;
            foreach(Profesor profAux in g.profesores)
            {
                if(profAux == i)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }
        public static Profesor operator ==(Universidad g , EClases clase)
        {
            Profesor profesorAux = new Profesor();
            bool flag = false;
            for (int i = 0; i < g.profesores.Count; i++)
            {
                if (g.profesores[i] == clase)
                {
                    profesorAux = g.profesores[i];
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                throw new SinProfesorException();
            }
            return profesorAux;
        }
        public static Profesor operator !=(Universidad g, EClases clase)
        {
            Profesor profesorAux = new Profesor();
            bool flag = false;

            for(int i=0; i< g.profesores.Count; i++)
            {
                if (g.profesores[i]!=clase)
                {
                    profesorAux = g.profesores[i];
                    flag = true;
                    break;
                }
            }
            if(flag== false)
            {
                throw new SinProfesorException();
            }
            return profesorAux;
        }
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Profesor profAux = (g == clase);
            Jornada jornada = new Jornada(clase, profAux);
            bool flag = false;
            for(int i=0; i<g.alumnos.Count;i++)
            {
                if(g.alumnos[i] == clase)
                {
                    jornada += g.alumnos[i];
                    flag = true;
                }
            }
            if(flag==true)
            {
                g.jornada.Add(jornada);
            }
            return g;
        }
        public static Universidad operator +(Universidad g, Alumno a)
        {
            if(g!=a)
            {
                g.alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            return g;
        }
        public static Universidad operator +(Universidad g, Profesor i)
        {
            if (g != i)
            {
                g.profesores.Add(i);
            }
            return g;
        }        

        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            return xml.Guardar("Universidad.xml", uni);
        }
        public static Universidad Leer()
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            Universidad uDatos;
            xml.Leer("Universidad.xml", out uDatos);
            return uDatos;
        }
        #endregion
        public enum EClases { Programacion, Laboratorio, Legislacion, SPD }

    }
}

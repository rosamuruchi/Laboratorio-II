using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;
using System.IO;

namespace EntidadesInstanciables
{
    public sealed class Profesor: Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;
        #region Constructores
        public Profesor()
        {
            
        }
        static Profesor()
        {
            Profesor.random = new Random();
        }
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }
        #endregion
        private void _randomClases()
        {
            for(int i=0; i<2; i++)
            {
                int ramdom = Profesor.random.Next(0, 3);
                this.clasesDelDia.Enqueue((Universidad.EClases)ramdom);
            }
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DIA: ");
            foreach(Universidad.EClases item in this.clasesDelDia)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool retorno = false;
            foreach (Universidad.EClases claseAux in i.clasesDelDia)
            {
                if (clase == claseAux)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }
    }
}

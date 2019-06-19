using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesRepasoSP
{
    public class Empleado
    {
        private string _nombre;
        private int _legajo;
        private float _sueldo;

        public event DelegadoSueldo LimiteSueldo;
        


        #region Propiedades
        public string Nombre
        {
            get
            {
                return this._nombre;
            }

            set
            {
                this._nombre = value;
            }
        }
        public int Legajo
        {
            get
            {
                return this._legajo;
            }

            set
            {
                this._legajo = value;
            }
        }

        public float Sueldo
        {
            get
            {
                return this._sueldo;
            }

            set
            {

                if (value > 12000)
                {
                    this.LimiteSueldo(this,value);
                }
                else
                {
                    this._sueldo = value;
                }
                
            }
        }
        #endregion

        public override string ToString()
        {
            return this._nombre + " " + this._legajo + " " + this._sueldo;

        }

        
    }
}

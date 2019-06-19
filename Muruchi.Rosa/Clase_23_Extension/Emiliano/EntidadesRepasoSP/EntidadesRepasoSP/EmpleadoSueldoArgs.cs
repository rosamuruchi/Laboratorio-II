using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesRepasoSP
{
    public class EmpleadoSueldoArgs
    {
        
        private float _sueldo;

        public event DelegadoSueldoMejoradoArgs LimiteSueldo;



        #region Propiedades
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
                    this.LimiteSueldo(this, value);
                }
                else
                {
                    this._sueldo = value;
                }

            }
        }
        #endregion

        
    }
}

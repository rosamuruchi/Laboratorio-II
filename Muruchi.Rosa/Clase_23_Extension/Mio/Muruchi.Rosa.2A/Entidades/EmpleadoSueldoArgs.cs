using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmpleadoSueldoArgs
    {
        private float _sueldo;
        //propiedad automatica
        public float Sueldo { get; set; }
        public event DelegadoSueldo LimiteSueldoArgs;
    }
}

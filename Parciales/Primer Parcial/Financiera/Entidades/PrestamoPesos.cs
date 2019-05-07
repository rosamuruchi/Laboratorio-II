using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos :Prestamo
    {
        private float _porcentajeInteres;

        public float Interes
        {
            get { return this._porcentajeInteres; }
        }

        public PrestamoPesos (Prestamo prestamo, float porcentajeInteres):this(prestamo.Monto,prestamo.Vencimiento,porcentajeInteres)
        {
 
        }
        public PrestamoPesos(float monto, DateTime vencimiento, float interes):base(monto,vencimiento)
        {
            this._porcentajeInteres = interes;
        }

        private float CalcularInteres()
        {
            return (this.Interes * this.Monto)/100;
        }
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            float dias = (float)(this.Vencimiento - nuevoVencimiento).TotalDays;
            this._porcentajeInteres += dias * (int)0.25;
            this.Vencimiento = nuevoVencimiento;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Monto:{0} - Vencimiento: {1}", base.Monto, base.Vencimiento);
            sb.AppendFormat("Interes: {0}", this.Interes);


            return sb.ToString();
        }

    }
}

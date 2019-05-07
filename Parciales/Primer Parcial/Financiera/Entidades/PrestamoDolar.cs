using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar :Prestamo
    {
        private PeriodicidadDePagos _periodicidad;

        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
            
        }
        public PeriodicidadDePagos Periodicidad
        {
            get
            {
                return this._periodicidad;
            }
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad) : this(prestamo.Monto, prestamo.Vencimiento, periodicidad)
        {

        }
        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad):base(monto,vencimiento)
        {
            this._periodicidad = periodicidad;
        }
        private float CalcularInteres()
        {
            float retorno=0;
            if (this.Periodicidad == PeriodicidadDePagos.Mensual)
            {
                retorno = 25;
            }
            else
            {
                if (this.Periodicidad == PeriodicidadDePagos.Bimestral)
                {
                    retorno = 35;
                }
                else
                {
                    if (this.Periodicidad == PeriodicidadDePagos.Trimestral)
                    {
                        retorno = 40;
                    }
                }
            }
            return retorno;
        }
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            float dias = (float)(this.Vencimiento - nuevoVencimiento).TotalDays;
            this._monto += (int)2.5 * dias;
            //this._porcentajeInteres += dias * (int)0.25;
            this.Vencimiento = nuevoVencimiento;

        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Monto:{0} - Vencimiento: {1}", base.Monto, base.Vencimiento);
            sb.AppendFormat("Periodicidad: {0}\n", this.Periodicidad);


            return sb.ToString();
        }
    }
}

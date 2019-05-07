using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    //public enum PeriodicidadDePagos { Mensual, Bimestral, Trimestral }
    //public enum TipoDePrestamo { Pesos, Dolares, Todos }


    public abstract class Prestamo
    {
        #region Atributos
        protected float _monto;
        protected DateTime _vencimiento;
        #endregion

        public float Monto
        {
            get { return this._monto; }
        }
        public DateTime Vencimiento
        {
            get
            {
                
                return this._vencimiento;
            }
            set
            {
                if (this._vencimiento > DateTime.Now)
                {
                    this._vencimiento = value;
                }
                else
                {
                    this._vencimiento = DateTime.Now;
                }
                
            }
        }
        public Prestamo(float monto, DateTime vencimiento)
        {
            this._monto = monto;
            this._vencimiento = vencimiento;
        }
        public virtual string Mostrar()
        {
            return this._monto.ToString() + "-" + this._vencimiento.ToString();
        }
        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            return DateTime.Compare(p1.Vencimiento, p2.Vencimiento); //ordena por fecha de vencimiento
        }
        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

    }
}

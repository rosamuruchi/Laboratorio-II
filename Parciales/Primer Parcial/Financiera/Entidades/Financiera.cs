using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;

namespace EntidadFinanciera
{
    public class Financiera
    {
        private string _razonSocial;
        private List<Prestamo> _ListaDePrestamos;

        public float InteresEnDolares
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Dolares);
            }
        }
        public float InteresEnPesos
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Pesos);
            }
        }
        public float InteresTotales
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Todos);
            }
        }
        public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return this._ListaDePrestamos;
            }

        }
        public string RazonSocial
        {
            get
            {
                return this._razonSocial;
            }
        }
            
        private Financiera()
        {
            this._ListaDePrestamos = new List<Prestamo>();
        }
        public Financiera (string razonSocial):this()
        {
            this._razonSocial = razonSocial;
        }
        public static string Mostrar (Financiera financiera)
        {
            return (string)financiera; //llama explicitamente
        }

        public void OrdenarPrestamos()
        {
            this.ListaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }
        private float CalcularInteresGanado(TipoDePrestamo tipoPrestamo)
        {
            float interesDolar=0;
            float interesPesos=0;
            float interesTotal=0;
            float retorno = 0;

            foreach (Prestamo p in this.ListaDePrestamos)
            {
                if(p is PrestamoPesos)
                {
                    interesPesos += ((PrestamoPesos)p).Interes;
                }
                if(p is PrestamoDolar)
                {
                    interesDolar += ((PrestamoDolar)p).Interes;
                }
                interesTotal += interesPesos + interesDolar;
            }

            switch(tipoPrestamo)
            {
                case TipoDePrestamo.Pesos:
                    retorno = interesPesos;
                    break;
                case TipoDePrestamo.Dolares:
                    retorno = interesDolar;
                    break;
                case TipoDePrestamo.Todos:
                    retorno = interesTotal;
                    break;
            }

            return retorno;
        }
        public static explicit operator string (Financiera financiera)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("RazonSocial: {0}\nInteres Totales Ganados: {1}\nInteresesPrestamos por Pesos: {2}\nInteresesPrestamos por Dolares: {3}\n", financiera.RazonSocial, financiera.InteresTotales, financiera.InteresEnPesos, financiera.InteresEnDolares);

            financiera.OrdenarPrestamos();
            foreach (Prestamo item in financiera.ListaDePrestamos)
            {
                sb.AppendLine(item.Mostrar());
            }

            return sb.ToString();
        }
        public static bool operator ==(Financiera financiera , Prestamo prestamo)
        {
            bool retorno = false;

            foreach(Prestamo p in financiera._ListaDePrestamos)
            {
                if(p==prestamo)
                {
                    retorno = true;
                    break;
                    /*if((PrestamoDolar)prestamo == (PrestamoDolar)p)
                    {
                        retorno = true;
                        break;
                    }
                    if ((PrestamoPesos)prestamo == (PrestamoPesos)p)
                    {
                        retorno = true;
                        break;
                    }*/
                }
            }
            return retorno;
        }
        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera==prestamo);
        }
        public static Financiera operator +(Financiera financiera, Prestamo prestamo)
        {
            if(financiera != prestamo)
            {
                financiera._ListaDePrestamos.Add(prestamo);
            }
            return financiera;
        }
    }
}

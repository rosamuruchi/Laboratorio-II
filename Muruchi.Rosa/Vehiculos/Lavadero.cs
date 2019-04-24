using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class Lavadero
    {
        private List<Vehiculo> _vehiculos;

        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;

        public string MiLavadero
        {
            get
            {
                return this.MostrarLavadero();

            }
        }

        private Lavadero(float pAuto, float pCamion, float pMoto)
        {
            this._precioAuto = pAuto;
            this._precioCamion = pCamion;
            this._precioMoto = pMoto;
        }

        public string MostrarLavadero()
        {
            string retorno = "";
            string cadenaVehiculos = "";
            retorno = this._precioAuto.ToString() + "-" + this._precioCamion.ToString() + "-" + this._precioMoto.ToString();

            foreach (Vehiculo vehiculo in this._vehiculos)
            {
                cadenaVehiculos = vehiculo.ToString(); //este llama a los tres vehiculos de mostrar()


                //if(vehiculo is Auto)
                //{
                //    cadenaVehiculos=((Auto)vehiculo).MostrarAuto();
                //}
                //else if( vehiculo is Camion)
                //{
                //    cadenaVehiculos = ((Camion)vehiculo).MostrarCamion();
                //}
                //else if( vehiculo is Moto)
                //{
                //    cadenaVehiculos = ((Moto)vehiculo).MostrarMoto();
                //}
            }

            return retorno + cadenaVehiculos;

        }

        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
        {
            bool retorno = false;
            foreach (Vehiculo v in lavadero._vehiculos)
            {
                if (v == vehiculo)
                {
                    retorno = true;
                    break;

                }
            }
            return retorno;

        }

        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
        {
            return !(lavadero == vehiculo);
        }
        public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero != vehiculo)
            {
                lavadero._vehiculos.Add(vehiculo);

            }
            return lavadero;
        }

        public static Lavadero operator - (Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero == vehiculo)
            {
                lavadero._vehiculos.Remove(vehiculo);

            }
            return lavadero;
        }
        public double MostrarTotalFacturado()
        {
            return this.MostrarTotalFacturado(EVehiculos.Auto) + this.MostrarTotalFacturado(EVehiculos.Camion) + this.MostrarTotalFacturado(EVehiculos.Moto);
        }

        public double MostrarTotalFacturado (EVehiculos vEnum)
        {
            double totalAuto=0;
            double totalCamion = 0;
            double totalMoto = 0;
            double totalRecaudacion = 0;

            foreach (Vehiculo v in this._vehiculos)
            {
                if(vEnum is EVehiculos.Auto)
                {
                    totalAuto++;
                }
                if (vEnum is EVehiculos.Camion)
                {
                    totalCamion++;
                }
                if(vEnum is EVehiculos.Moto)
                {
                    totalCamion++;
                }
            }

            if(vEnum == EVehiculos.Auto)
            {
                totalRecaudacion = totalAuto * this._precioAuto;
            }
            if(vEnum == EVehiculos.Camion)
            {
                totalRecaudacion = totalCamion * this._precioAuto;
            }
            if(vEnum == EVehiculos.Moto)
            {
                totalRecaudacion = totalMoto * this._precioMoto;
            }
            return totalRecaudacion;
        }


        public static int OrdenarVehiculosPorPatente (Vehiculo v1, Vehiculo v2)
        {
            int retorno = -1;
            if(string.Compare (v1.patente ,v2.patente) == 0)
            {
                retorno = 0;
            }
            else
            {
                if(string.Compare(v1.patente,v2.patente)>0)
                {
                    retorno = 1;
                }
            }
            return retorno;
        }
        
        public int OrdenarVehivulosPorMarca (Vehiculo v1, Vehiculo v2)
        {
            int retorno = -1;
            if (string.Compare(v1.patente, v2.patente) == 0)
            {
                retorno = 0;
            }
            else
            {
                if (string.Compare(v1.patente, v2.patente) > 0)
                {
                    retorno = 1;
                }
            }
            return retorno;

        }
    }
}

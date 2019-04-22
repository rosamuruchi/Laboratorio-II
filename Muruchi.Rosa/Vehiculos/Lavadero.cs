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

        public string MostrarLavadero ()
        {
            string retorno = "";
            string cadenaVehiculos= "";
            retorno = this._precioAuto.ToString() + "-" + this._precioCamion.ToString() + "-" + this._precioMoto.ToString();

            foreach(Vehiculo vehiculo in this._vehiculos )
            {
                if(vehiculo is Auto)
                {
                    cadenaVehiculos=((Auto)vehiculo).MostrarAuto();
                }
                else if( vehiculo is Camion)
                {
                    cadenaVehiculos = ((Camion)vehiculo).MostrarCamion();
                }
                else if( vehiculo is Moto)
                {
                    cadenaVehiculos = ((Moto)vehiculo).MostrarMoto();
                }
            }

            return retorno + cadenaVehiculos;

        }

        public static bool operator == (Lavadero lavadero, Vehiculo vehiculo)
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
        public static bool operator + (Lavadero lavadero, Vehiculo vehiculo)
        {

        }
        private int obtenerIndice()
        {
            int retorno = -1;
            int i = 0;
            if (this._vehiculos.Count != 0)
            {
                foreach (Vehiculo item in this._vehiculos)
                {
                    if (Equals(item, null))
                    {
                        retorno = i;
                        break;
                    }
                    /*if (i >= this.)
                    {
                        break;
                    }*/
                    i++;
                }
            }
            return retorno;
        }
    }
}

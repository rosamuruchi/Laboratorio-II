using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._06.Entidades
{
    public class Paleta
    {
        //private Tempera[] _temperas;
        private int _CantidadMaxima;

        private List <Tempera> _temperas;

        public List <Tempera> MisTemperas
        {
            get { return this._temperas; }
        }

        private Paleta ():this(5)
        {
        }
        private Paleta (int cant)
        {
            this._temperas = new List<Tempera> (cant);
            this._CantidadMaxima = cant;
            for (int i=0; i<this._CantidadMaxima; i++)
            {
                this._temperas.Insert(i, null);
            }
        }
        
        public static implicit operator Paleta (int cant)
        {
            return new Paleta(cant);
        }

        private string mostrar ()
        {
            string cadena = "";
            foreach (Tempera temp1 in this._temperas)
            {
                if((object)temp1!=null)
                {
                    cadena += Tempera.mostrar(temp1);
                }
                
            }
            return cadena;
        }
        public static explicit operator string (Paleta paleta)
        {
            return paleta.mostrar();
        }
        public static bool operator ==(Paleta paleta, Tempera tempera)
        {
            bool retorno = false;
            foreach (Tempera item in paleta.MisTemperas)
            {
                if(item==tempera)
                {
                    retorno = true;
                    break;

                }
            }
            return retorno;
        }
        public static bool operator !=(Paleta paleta, Tempera tempera)
        {
            return !(paleta == tempera);
        }
        public static Paleta operator + (Paleta paleta, Tempera tempera)
        {
            int lugar;
            if(paleta!= tempera)
            {
                lugar = paleta.obtenerIndice();
                if(lugar >=0 && lugar< paleta._CantidadMaxima)
                {
                    paleta._temperas.Insert(lugar, tempera);
                }
            }
            return paleta;
        }
        private int obtenerIndice()
        {
            int retorno = -1;
            int i=0;
            if(this._temperas.Count != 0)
            {
                foreach(Tempera item in this.MisTemperas)
                {
                    if(Equals (item , null))
                    {
                        retorno = i;
                        break;
                    }
                    if(i >= this._CantidadMaxima)
                    {
                        break;
                    }
                    i++;
                }
            }
            return retorno;
        }
    }
}

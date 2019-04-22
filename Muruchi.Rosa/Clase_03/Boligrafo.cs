using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class Boligrafo
    {
        static short cantidadTintaMaxima;
        private  ConsoleColor color;
        private  short tinta;


        public Boligrafo (short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        /*public bool Pintar (int gasto, out string dibujo)
        {
            return true;
        }*/

        public void Recargar()
        {

        }
        /*private void SetTinta (short tinta)
        {
            if(this.tinta>0)
            {
                this.tinta = tinta + 100;
            }
            else
            {
                if (this.tinta < 0)
                {
                    this.tinta = tinta - 100;
                }
                else
                {
                    this.tinta = tinta;
                }
            }
       

        }*/
    }
}

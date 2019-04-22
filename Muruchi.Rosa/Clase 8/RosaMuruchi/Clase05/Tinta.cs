using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipoTinta;

        public Tinta() : this(ConsoleColor.Black, ETipoTinta.comun)
        {
            //this._color = ConsoleColor.Black;
            //this._tipoTinta = ETipoTinta.comun; 
        }

        public Tinta(ConsoleColor c) : this(c, ETipoTinta.comun) //this(c,ETipoTinta.comun) tambien puede ser este
        {
            //this._color = c;
            //this._tipoTinta = ETipoTinta.comun;  llama a la de abajo 
        }

        public Tinta(ConsoleColor color, ETipoTinta tinta)
        {
            this._color = color;
            this._tipoTinta = tinta;
        }


        public static string mostrar(Tinta objeto)
        {
            return objeto.mostrar();
        }

        private string mostrar()
        {
            return this._color.ToString() + "-" + this._tipoTinta.ToString();
        }

        public static bool operator == (Tinta t1, Tinta t2)
        {
            Boolean rta = false;

            rta= t1._color == t2._color && t1._tipoTinta == t2._tipoTinta;

            return rta;
        }
        
        public static bool operator != (Tinta t1, Tinta t2)
        { 

            return !(t1==t2);
        }
                       



    }
}

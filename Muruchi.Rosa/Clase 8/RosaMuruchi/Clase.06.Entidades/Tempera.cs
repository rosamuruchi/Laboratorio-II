using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._06.Entidades
{
    public class Tempera
    {
        private ConsoleColor _color;
        private string _marca;
        private sbyte _cantidad;

        public ConsoleColor Color { get { return this._color; } set { this._color = value; } }
        public string Marca { get { return this._marca; } set { this._marca = value; } }

        public Tempera(ConsoleColor color, string marca, sbyte cant)
        {
            this._color = color;
            this._marca = marca;
            this._cantidad = cant;
        }

        private string mostrar()
        {
            return this._cantidad.ToString() + "-" + this._color.ToString() + "-" + this._marca.ToString();
        }

        public static string mostrar (Tempera temp1)
        {
            string ret = "";
            if (temp1 != null)
                ret = temp1.mostrar();
            return ret;
        }

        public static bool operator == (Tempera temp1, Tempera temp2)
        {
            bool retorno = false;
            if(Equals(temp1, null) && Equals(temp2, null))
            {
                retorno = true;
            }
            else
            {
                if(!Equals(temp1,null) && !Equals(temp2,null))
                {
                    if(temp1._color == temp2._color && temp1._marca == temp2._marca)
                    {
                        retorno = true;
                    }
                }
                else
                {
                    retorno = false;
                }
            }
            return  retorno;
        }
        public static bool operator != (Tempera temp1 , Tempera temp2)
        {
            return !(temp1 == temp2);
        }
        public static Tempera operator + (Tempera temp1 , sbyte num)
        {
            temp1._cantidad += num;
            return temp1;
        }
        public static Tempera operator + (Tempera temp1 , Tempera temp2)
        {
            if(temp1==temp2)
            {
                temp1._cantidad += temp2._cantidad;
            }
            return temp1;
        }
        public static implicit operator sbyte (Tempera temp1)
        {
            return temp1._cantidad;
        }
        
    }
}

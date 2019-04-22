using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase05;

namespace clase05.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta tintaUno = new Tinta();
            Tinta tintaDos = new Tinta(ConsoleColor.Blue);
            Tinta tintaTres = new Tinta(ConsoleColor.Green,ETipoTinta.China);
            Tinta tintaCuatro = new Tinta();
            Tinta tintaCinco = tintaUno;

            Console.WriteLine(Tinta.mostrar(tintaUno));
            Console.WriteLine(Tinta.mostrar(tintaDos));
            Console.WriteLine(Tinta.mostrar(tintaTres));

            /*if(tintaUno.Equals(tintaCinco)) //determina equals sin son iguales
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");
            }*/
            if(tintaUno==tintaDos)
            {
                Console.WriteLine("T1 y T2 son iguales");
            }
            else
            {
                Console.WriteLine("T1 y T2 No son iguales");
            }
            if (tintaTres != tintaDos)
            {
                Console.WriteLine("T3 y T2 no son iguales");
            }
            else
            {
                Console.WriteLine("T3 y T2 son iguales");
            }
            //////////////////////////////////////////////

            Pluma p1 = new Pluma("Bic",tintaUno,20);
            Pluma p2 = new Pluma();

            string s = (string)p1; //explicita (lo puedo ver)
            string s1 = p1; //implicita

            p2 = p1 + tintaUno;
            p1 = p1 + tintaUno;
            p1 += tintaUno;

            if (p1==tintaDos)
            {
                Console.WriteLine("Tienen la misma Tinta");
            }
            else
            {
                Console.WriteLine("No tienen la misma Tinta");
            }


            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class Sello
    {
        //atributos
        public static string mensaje;

        public static ConsoleColor color;

        //Metodos
        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }
        public static void Borrar()
        {
            Sello.mensaje = "";
        }
        public static void ImprimirEnColor()
        {

            Console.ForegroundColor = Sello.color;
            Console.WriteLine( Sello.Imprimir());
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        private static string ArmarFormatoMensaje()
        {
            string mensajeConFormato = "";
            int largoMensaje;
            //string saltoLinea = "\n";
            
            if(Sello.mensaje.Length>0)
            {
                largoMensaje = Sello.mensaje.Length + 2;
            }
            else
            {
                largoMensaje = 0;
            }
            for(int i=0; i<largoMensaje; i++)
            {
                mensajeConFormato += "*";
            }
            mensajeConFormato += "\n*" + Sello.mensaje + "*\n";
            for (int i = 0; i < largoMensaje; i++)
            {
                mensajeConFormato += "*";
            }

            return mensajeConFormato;
        }
    }
}

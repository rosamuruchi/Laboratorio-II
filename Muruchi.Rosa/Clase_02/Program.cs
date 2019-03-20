using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "Hola";
            Console.WriteLine(Sello.Imprimir());
            Sello.color = ConsoleColor.Green;
            Sello.ImprimirEnColor();
            Sello.Borrar();
            Console.ReadKey();

            Sello.mensaje = "Este es un mensaje Celeste ";
            Sello.color = ConsoleColor.Cyan;
            Sello.ImprimirEnColor();
            Console.ReadKey();

            Sello.mensaje = "Vuelvo al color original";
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();
        }
    }
}

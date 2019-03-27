using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_04.Entidades;

namespace Clase_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa cosaUno = new Cosa();
            Console.WriteLine(cosaUno.mostrar());
            Cosa cosaDos = new Cosa(5);
            Console.WriteLine(cosaDos.mostrar());
            Cosa cosaTres = new Cosa(55,DateTime.Now);
            Console.WriteLine(cosaTres.mostrar());
            Cosa cosaCuatro = new Cosa(525,DateTime.Now,"Mariano");
            Console.WriteLine(cosaCuatro.mostrar());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_BaseDeDatos;


namespace TestDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona(3, "juan", "dominguez", 33);
            AccesoDatos aD = new AccesoDatos();
            List<Persona> lista;
            lista = aD.TraerTodos();

            if(aD.AgregarPersona(p1))
            {
                
            }

            foreach(Persona item in lista)
            {
                Console.WriteLine(item.ToString());
                
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_BaseDeDatos;
using System.Data;
using System.Data.SqlClient;


namespace TestDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona(3, "juan", "dominguez", 33);
            Persona p2 = new Persona(5, "Ariel", "Urtubey", 19);
            DataTable dt2 = new DataTable();
            AccesoDatos aD = new AccesoDatos();
            /*List<Persona> lista;
            

            lista = aD.TraerTodos();

            foreach(Persona item in lista)
            {
                Console.WriteLine(item.ToString());
                
            }
            
            if (aD.AgregarPersona(p1))
            {
                Console.WriteLine("Se agrego persona!");
            }
            Console.ReadKey();
            if (aD.ModificarPersona(p2))
            {
                Console.WriteLine("Se modifico persona");

            }
            Console.ReadKey();
            if (aD.EliminarPersona(p1))
            {
                Console.WriteLine("Se elimino persona");

            }*/
            //archivos xml
            //DataTable dt = aD.TraerTablaPersona();
            /*
             * foreach(DataRow fila in dt.Rows)
            {
                Console.WriteLine(fila["id"]);//, fila["nombre"], fila["apellido"], fila[""]);
            }*/
            //dt.WriteXmlSchema("Personas_esquema.xml");

            //dt.WriteXml("Personas_Datos.xml");
            dt2.ReadXmlSchema("Personas_esquema.xml");
            //dt.ReadXml("Personas_Datos.xml");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Xml.Serialization;
using System.IO;

namespace TestEntidades
{
    public class Program
    {
        static void Main(string[] args)
        {
            Humano h1 = new Humano();
            Persona p1 = new Persona("Raul", "Gomez");
            Alumno a1 = new Alumno();
            Profesor prof1 = new Profesor();
            List<Humano> listaHumanos=new List<Humano>();
            h1.Dni = 55555;

            a1.apellido = "ger";
            a1.nombre = "juan";
            a1.Legajo = 23;

            prof1.nombre = "gustavo";
            prof1.apellido = "gomez";
            prof1.Dni = 233333;
            prof1.Titulo = "Profesor";

            bool SerializarAlumno(Alumno alumno)
            {
                bool retorno = false;

                try
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Alumno));
                    StreamWriter sw = new StreamWriter("D:\\pruebaSerializar.xml");

                    ser.Serialize(sw, alumno);
                    sw.Close();
                    retorno = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                return retorno;
            }
            Alumno DesearializarAlumno()
            {
                Alumno alumno = new Alumno();
                try
                {               
                    StreamReader sr = new StreamReader("D:\\pruebaSerializar.xml");
                    XmlSerializer ser = new XmlSerializer(typeof(Alumno));

                    alumno = (Alumno)ser.Deserialize(sr);
                    sr.Close();
                }
                catch (Exception e)
                {
                    throw e;
                    //Console.WriteLine(e.ToString());
                }
                return alumno;
            }
            SerializarAlumno(a1);
            DesearializarAlumno();

            /*using (StreamWriter sw = new StreamWriter("D:\\pruebaSerializar.xml"))
            {

            }*/
            
            bool SerializarLista(List<Humano> lista)
            {
                bool retorno = false;
                try
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Humano>));

                    StreamWriter sw = new StreamWriter("D:\\pruebaSerializarHumano.xml");

                    ser.Serialize(sw, lista);
                    sw.Close();
                    retorno = true;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.ToString());
                    Console.ReadKey();
                }
                return retorno;

            }
            if(SerializarLista(listaHumanos))
            {
                Console.WriteLine("Se pudo serializar el Humano");
            }
            else
            {
                Console.WriteLine("No se pudo serializar el Humano");

            }
            /*if (Serializarlista())
            {
                Console.WriteLine("Se pudo serializar el Profesor");
            }
            else
            {
                Console.WriteLine("No se pudo serializar el Profesor");
            }*/

            bool SerializarXML ( ISerializableXML o)
            {
                bool retorno = false;

                o.SerializarXML();

                return retorno;
            }
            
            Console.ReadKey();
        }
    }
}

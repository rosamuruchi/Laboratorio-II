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
            p1.Dni = 666666;
            a1.Dni = 777777;

            a1.apellido = "Gomez";
            a1.nombre = "juan";
            a1.Legajo = 23;

            prof1.nombre = "gustavo";
            prof1.apellido = "gomez";
            prof1.Dni = 233333;
            prof1.Titulo = "Profesor";

            listaHumanos.Add(a1);
            listaHumanos.Add(prof1);
            listaHumanos.Add(p1);
            listaHumanos.Add(h1);

            if(SerializarAlumno(a1))
            {
                Console.WriteLine("Se serializo Alumno");
            }
            else
            {
                Console.WriteLine("NO Se serializo Alumno");
            }

            Alumno a = Program.DesearializarAlumno();
            if (a != null)
            {
                string s = a.apellido + " " + a.nombre + " " + a.Legajo;
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("No se pudo deserializar");
            }



            if (Program.SerializarLista(listaHumanos))
            {
                Console.WriteLine("Se pudo serializar el Humano");
            }
            else
            {
                Console.WriteLine("No se pudo serializar el Humano");

            }
            List<Humano> lista2 = Program.DeserializarLista();

            if(a!=null)
            {
                foreach(Humano h in lista2)
                {
                    Console.WriteLine(h.Dni.ToString());
                }
            }
            else
            {
                Console.WriteLine("Error serializar Lista");
            }

            /*bool SerializarXML2555 ( ISerializableXML o)
            {
                bool retorno = false;

                o.SerializarXML();

                return retorno;
            }*/
            
            Console.ReadKey();
        }
        public static bool SerializarAlumno(Alumno alumno)
        {
            bool retorno = false;

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Alumno));
                using (StreamWriter sw = new StreamWriter("D:\\pruebaSerializar.xml"))
                {
                    ser.Serialize(sw, alumno);
                }

                //sw.Close();
                retorno = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return retorno;
        }
        public static Alumno DesearializarAlumno()
        {
            Alumno alumno = new Alumno();
            try
            {

                XmlSerializer ser = new XmlSerializer(typeof(Alumno));
                using (StreamReader sr = new StreamReader("D:\\pruebaSerializar.xml"))
                {
                    alumno = (Alumno)ser.Deserialize(sr);
                }

                //sr.Close();
            }
            catch (Exception e)
            {
                throw e;
                //Console.WriteLine(e.ToString());
            }
            return alumno;
        }



        /*public static bool SerializarLista(List<Humano> lista)
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
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.ReadKey();
            }
            return retorno;
        }*/
        public static bool SerializarHumano(Humano humano)
        {
            bool retorno = false;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Humano));
                using (StreamWriter streamWriter = new StreamWriter(@"D:\SerializarHumano.XML"))
                {
                    xmlSerializer.Serialize(streamWriter, humano);
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return retorno;
        }
        public static Humano DeserializarHumano()
        {
            Humano humano;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Humano));
                using (StreamReader streamReader = new StreamReader(@"D:\SerializarHumano.XML"))
                {
                    humano = (Humano)xmlSerializer.Deserialize(streamReader);
                }
            }
            catch (Exception e)
            {
                throw e;
                //return null;
            }
            return humano;
        }
        public static bool SerializarLista(List<Humano> lista)
        {
            bool retorno = false;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Humano>));
                using (StreamWriter streamWriter = new StreamWriter(@"D:\SerializarLista.XML"))
                {
                    xmlSerializer.Serialize(streamWriter, lista);
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return retorno;
        }
        public static List<Humano> DeserializarLista()
        {
            List<Humano> lista;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Humano>));
                using (StreamReader streamReader = new StreamReader(@"D:\SerializarLista.XML"))
                {
                    lista = (List<Humano>)xmlSerializer.Deserialize(streamReader);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return lista;
        }
    }
}

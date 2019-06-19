using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.IO;

namespace TestEntidades
{
    public class Program
    {
        static void Main(string[] args)
        {
            Empleado e = new Empleado();
            e._limiteSueldo += new DelegadoSueldo(LimiteSueldoEmpleado);
            e._limiteSueldo += new DelegadoSueldo(GuardarLog);
            e.Nombre = "Maria";
            e.Lejago = 12;
            e.Sueldo = 13000;

            Console.WriteLine(e.ToString());
            Console.ReadLine();
        }
        public static void LimiteSueldoEmpleado(Empleado e, float f)
        {
            string cadena = "Empleado: " + e.Nombre + "\nLejago: " + e.Lejago.ToString() + "\nAsig.Sueldo: " + f.ToString() + "\n";
            Console.WriteLine(cadena);
            
        }
        
        /// <summary>
        /// Guarda en un archivo de texto : fecha hora, minuto, segundo
        /// </summary>
        public static void GuardarLog (Empleado e, float f)
        {
            string direccion = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\\";
            string archivo = "incidentes.log";
            try
            {
                using (StreamWriter sw = new StreamWriter(direccion + archivo, true))
                {
                    sw.WriteLine(DateTime.Now);
                    sw.WriteLine(e.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }         
        }
    }
}

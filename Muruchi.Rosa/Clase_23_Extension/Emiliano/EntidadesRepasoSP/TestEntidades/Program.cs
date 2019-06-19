using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EntidadesRepasoSP;

namespace TestEntidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            EmpleadoMejorado empleadoMejorado = new EmpleadoMejorado();
            EmpleadoSueldoArgs empleadoSueldoArgs = new EmpleadoSueldoArgs();
            empleado.LimiteSueldo += new DelegadoSueldo(LimiteSueldoEmpleado);
            empleado.LimiteSueldo += new DelegadoSueldo(GuardarLog);

            empleado.Nombre = "Emiliano";
            empleado.Legajo = 32022;
            empleado.Sueldo = 12500;

        }

        public static void LimiteSueldoEmpleado(Empleado empleado, float sueldo)
        {
            Console.WriteLine(empleado.ToString());
            Console.WriteLine(sueldo);
        }

        public static void GuardarLog(Empleado empleado, float sueldo)
        {
            try
            {
                StreamWriter fichero = new StreamWriter("log");
                fichero.WriteLine(empleado.ToString());
                fichero.WriteLine(DateTime.Today);
                fichero.Close();
                
            }
            catch (Exception)
            {

                throw;
            }
           
        }

    }
}

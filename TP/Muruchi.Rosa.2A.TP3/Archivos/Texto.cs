using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        string direccion = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
        public bool Guardar(string archivo, string datos)
        {
            bool retorno = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(this.direccion + archivo, false))
                {
                    sw.WriteLine(datos);
                }
                retorno = true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return retorno;
        }
        public bool Leer(string archivo, out string datos)
        {
            bool retorno = false;
            try
            {
                using (StreamReader sr = new StreamReader(this.direccion + archivo))
                {
                    datos = sr.ReadToEnd();
                }
                retorno = true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return retorno;
        }
    }
}

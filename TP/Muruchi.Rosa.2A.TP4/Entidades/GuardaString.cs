using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardaString
    {
        /// <summary>
        /// Guarda archivo de Texto en el Escritorio de la pc
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="archivo"></param>
        /// <returns>Devuelve true si pudo guardar, caso contrario false</returns>
        public static bool Guardar (this string texto, string archivo)
        {
            bool retorno = false;
            string destino = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + archivo;

            using (StreamWriter sw = new StreamWriter(destino, true))
            {
                sw.WriteLine(texto);
                retorno = true;
            }

            return retorno;
        }
    }
}

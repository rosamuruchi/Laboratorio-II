using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        string direccion = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
        /// <summary>
        /// metodo de la interfaz IArchivo 
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>true si pudo ser guardado, caso contrario false</returns>
        public bool Guardar(string archivo, T datos)
        {
            bool retorno = false;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                XmlTextWriter textWriter = new XmlTextWriter(this.direccion + archivo, Encoding.UTF8);
                xmlSerializer.Serialize(textWriter, datos);
                textWriter.Close();
                retorno = true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return retorno;
        }
        /// <summary>
        /// metodo de la interfaz IArchivo
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>true si pudo ser leido, caso contrario false</returns>
        public bool Leer(string archivo, out T datos)
        {
            bool retorno = false;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                XmlTextReader textReader = new XmlTextReader(this.direccion);// + archivo);
                datos = (T)xmlSerializer.Deserialize(textReader);
                textReader.Close();
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

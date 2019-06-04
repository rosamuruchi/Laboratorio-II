using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Humano))]
    public class Humano :ISerializableXML
    {
        private int _dni;

        public int Dni
        {
            get
            {
                return this._dni;
            }
            set
            {
                this._dni = value;
            }
        }
        public override string ToString()
        {
            return this._dni.ToString();
        }
        public bool SerializarXML()
        {
            return false;
        }
        public bool DeserializarXML()
        {
            return false;
        }
    }
}

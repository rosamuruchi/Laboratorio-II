using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades_Clase14
{
    class ErrorParserException : Exception
    {
        public ErrorParserException(string message) : base(message)
        {
        }
    }
}

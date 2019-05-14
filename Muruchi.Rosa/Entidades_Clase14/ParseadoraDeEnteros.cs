using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades_Clase14
{
    public static class ParseadoraDeEnteros
    {

        public static bool TryParse (string s, out int n )
        {
            bool retorno = false;
            n = 0;
            try
            {
                retorno = TryParse(s,out n);
            }
            catch (FormatException e)
            {
                Console.WriteLine("... por error de formato");
                Console.WriteLine(e.Message);
                throw new ErrorParserException("El string no podrá ser convertido");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("... por tamaño del dato");
                Console.WriteLine(e.Message);
                throw new ErrorParserException("El string no podrá ser convertido");
            }

            return retorno;
        }

        public static int Parse(string s)
        {
            int retorno=-1;
            try
            {
                retorno = Int32.Parse(s);
            }
            catch (FormatException e)
            {
                Console.WriteLine("... por error de formato");
                Console.WriteLine(e.Message);
                throw new ErrorParserException("El string no podrá ser convertido");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("... por tamaño del dato");
                Console.WriteLine(e.Message);
                throw new ErrorParserException("El string no podrá ser convertido");
            }
            return retorno;
        }
    }
}

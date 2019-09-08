using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        private string SetNumero
        {
            set { this.numero = ValidarNumero(value); }
        }

        //Constructores
        public Numero() : this(0)
        {

        }
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero(string strNumero)//:this(double.Parse(strNumero))
        {
            this.numero = double.Parse(strNumero);
        }
        //
        public double ValidarNumero(string strNumero)
        {
            double retorno = 0;
            double num;
            if (double.TryParse(strNumero, out num) == true)
            {
                retorno = num;
            }
            return retorno;
        }
        public static string BinarioDecimal(string binario)
        {
            int[] numeroCad = new int[binario.Length];
            string msj = "";
            double numero = 0;
            bool flag = true;
            int i;
            for (i = 0; i < binario.Length; i++)
            {
                numeroCad[i] = (int)char.GetNumericValue(binario[i]);
                if (numeroCad[i] != 0 && numeroCad[i] != 1)
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                for (i = 0; i < binario.Length; i++)
                {
                    numero += (numeroCad[i] * Math.Pow(2, binario.Length - i - 1));
                }
                msj = numero.ToString();
            }
            else
            {
                msj = "Valor inválido";
            }

            return msj;
        }
        public static string DecimalBinario(double numero)
        {
            int numeroAux = (int)numero;
            string binario = "";
            while (numeroAux > 0)
            {
                binario += (numeroAux % 2).ToString();
                numeroAux = numeroAux / 2;
            }
            char[] charArray = binario.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string DecimalBinario(string numero)
        {
            string msj;
            double numeroDouble;
            if (double.TryParse(numero, out numeroDouble))
            {
                msj = DecimalBinario(numeroDouble);
            }
            else
            {
                msj = "Valor inválido";
            }
            return msj;
        }

        //Sobrecargas
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = double.MinValue;
            if (n2.numero != 0)
            {
                retorno = n1.numero / n2.numero;
            }
            return retorno;
        }
    }
}

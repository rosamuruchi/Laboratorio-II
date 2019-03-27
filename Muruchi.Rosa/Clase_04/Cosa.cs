using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04.Entidades
{
    public class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;

        public Cosa ()
        {
            this.entero = 10;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;

        }
        public Cosa(int numero):this()
        {
            this.entero = numero;
        }
        public Cosa(int numero, DateTime dia) : this(numero)
        {
            //this.entero = numero;
            this.fecha = dia;
        }
        public Cosa (int numero, DateTime dia, string palabra): this(numero,dia)
        {
            this.cadena = palabra;
        }

        public string mostrar()
        {
            return this.entero.ToString() + "-" + this.cadena.ToString() + "-" + this.fecha.ToString();
        }
        public static string  mostrar(Cosa objeto)
        {
            return objeto.mostrar();
        }
        public void establecerValor (int valor)
        {
            this.entero = valor;
        }
        public void establecerValor(string palabra)
        {
            this.cadena = palabra;
        }
        public void establecerValor(DateTime dia)
        {
            this.fecha = dia;
        }
    }
}

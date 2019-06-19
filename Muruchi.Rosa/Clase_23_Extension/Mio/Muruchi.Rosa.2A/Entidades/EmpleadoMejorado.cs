﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmpleadoMejorado
    {
        private string _nombre;
        private int _lejago;
        private float _sueldo;

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public int Lejago
        {
            get { return this._lejago; }
            set { this._lejago = value; }
        }
        public float Sueldo
        {
            get { return this._sueldo; }
            set
            {
                if (value > 12000)
                {
                    EmpleadoSueldoArgs e = new EmpleadoSueldoArgs();
                    e.Sueldo = value;
                    this._limiteSueldo(this, e);
                }
                else
                {
                    this._sueldo = value;
                }
            }
        }
        public override string ToString()
        {
            return this.Nombre + " " + this.Lejago.ToString() + " " + this.Sueldo.ToString() + "\n";
        }
        //eventos
        public event DelSueldo _limiteSueldo;
    }
}

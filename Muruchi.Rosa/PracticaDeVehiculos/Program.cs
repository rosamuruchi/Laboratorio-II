﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos;

namespace PracticaDeVehiculos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("auto1",3,EMarca.Ferrari,5);
            Moto moto = new Moto("moto1",2,EMarca.Honda,40);
            Camion camion = new Camion("camion1",5,EMarca.Ford,400);

            /*auto.cantidadRuedas = 4;
            auto.cantidadAsientos = 5;
            auto.marca = EMarca.Renault;
            auto.patente = "452PGF";

            moto.patente = "123ABC";
            moto.marca = EMarca.Zanella;
            moto.cantidadRuedas = 2;
            moto.cilindrada = 500;

            camion.patente = "WWW444";
            camion.marca = EMarca.Scania;
            camion.cantidadRuedas = 10;
            camion.tara = 123;*/

            Console.WriteLine("PATENTE-MARCA-CANT.RUEDAS-DEMAS");
            Console.WriteLine(auto.MostrarAuto());
            Console.WriteLine(camion.MostrarCamion());
            Console.WriteLine(moto.MostrarMoto());
            Console.ReadKey();

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_POO.Models
{
    internal class Samsung : Smartphone
    {
        public Samsung(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Samsung");
        }
    }
}

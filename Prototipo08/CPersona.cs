﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo08
{
    class CPersona : IPrototipo
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }

        public CPersona(string pNombre, int pEdad)
        {
            nombre = pNombre;
            edad = pEdad;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", nombre, edad);
        }

        public object Clonar()
        {
            CPersona clon = new CPersona(nombre, edad);

            return clon;
        }
    }
}

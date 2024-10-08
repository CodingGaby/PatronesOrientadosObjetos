﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Componente04
{
    class CCompuesto<T> : IComponente<T>
    {
        List<IComponente<T>> elementos;

        public T Nombre { get; set; }
        public double Promedio { get; set; }

        public CCompuesto(T pNombre)
        {
            Nombre = pNombre;
            elementos = new List<IComponente<T>>();
        }

        public void Adicionar(IComponente<T> pElemento)
        {
            elementos.Add(pElemento);
        }

        public IComponente<T> Borrar(T pElemento)
        {
            IComponente<T> elemento = this.Buscar(pElemento);
            if (elemento != null)
            {
                elementos.Remove(elemento);
            }
            return this;
        }

        public IComponente<T> Buscar(T pElemento)
        {
            if (Nombre.Equals(pElemento))
                return this;

            IComponente<T> encontrado = null;
            foreach (IComponente<T> elemento in elementos)
            {
                encontrado = elemento.Buscar(pElemento);
                if (encontrado != null)
                    break;
            }
            return encontrado;
        }

        public string Mostrar(int pProfundidad)
        {
            StringBuilder infoElemento = new StringBuilder(new String('-', pProfundidad));
            infoElemento.Append("Compuesto: " + Nombre + " elementos: " + elementos.Count + " Promedio: " + CalcularPromedio() + "\r\n");

            foreach (IComponente<T> elemento in elementos)
                infoElemento.Append(elemento.Mostrar(pProfundidad + 1));

            return infoElemento.ToString();
        }

        public double CalcularPromedio()
        {
            if (elementos.Count == 0)
                return Promedio;

            double suma = 0;
            foreach (IComponente<T> elemento in elementos)
            {
                suma += elemento.CalcularPromedio();
            }
            return suma / elementos.Count;
        }
    }
}

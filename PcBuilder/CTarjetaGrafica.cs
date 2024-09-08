using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuilder
{
    /// Decorador concreto que agrega una tarjeta gráfica a la PC.
    ///
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 06/09/2024
    /// Versión: 1.0.0
    /// Modificación: 06/09/2024
    public class TarjetaGrafica : ComponenteDecorator
    {
        public TarjetaGrafica(ComponentePC componente) : base(componente) { }

        public override string ObtenerDescripcion() { return componente.ObtenerDescripcion() + ", con Tarjeta Gráfica"; }

        public override double ObtenerPrecio() { return componente.ObtenerPrecio() + 200.00; }
    }
}

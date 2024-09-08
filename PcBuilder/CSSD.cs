using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuilder
{
    /// Decorador concreto que agrega un SSD a la PC.
    ///
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 06/09/2024
    /// Versión: 1.0.0
    /// Modificación: 06/09/2024
    public class SSD : ComponenteDecorator
    {
        public SSD(ComponentePC componente) : base(componente) { }

        public override string ObtenerDescripcion() { return componente.ObtenerDescripcion() + ", con SSD"; }

        public override double ObtenerPrecio() { return componente.ObtenerPrecio() + 100.00; }
    }

}

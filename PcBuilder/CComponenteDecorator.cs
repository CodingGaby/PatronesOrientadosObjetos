using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuilder
{
    /// Decorador abstracto para componentes adicionales de la PC.
    ///
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 06/09/2024
    /// Versión: 1.0.0
    /// Modificación: 06/09/2024
    public abstract class ComponenteDecorator : ComponentePC
    {
        protected ComponentePC componente; //!&lt; Componente al que se le agregarán características adicionales.

        public ComponenteDecorator(ComponentePC componente)
        {
            this.componente = componente;
        }

        public override string ObtenerDescripcion() { return componente.ObtenerDescripcion(); }

        public override double ObtenerPrecio() { return componente.ObtenerPrecio(); }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuilder
{
    /// Clase base de la PC que se puede decorar con componentes adicionales.
    ///
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 06/09/2024
    /// Versión: 1.0.0
    /// Modificación: 06/09/2024
    public abstract class ComponentePC
    {
        /// Obtiene la descripción del componente.
        public abstract string ObtenerDescripcion();

        /// Obtiene el precio del componente.
        public abstract double ObtenerPrecio();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuilder
{
    /// Clase concreta de una PC básica.
    ///
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 06/09/2024
    /// Versión: 1.0.0
    /// Modificación: 06/09/2024
    public class Basico : ComponentePC
    {
        public override string ObtenerDescripcion() { return "PC básica"; }

        public override double ObtenerPrecio() { return 300.00; }
    }
}

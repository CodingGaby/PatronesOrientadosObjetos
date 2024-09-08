using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuilder
{
    /// Clase que representa una GPU utilizando el patrón Bridge.
    ///
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 06/09/2024
    /// Versión: 1.0.0
    /// Modificación: 06/09/2024
    public class GPU : Componente
    {
        public GPU(IMarca marca) : base(marca) { }

        public override void MostrarDetalles()
        {
            // Mostramos la marca de la GPU
            Console.WriteLine($"GPU de la marca {marca.GetNombre()}");
        }
    }
}

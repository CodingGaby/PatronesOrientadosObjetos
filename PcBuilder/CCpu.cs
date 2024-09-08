using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuilder
{
    /// Clase que representa una CPU utilizando el patrón Bridge.
    ///
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 06/09/2024
    /// Versión: 1.0.0
    /// Modificación: 06/09/2024
    public class CPU : Componente
    {
        public CPU(IMarca marca) : base(marca) { }

        public override void MostrarDetalles()
        {
            // Mostramos la marca del CPU
            Console.WriteLine($"CPU de la marca {marca.GetNombre()}");
        }
    }
}

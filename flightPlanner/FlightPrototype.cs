using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flightPlanner
{
    /// Clase base para el patrón Prototype, usada para clonar vuelos.
    /// Autor: Jorge Gabriel García Osorio
    /// Fecha: 04/10/2024
    /// Versión: 1.0.0.1
    /// Modificación: N/A
    public abstract class FlightPrototype
    {
        public string FlightNumber { get; set; } //!< Número de vuelo
        public DestinationFlyweight Destination { get; set; } //!< Destino del vuelo

        /// Método abstracto para clonar el vuelo
        /// Autor: Jorge Gabriel García Osorio
        /// Fecha: 04/10/2024
        /// Versión: 1.0.0.1
        /// Modificación: N/A
        public abstract FlightPrototype Clone();
    }
}

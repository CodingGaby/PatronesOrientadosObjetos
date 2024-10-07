using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flightPlanner
{
    /// Clase concreta que implementa el patrón Prototype.
    /// Autor: Jorge Gabriel García Osorio
    /// Fecha: 04/10/2024
    /// Versión: 1.0.0.1
    /// Modificación: N/A
    public class Flight : FlightPrototype
    {
        /// Constructor de la clase Flight
        /// Autor: Jorge Gabriel García Osorio
        /// Fecha: 04/10/2024
        /// Versión: 1.0.0.1
        /// Modificación: N/A
        /// <param name="flightNumber"> Número de vuelo </param>
        /// <param name="destination"> Destino del vuelo </param>
        public Flight(string flightNumber, DestinationFlyweight destination)
        {
            this.FlightNumber = flightNumber;
            this.Destination = destination;
        }

        /// Método para clonar el vuelo
        /// Autor: Jorge Gabriel García Osorio
        /// Fecha: 04/10/2024
        /// Versión: 1.0.0.1
        /// Modificación: N/A
        public override FlightPrototype Clone()
        {
            return (FlightPrototype)this.MemberwiseClone(); //!< Clonación superficial
        }

        /// Método para mostrar la información del vuelo
        /// Autor: Jorge Gabriel García Osorio
        /// Fecha: 04/10/2024
        /// Versión: 1.0.0.1
        /// Modificación: N/A
        public void DisplayFlightInfo()
        {
            Destination.DisplayInfo(FlightNumber); //!< Mostrar información del destino y número de vuelo
        }
    }
}

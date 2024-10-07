using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flightPlanner
{
    /// Esta clase se encarga de gestionar destinos de vuelos, utilizando el patrón Flyweight para reutilizar información
    /// Autor: Jorge Gabriel García Osorio
    /// Fecha: 04/10/2024
    /// Versión: 1.0.0.1
    /// Modificación: N/A
    public class DestinationFlyweight
    {
        private string city; //!< Aquí guardamos la ciudad del destino
        private string country; //!< Aquí guardamos el país del destino

        /// Constructor de la clase DestinationFlyweight
        /// Autor: Jorge Gabriel García Osorio
        /// Fecha: 04/10/2024
        /// Versión: 1.0.0.1
        /// Modificación: N/A
        /// <param name="city"> Nombre de la ciudad </param>
        /// <param name="country"> Nombre del país </param>
        public DestinationFlyweight(string city, string country)
        {
            this.city = city;
            this.country = country;
        }

        /// Método para mostrar la información del vuelo
        /// Autor: Jorge Gabriel García Osorio
        /// Fecha: 04/10/2024
        /// Versión: 1.0.0.1
        /// Modificación: N/A
        /// <param name="flightNumber"> Número de vuelo </param>
        public void DisplayInfo(string flightNumber)
        {
            Console.WriteLine($"Flight {flightNumber} is going to {city}, {country}.");
        }
    }

}

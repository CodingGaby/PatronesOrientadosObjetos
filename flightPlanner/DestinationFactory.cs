using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flightPlanner
{
    /// Esta clase crea y reutiliza instancias de destinos de vuelo, aplicando el patrón Flyweight
    /// Autor: Jorge Gabriel García Osorio
    /// Fecha: 04/10/2024
    /// Versión: 1.0.0.1
    /// Modificación: N/A
    public class DestinationFactory
    {
        private Dictionary<string, DestinationFlyweight> destinations = new Dictionary<string, DestinationFlyweight>(); //!< Diccionario para almacenar destinos compartidos

        /// Método para obtener o crear un destino
        /// Autor: Jorge Gabriel García Osorio
        /// Fecha: 04/10/2024
        /// Versión: 1.0.0.1
        /// Modificación: N/A
        /// <param name="city"> Nombre de la ciudad </param>
        /// <param name="country"> Nombre del país </param>
        /// <returns> Instancia de DestinationFlyweight </returns>
        public DestinationFlyweight GetDestination(string city, string country)
        {
            string key = $"{city}_{country}";

            if (!destinations.ContainsKey(key))
            {
                destinations[key] = new DestinationFlyweight(city, country); //!< Creación del destino si no existe
            }

            return destinations[key];
        }
    }
}

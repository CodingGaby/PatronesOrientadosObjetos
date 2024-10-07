using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelBooking2._0
{
    /// Esta clase representa el tipo de habitación dentro del sistema (Flyweight).
    /// Autor: Angel Esau Flores Bonilla
    /// Fecha: 04-10-2024
    /// Versión: 1.0.0
    public class TipoHabitacion
    {
        public string Nombre { get; } //!< Nombre del tipo de habitación.

        /// Constructor para definir un tipo de habitación.
        /// <param name="nombre">Nombre del tipo de habitación</param>
        public TipoHabitacion(string nombre)
        {
            Nombre = nombre;
        }

        /// Muestra los detalles del tipo de habitación.
        public void MostrarDetalles()
        {
            Console.WriteLine($"Tipo de habitación: {Nombre}");
        }
    }
}

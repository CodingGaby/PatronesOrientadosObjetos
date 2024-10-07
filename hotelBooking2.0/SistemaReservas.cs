using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelBooking2._0
{
    /// Esta clase actúa como fachada para simplificar el acceso al sistema de reservas.
    /// Autor: Angel Esau Flores Bonilla
    /// Fecha: 04-10-2024
    /// Versión: 1.0.0
    public class SistemaReservas
    {
        private GrupoHabitaciones _grupoHabitaciones = new GrupoHabitaciones(); //!< Grupo que contiene todas las habitaciones.
        private TipoHabitacionFlyweight _flyweightFactory = new TipoHabitacionFlyweight(); //!< Flyweight para gestionar los tipos de habitación.

        /// Agrega una nueva habitación al sistema de reservas.
        /// <param name="numero">Número de la habitación</param>
        /// <param name="tipo">Tipo de habitación</param>
        /// <param name="precio">Precio de la habitación</param>
        public void AgregarHabitacion(string numero, string tipo, double precio)
        {
            var tipoHabitacion = _flyweightFactory.ObtenerTipo(tipo);
            var habitacion = new Habitacion(numero, tipo, precio);
            _grupoHabitaciones.Agregar(habitacion); //!< Agrega la nueva habitación al grupo.
        }

        /// Muestra todas las habitaciones registradas en el sistema.
        public void MostrarHabitaciones()
        {
            _grupoHabitaciones.MostrarDetalles();
        }
    }
}

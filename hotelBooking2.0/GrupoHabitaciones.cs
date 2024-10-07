using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelBooking2._0
{

    /// Esta clase representa un grupo de habitaciones, utilizando el patrón compuesto.
    /// Autor: Angel Esau Flores Bonilla
    /// Fecha: 04-10-2024
    /// Versión: 1.0.0
    public class GrupoHabitaciones : IReserva
    {
        private List<IReserva> _habitaciones = new List<IReserva>(); //!< Lista de habitaciones o grupos de habitaciones.

        /// Agrega una habitación o grupo al grupo de habitaciones.
        /// <param name="habitacion">Componente de habitación a agregar</param>
        public void Agregar(IReserva habitacion)
        {
            _habitaciones.Add(habitacion);
        }

        /// Elimina una habitación o grupo del grupo de habitaciones.
        /// <param name="habitacion">Componente de habitación a eliminar</param>
        public void Eliminar(IReserva habitacion)
        {
            _habitaciones.Remove(habitacion);
        }

        /// Muestra los detalles de todas las habitaciones en el grupo.
        public void MostrarDetalles()
        {
            foreach (var habitacion in _habitaciones)
            {
                habitacion.MostrarDetalles();
            }
        }
    }
}

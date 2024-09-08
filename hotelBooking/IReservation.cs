using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelBooking
{
    /// Esta clase define la interfaz para las reservas de habitaciones
    /// Autor: Angel Esau Flores Bonilla
    /// Fecha: 04-09-2024
    /// Versión: 1.0.0.0
    public interface IReservation
    {
        /// Reserva una habitación
        /// Autor: Angel Esau Flores Bonilla
        /// Fecha: 04-09-2024
        /// Versión: 1.0.0.0
        /// <param name="roomType">Tipo de habitación a reservar</param>
        void Reserve(string roomType);
    }
}

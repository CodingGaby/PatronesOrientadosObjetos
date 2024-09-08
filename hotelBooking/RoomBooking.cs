using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelBooking
{
    /// Clase que maneja la reserva de habitaciones de forma directa
    /// Autor: Angel Esau Flores Bonilla
    /// Fecha: 04-09-2024
    /// Versión: 1.0.0.0
    public class RoomBooking : IRoomBooking
    {
        /// Reserva una habitación
        /// Autor: Angel Esau Flores Bonilla
        /// Fecha: 04-09-2024
        /// Versión: 1.0.0.0
        /// <param name="roomType">Tipo de habitación a reservar</param>
        public void Book(string roomType)
        {
            // Proceso de reserva
            Console.WriteLine($"{roomType} has been successfully booked.");
        }
    }
}

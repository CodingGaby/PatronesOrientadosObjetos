using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelBooking
{
    /// Clase concreta que representa una habitación doble
    /// Autor: Angel Esau Flores Bonilla
    /// Fecha: 04-09-2024
    /// Versión: 1.0.0.0
    public class DoubleRoom : Room
    {
        /// Constructor de la clase DoubleRoom
        /// Autor: Angel Esau Flores Bonilla
        /// Fecha: 04-09-2024
        /// Versión: 1.0.0.0
        /// <param name="reservation">Objeto que implementa la lógica de reserva</param>
        public DoubleRoom(IReservation reservation) : base(reservation) { }

        /// Realiza la reserva de una habitación doble
        /// Autor: Angel Esau Flores Bonilla
        /// Fecha: 04-09-2024
        /// Versión: 1.0.0.0
        public override void BookRoom()
        {
            // Llama a la lógica de reserva específica
            reservation.Reserve("Double Room");
        }
    }
}

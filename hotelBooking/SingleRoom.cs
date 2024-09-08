using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelBooking
{
    /// Clase concreta que representa una habitación individual
    /// Autor: Angel Esau Flores Bonilla
    /// Fecha: 04-09-2024
    /// Versión: 1.0.0.0
    public class SingleRoom : Room
    {
        /// Constructor de la clase SingleRoom
        /// Autor: Angel Esau Flores Bonilla
        /// Fecha: 04-09-2024
        /// Versión: 1.0.0.0
        /// <param name="reservation">Objeto que implementa la lógica de reserva</param>
        public SingleRoom(IReservation reservation) : base(reservation) { }

        /// Realiza la reserva de una habitación individual
        /// Autor: Angel Esau Flores Bonilla
        /// Fecha: 04-09-2024
        /// Versión: 1.0.0.0
        public override void BookRoom()
        {
            // Llama a la lógica de reserva específica
            reservation.Reserve("Single Room");
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelBooking
{
    /// Clase abstracta que representa una habitación en el sistema
    /// Autor: Angel Esau Flores Bonilla
    /// Fecha: 04-09-2024
    /// Versión: 1.0.0.0
    public abstract class Room
    {
        /// Objeto para manejar el proceso de reservación
        /// Autor: Angel Esau Flores Bonilla
        /// Fecha: 04-09-2024
        protected IReservation reservation; //!< Aquí guardamos el objeto de reserva

        /// Constructor de la clase Room
        /// Autor: Angel Esau Flores Bonilla
        /// Fecha: 04-09-2024
        /// Versión: 1.0.0.0
        /// <param name="reservation">Objeto que implementa la lógica de reserva</param>
        public Room(IReservation reservation)
        {
            this.reservation = reservation;
        }

        /// Método abstracto para realizar la reserva de una habitación
        /// Autor: Angel Esau Flores Bonilla
        /// Fecha: 04-09-2024
        /// Versión: 1.0.0.0
        public abstract void BookRoom();
    }
}

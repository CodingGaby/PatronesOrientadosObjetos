using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelBooking
{
    /// Implementación concreta de la reserva con tarjeta de crédito
    /// Autor: Angel Esau Flores Bonilla
    /// Fecha: 04-09-2024
    /// Versión: 1.0.0.0
    public class CreditCardReservation : IReservation
    {
        /// Reserva una habitación usando tarjeta de crédito
        /// Autor: Angel Esau Flores Bonilla
        /// Fecha: 04-09-2024
        /// Versión: 1.0.0.0
        /// <param name="roomType">Tipo de habitación a reservar</param>
        public void Reserve(string roomType)
        {
            // Realiza la reserva usando una tarjeta de crédito
            Console.WriteLine($"{roomType} booked with Credit Card.");
        }
    }

    /// Implementación concreta de la reserva con PayPal
    /// Autor: Angel Esau Flores Bonilla
    /// Fecha: 04-09-2024
    /// Versión: 1.0.0.0
    public class PayPalReservation : IReservation
    {
        /// Reserva una habitación usando PayPal
        /// Autor: Angel Esau Flores Bonilla
        /// Fecha: 04-09-2024
        /// Versión: 1.0.0.0
        /// <param name="roomType">Tipo de habitación a reservar</param>
        public void Reserve(string roomType)
        {
            // Realiza la reserva usando PayPal
            Console.WriteLine($"{roomType} booked with PayPal.");
        }
    }
}

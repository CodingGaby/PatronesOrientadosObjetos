using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelBooking
{
    /// Interfaz que define el proceso de reserva de habitaciones
    /// Autor: Angel Esau Flores Bonilla
    /// Fecha: 04-09-2024
    /// Versión: 1.0.0.0
    public interface IRoomBooking
    {
        /// Método para reservar una habitación
        /// Autor: Angel Esau Flores Bonilla
        /// Fecha: 04-09-2024
        /// Versión: 1.0.0.0
        /// <param name="roomType">Tipo de habitación a reservar</param>
        void Book(string roomType);
    }
}

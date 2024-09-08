using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelBooking
{
    /// Clase que actúa como proxy para el sistema de reservas de habitaciones
    /// Autor: Angel Esau Flores Bonilla
    /// Fecha: 04-09-2024
    /// Versión: 1.0.0.0
    public class RoomBookingProxy : IRoomBooking
    {
        private RoomBooking roomBooking; //!< Aquí guardamos el objeto real de reservas
        private bool isAuthenticated; //!< Indica si el usuario está autenticado

        /// Constructor de la clase RoomBookingProxy
        /// Autor: Angel Esau Flores Bonilla
        /// Fecha: 04-09-2024
        /// Versión: 1.0.0.0
        /// <param name="isAuthenticated">Estado de autenticación del usuario</param>
        public RoomBookingProxy(bool isAuthenticated)
        {
            this.roomBooking = new RoomBooking(); //!< Inicializa la instancia de RoomBooking
            this.isAuthenticated = isAuthenticated; //!< Establece si el usuario está autenticado
        }

        /// Método que permite reservar una habitación si el usuario está autenticado
        /// Autor: Angel Esau Flores Bonilla
        /// Fecha: 04-09-2024
        /// Versión: 1.0.0.0
        /// <param name="roomType">Tipo de habitación a reservar</param>
        public void Book(string roomType)
        {
            if (isAuthenticated)
            {
                // El usuario está autenticado, puede reservar
                roomBooking.Book(roomType);
            }
            else
            {
                // El acceso es denegado por falta de autenticación
                Console.WriteLine("Access denied. Please authenticate.");
            }
        }
    }
}

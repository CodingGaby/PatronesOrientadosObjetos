using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelBooking2._0
{
    /// Esta clase representa una habitación individual dentro del sistema.
    /// Autor: Angel Esau Flores Bonilla
    /// Fecha: 04-10-2024
    /// Versión: 1.0.0
    class Habitacion : IReserva
    {
        private string Numero; // Número de la habitación
        private string Tipo; // Tipo de habitación (Ej: Sencilla, Doble)
        private double Precio; // Precio de la habitación

        /// Constructor para crear una nueva habitación.
        /// <param name="numero">Número de la habitación</param>
        /// <param name="tipo">Tipo de la habitación</param>
        /// <param name="precio">Precio de la habitación</param>
        public Habitacion(string numero, string tipo, double precio)
        {
            Numero = numero;
            Tipo = tipo;
            Precio = precio;
        }

        /// Muestra los detalles de la habitación como número, tipo y precio.
        public void MostrarDetalles()
        {
            Console.WriteLine($"Habitación {Numero} - Tipo: {Tipo} - Precio: {Precio:C}");
        }
    }
}

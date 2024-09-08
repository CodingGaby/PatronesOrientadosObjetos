using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelBooking
{
    /// Interfaz que define la estrategia de descuento
    /// Autor: Angel Esau Flores Bonilla
    /// Fecha: 04-09-2024
    /// Versión: 1.0.0.0
    public interface IDiscountStrategy
    {
        /// Método para obtener el descuento aplicado al precio
        /// Autor: Angel Esau Flores Bonilla
        /// Fecha: 04-09-2024
        /// Versión: 1.0.0.0
        /// <param name="price">Precio original</param>
        /// <returns>Precio con el descuento aplicado</returns>
        decimal GetDiscount(decimal price);
    }
}

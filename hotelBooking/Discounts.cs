using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelBooking
{
    /// Estrategia de descuentos: sin descuento
    /// Autor: Angel Esau Flores Bonilla
    /// Fecha: 04-09-2024
    /// Versión: 1.0.0.0
    public class NoDiscountStrategy : IDiscountStrategy
    {
        /// Retorna el precio sin aplicar descuento
        /// Autor: Angel Esau Flores Bonilla
        /// Fecha: 04-09-2024
        /// Versión: 1.0.0.0
        /// <param name="price">Precio original de la habitación</param>
        /// <returns>El mismo precio, sin descuentos</returns>
        public decimal GetDiscount(decimal price)
        {
            return price;
        }
    }

    /// Estrategia de descuentos: descuento estacional
    /// Autor: Angel Esau Flores Bonilla
    /// Fecha: 04-09-2024
    /// Versión: 1.0.0.0
    public class SeasonalDiscountStrategy : IDiscountStrategy
    {
        /// Aplica un descuento del 10% al precio original
        /// Autor: Angel Esau Flores Bonilla
        /// Fecha: 04-09-2024
        /// Versión: 1.0.0.0
        /// <param name="price">Precio original de la habitación</param>
        /// <returns>Precio con el descuento del 10% aplicado</returns>
        public decimal GetDiscount(decimal price)
        {
            return price * 0.9m; // Aplica un 10% de descuento
        }
    }
}

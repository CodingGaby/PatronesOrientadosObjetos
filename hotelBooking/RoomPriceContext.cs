using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelBooking
{
    /// Clase de contexto que utiliza la estrategia de descuentos
    /// Autor: Angel Esau Flores Bonilla
    /// Fecha: 04-09-2024
    /// Versión: 1.0.0.0
    public class RoomPriceContext
    {
        private IDiscountStrategy discountStrategy; //!< Estrategia de descuentos

        /// Constructor de la clase RoomPriceContext
        /// Autor: Angel Esau Flores Bonilla
        /// Fecha: 04-09-2024
        /// Versión: 1.0.0.0
        /// <param name="discountStrategy">Estrategia de descuentos a aplicar</param>
        public RoomPriceContext(IDiscountStrategy discountStrategy)
        {
            this.discountStrategy = discountStrategy; //!< Inicializa la estrategia de descuento
        }

        /// Aplica el descuento al precio de la habitación
        /// Autor: Angel Esau Flores Bonilla
        /// Fecha: 04-09-2024
        /// Versión: 1.0.0.0
        /// <param name="price">Precio original de la habitación</param>
        /// <returns>Precio con el descuento aplicado</returns>
        public decimal ApplyDiscount(decimal price)
        {
            // Aplica la estrategia de descuentos
            return discountStrategy.GetDiscount(price);
        }
    }
}

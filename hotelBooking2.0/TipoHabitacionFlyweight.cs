using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelBooking2._0
{
    /// Esta clase gestiona la creación de tipos de habitación para evitar la duplicación (Flyweight).
    /// Autor: Angel Esau Flores Bonilla
    /// Fecha: 04-10-2024
    /// Versión: 1.0.0
    public class TipoHabitacionFlyweight
    {
        private Dictionary<string, TipoHabitacion> _tiposHabitacion = new Dictionary<string, TipoHabitacion>(); //!< Mapa que almacena tipos de habitaciones ya creados.

        /// Obtiene un tipo de habitación, reutilizando instancias existentes si ya fueron creadas.
        /// <param name="tipo">Nombre del tipo de habitación</param>
        /// <returns>Instancia de tipo de habitación reutilizada o nueva</returns>
        public Object ObtenerTipo(string tipo)
        {
            if (!_tiposHabitacion.ContainsKey(tipo))
            {
                _tiposHabitacion[tipo] = new TipoHabitacion(tipo); //!< Crea una nueva instancia de tipo de habitación si no existe.
            }

            return _tiposHabitacion[tipo];
        }
    }
}

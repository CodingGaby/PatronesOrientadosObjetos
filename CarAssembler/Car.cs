using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssembler
{
    /// Esta clase representa un coche con diferentes componentes
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 04/11/2024
    /// Versión: 1.0.0.1
    /// Modificación: 04/11/2024
    public class Car
    {
        public string Engine { get; set; } //!< Motor del coche
        public string Interior { get; set; } //!< Interior del coche
        public List<string> Extras { get; set; } = new List<string>(); //!< Lista de extras del coche

        /// Devuelve los detalles del coche
        /// <returns>Detalles del coche en formato string</returns>
        public string GetDetails()
        {
            return $"Motor: {Engine}\nInterior: {Interior}\nExtras: {string.Join(", ", Extras)}\n";
        }
    }
}
 
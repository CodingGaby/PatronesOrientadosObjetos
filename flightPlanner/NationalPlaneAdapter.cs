using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flightPlanner
{
    /// Clase adaptador para aviones nacionales que necesitan ser usados en vuelos internacionales.
    /// Implementa el patrón Adaptador.
    /// Autor: Jorge Gabriel García Osorio
    /// Fecha: 04/10/2024
    /// Versión: 1.0.0.1
    /// Modificación: N/A
    public class NationalPlaneAdapter : IInternationalPlane
    {
        private INationalPlane nationalPlane; //!< Instancia del avión nacional

        /// Constructor de la clase NationalPlaneAdapter
        /// Autor: Jorge Gabriel García Osorio
        /// Fecha: 04/10/2024
        /// Versión: 1.0.0.1
        /// Modificación: N/A
        /// <param name="plane"> Instancia del avión nacional que será adaptado </param>
        public NationalPlaneAdapter(INationalPlane plane)
        {
            this.nationalPlane = plane;
        }

        /// Método para adaptar un vuelo nacional a uno internacional
        /// Autor: Jorge Gabriel García Osorio
        /// Fecha: 04/10/2024
        /// Versión: 1.0.0.1
        /// Modificación: N/A
        /// <param name="flightNumber"> Número de vuelo </param>
        public void FlyInternational(string flightNumber)
        {
            nationalPlane.FlyNational(flightNumber); //!< Adaptación de la funcionalidad de vuelo nacional
        }
    }
}

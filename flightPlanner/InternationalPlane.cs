using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flightPlanner
{
    /// Esta clase representa un avión internacional que realiza vuelos fuera del país.
    /// Autor: Jorge Gabriel García Osorio
    /// Fecha: 04/10/2024
    /// Versión: 1.0.0.1
    /// Modificación: N/A
    public class InternationalPlane : IInternationalPlane
    {
        /// Método para simular un vuelo internacional
        /// Autor: Jorge Gabriel García Osorio
        /// Fecha: 04/10/2024
        /// Versión: 1.0.0.1
        /// Modificación: N/A
        /// <param name="flightNumber"> Número de vuelo </param>
        public void FlyInternational(string flightNumber)
        {
            Console.WriteLine($"Flight {flightNumber} is flying internationally.");
        }
    }
}

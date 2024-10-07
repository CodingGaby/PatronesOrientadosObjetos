using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flightPlanner
{
    /// Esta clase representa un avión nacional que solo vuela dentro del país.
    /// Autor: Jorge Gabriel García Osorio
    /// Fecha: 04/10/2024
    /// Versión: 1.0.0.1
    /// Modificación: N/A
    public class NationalPlane : INationalPlane
    {
        /// Método para simular un vuelo nacional
        /// Autor: Jorge Gabriel García Osorio
        /// Fecha: 04/10/2024
        /// Versión: 1.0.0.1
        /// Modificación: N/A
        /// <param name="flightNumber"> Número de vuelo </param>
        public void FlyNational(string flightNumber)
        {
            Console.WriteLine($"Flight {flightNumber} is flying domestically.");
        }
    }
}

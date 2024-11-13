using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssembler
{
    /// Interfaz para construir coches
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 04/11/2024
    /// Versión: 1.0.0.1
    /// Modificación: 04/11/2024
    public interface ICarBuilder
    {
        void BuildEngine(); //!< Construye el motor del coche
        void BuildInterior(); //!< Construye el interior del coche
        void BuildExtras(); //!< Añade extras al coche
        Car GetCar(); //!< Devuelve el coche construido
    }
}

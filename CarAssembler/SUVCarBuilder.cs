using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssembler
{
    /// Builder concreto para coches SUV
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 04/11/2024
    /// Versión: 1.0.0.1
    /// Modificación: 04/11/2024
    public class SUVCarBuilder : ICarBuilder
    {
        private Car _car = new Car(); //!< Instancia de coche en construcción

        public void BuildEngine() => _car.Engine = "V6 3.5L"; //!< Asigna el motor para el SUV
        public void BuildInterior() => _car.Interior = "Cuero estándar y acabados de madera"; //!< Asigna el interior para el SUV
        public void BuildExtras() => _car.Extras.AddRange(new List<string> { "Sistema de navegación", "Sensores de estacionamiento", "Portaequipajes" }); //!< Añade extras al SUV

        public Car GetCar() => _car; //!< Devuelve el coche construido
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssembler
{
    /// Builder concreto para coches deportivos
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 04/11/2024
    /// Versión: 1.0.0.1
    /// Modificación: 04/11/2024
    public class SportsCarBuilder : ICarBuilder
    {
        private Car _car = new Car(); //!< Instancia de coche en construcción

        public void BuildEngine() => _car.Engine = "V8 Twin Turbo 4.0L"; //!< Asigna el motor deportivo
        public void BuildInterior() => _car.Interior = "Cuero premium y acabados en fibra de carbono"; //!< Asigna el interior deportivo
        public void BuildExtras() => _car.Extras.AddRange(new List<string> { "Sistema de sonido Bose", "Asientos con calefacción", "Spoiler trasero" }); //!< Añade extras al coche

        public Car GetCar() => _car; //!< Devuelve el coche construido
    }
}

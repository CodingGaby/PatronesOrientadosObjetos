using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssembler
{
    /// Fábrica concreta para crear coches SUV
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 04/11/2024
    /// Versión: 1.0.0.1
    /// Modificación: 04/11/2024
    public class SUVCarFactory : ICarFactory
    {
        public ICarBuilder CreateCarBuilder() => new SUVCarBuilder(); //!< Devuelve un builder de coches SUV
    }
}
 
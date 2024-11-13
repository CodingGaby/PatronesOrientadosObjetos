using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssembler
{
    /// Fábrica concreta para crear coches deportivos
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 04/11/2024
    /// Versión: 1.0.0.1
    /// Modificación: 04/11/2024
    public class SportsCarFactory : ICarFactory
    {
        public ICarBuilder CreateCarBuilder() => new SportsCarBuilder(); //!< Devuelve un builder de coches deportivos
    }
}

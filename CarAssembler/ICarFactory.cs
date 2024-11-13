using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssembler
{
    /// Fábrica abstracta para la creación de builders de coches
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 04/11/2024
    /// Versión: 1.0.0.1
    /// Modificación: 04/11/2024
    public interface ICarFactory
    {
        ICarBuilder CreateCarBuilder(); //!< Crea y devuelve un builder de coche
    }

}
 
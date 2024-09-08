using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuilder
{
    /// Clase que implementa la marca Intel.
    ///
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 06/09/2024
    /// Versión: 1.0.0
    /// Modificación: 06/09/2024
    public class Intel : IMarca
    {
        public string GetNombre()
        {
            return "Intel";
        }
    }

    /// Clase que implementa la marca AMD.
    ///
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 06/09/2024
    /// Versión: 1.0.0
    /// Modificación: 06/09/2024
    public class AMD : IMarca
    {
        public string GetNombre()
        {
            return "AMD";
        }
    }

}

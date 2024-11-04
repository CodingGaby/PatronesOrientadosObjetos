using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton10._1
{
    class TareaFactory
    {
        public static Tarea CrearTarea(string tipo, string nombre)
        {
            if (tipo.ToLower() == "simple") return new TareaSimple { Nombre = nombre };
            if (tipo.ToLower() == "compuesta") return new TareaCompuesta { Nombre = nombre };
            
            return null;
        }
    }
}

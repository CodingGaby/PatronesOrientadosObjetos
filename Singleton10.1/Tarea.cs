using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton10._1
{
    abstract class Tarea
    {
        public string Nombre { get; set; }
        public abstract void Ejecutar();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton10._1
{
    class TareaSimple : Tarea
    {
        public override void Ejecutar()
        {
            Console.WriteLine($"Ejecutando tarea: {Nombre}");
        }
    }

}

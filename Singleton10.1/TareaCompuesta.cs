using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton10._1
{
    class TareaCompuesta : Tarea
    {
        private List<Tarea> subtareas = new List<Tarea>();

        public void AgregarSubtarea(Tarea tarea)
        {
            subtareas.Add(tarea);
        }

        public void EliminarSubtarea(Tarea tarea)
        {
            subtareas.Remove(tarea);
        }

        public override void Ejecutar()
        {
            Console.WriteLine($"Ejecutando tarea compuesta: {Nombre}");
            foreach (var tarea in subtareas)
            {
                tarea.Ejecutar();
            }
        }
    }
}

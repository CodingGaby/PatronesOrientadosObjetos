using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton10._1
{
    class TaskManager
    {
        private static TaskManager instancia;

        private TaskManager() { }

        public static TaskManager ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new TaskManager();
                Console.WriteLine("TaskManager creado.");
            }
            return instancia;
        }

        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine($"[TaskManager]: {mensaje}");
        }
    }
}

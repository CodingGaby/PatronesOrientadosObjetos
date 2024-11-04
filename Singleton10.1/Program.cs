using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton: obtenemos la instancia del TaskManager
            TaskManager manager = TaskManager.ObtenerInstancia();
            manager.MostrarMensaje("Iniciando el sistema de tareas...");

            // Creamos tareas usando el Factory Method
            Tarea tarea1 = TareaFactory.CrearTarea("simple", "Configurar servidor");
            Tarea tarea2 = TareaFactory.CrearTarea("simple", "Diseñar interfaz");

            TareaCompuesta proyecto = (TareaCompuesta)TareaFactory.CrearTarea("compuesta", "Proyecto Web");
            proyecto.AgregarSubtarea(tarea1);
            proyecto.AgregarSubtarea(tarea2);

            // Ejecutamos la tarea compuesta
            proyecto.Ejecutar();

            // Mostramos que sigue siendo la misma instancia del Singleton
            TaskManager otroManager = TaskManager.ObtenerInstancia();
            otroManager.MostrarMensaje("Sistema finalizado.");

            Console.ReadKey();
        }
    }
}

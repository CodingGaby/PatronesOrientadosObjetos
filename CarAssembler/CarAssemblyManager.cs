using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarAssembler
{
    /// Esta clase se encarga de gestionar el ensamblaje de automóviles utilizando un patrón Singleton
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 04/11/2024
    /// Versión: 1.0.0.1
    /// Modificación: 04/11/2024
    public class CarAssemblyManager
    {
        private static CarAssemblyManager _instance; //!< Instancia única del gestor de ensamblaje
        private static readonly object _lock = new object(); //!< Objeto para bloquear el acceso a la instancia
        private readonly List<Car> _assembledCars = new List<Car>(); //!< Lista de coches ensamblados

        /// Constructor privado para evitar la creación de instancias externas
        private CarAssemblyManager() { }

        /// Obtiene la instancia única del gestor de ensamblaje
        /// <returns>Instancia de CarAssemblyManager</returns>
        public static CarAssemblyManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new CarAssemblyManager();
                    }
                    return _instance;
                }
            }
        }

        /// Ensambla un coche utilizando el builder proporcionado
        /// <param name="builder">Builder de coche</param>
        public void AssembleCar(ICarBuilder builder)
        {
            // Construye las partes del coche en orden
            builder.BuildEngine();
            builder.BuildInterior();
            builder.BuildExtras();

            Car car = builder.GetCar();
            _assembledCars.Add(car); //!< Agrega el coche ensamblado a la lista
            Console.WriteLine("Ensamblaje completado:\n" + car.GetDetails());
        }

        /// Muestra todos los coches ensamblados hasta el momento
        public void ShowAllAssembledCars()
        {
            Console.WriteLine("\nListado de coches ensamblados:");
            foreach (var car in _assembledCars)
            {
                Console.WriteLine(car.GetDetails()); //!< Imprime los detalles de cada coche ensamblado
            }
        }
    }
}

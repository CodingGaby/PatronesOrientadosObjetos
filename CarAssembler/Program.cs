using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssembler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarAssemblyManager assemblyManager = CarAssemblyManager.Instance;

            // Ensamblaje de un coche deportivo
            ICarFactory sportsCarFactory = new SportsCarFactory();
            ICarBuilder sportsCarBuilder = sportsCarFactory.CreateCarBuilder();
            assemblyManager.AssembleCar(sportsCarBuilder);

            // Ensamblaje de un coche SUV
            ICarFactory suvCarFactory = new SUVCarFactory();
            ICarBuilder suvCarBuilder = suvCarFactory.CreateCarBuilder();
            assemblyManager.AssembleCar(suvCarBuilder);

            // Mostrar todos los coches ensamblados
            assemblyManager.ShowAllAssembledCars();

            Console.ReadKey();
        }
    }
}

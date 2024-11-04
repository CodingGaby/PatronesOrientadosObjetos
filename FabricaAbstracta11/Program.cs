using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstracta11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFabrica miFabrica;

            Console.WriteLine("Selecciona el tipo de fábrica:");
            Console.WriteLine("1) Fábrica Química");
            Console.WriteLine("2) Fábrica Natural");
            Console.WriteLine("3) Fábrica Personalizada (Singleton)");
            string seleccionFabrica = Console.ReadLine();

            switch (seleccionFabrica)
            {
                case "1":
                    miFabrica = new FabricaQuimica();
                    break;
                case "2":
                    miFabrica = new FabricaNatural();
                    break;
                case "3":
                    miFabrica = FabricaPersonalizada.ObtenerInstancia();
                    break;
                default:
                    Console.WriteLine("Opción no válida, se usará la Fábrica Química.");
                    miFabrica = new FabricaQuimica();
                    break;
            }

            miFabrica.crearProductos();

            IProductoLeche miLeche = miFabrica.obtenerProductoLeche;
            IProductoSaborizante miSabor = miFabrica.obtenerSabor;

            Console.WriteLine("\nTu malteada es de {0} y {1}.", miLeche.obtenDatos(), miSabor.informacion());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuilder
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Bridge Pattern
            Console.WriteLine("=== Bridge Pattern ===");

            // Creamos un CPU de la marca Intel
            Componente cpu = new CPU(new Intel());

            // Creamos una GPU de la marca AMD
            Componente gpu = new GPU(new AMD());

            // Mostramos los detalles de los componentes
            cpu.MostrarDetalles();
            gpu.MostrarDetalles();

            // Proxy Pattern
            Console.WriteLine("\n=== Proxy Pattern ===");

            // Autenticamos el usuario para la compra
            ICompra tienda = new TiendaProxy("admin", "1234");

            // Intentamos comprar un componente
            tienda.ComprarComponente("CPU Intel");

            // Decorator Pattern
            Console.WriteLine("\n=== Decorator Pattern ===");

            // Creamos una PC básica
            ComponentePC pcBasica = new Basico();

            // Agregamos un SSD a la PC
            ComponentePC pcConSSD = new SSD(pcBasica);

            // Agregamos una tarjeta gráfica a la PC
            ComponentePC pcFull = new TarjetaGrafica(pcConSSD);

            // Mostramos la descripción y precio final de la PC completa
            Console.WriteLine($"{pcFull.ObtenerDescripcion()} - Precio: ${pcFull.ObtenerPrecio()}");

            Console.ReadKey();
        }
    }
}

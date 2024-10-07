using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelBooking2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sistemaReservas = new SistemaReservas();

            // Agregamos habitaciones al sistema
            sistemaReservas.AgregarHabitacion("101", "Sencilla", 1000);
            sistemaReservas.AgregarHabitacion("102", "Doble", 1500);
            sistemaReservas.AgregarHabitacion("103", "Sencilla", 1000);

            // Mostramos las habitaciones
            sistemaReservas.MostrarHabitaciones();

            Console.ReadKey();
        }
    }
}

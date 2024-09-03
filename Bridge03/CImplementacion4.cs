using System;
using System.Collections.Generic;

namespace Bridge03
{
    class CImplementacion4 : IBridge
    {
        private const double IVA = 0.16; // 16% de IVA

        public void MostrarTotales(Dictionary<string, double> pProductos)
        {
            double total = 0;
            double totalComida = 0;
            double totalMedicamentos = 0;
            double totalDeportes = 0;
            int cantidad = 0;

            foreach (KeyValuePair<string, double> p in pProductos)
            {
                double precioConIVA = p.Key[0] == 'M' ? p.Value : p.Value + (p.Value * IVA);
                total += precioConIVA;

                if (p.Key[0] == 'C')
                    totalComida += precioConIVA;
                if (p.Key[0] == 'M')
                    totalMedicamentos += p.Value; // Sin IVA
                if (p.Key[0] == 'D')
                    totalDeportes += precioConIVA;

                cantidad++;
            }

            Console.WriteLine("El total de comida es ${0}, {1}% del total", totalComida, (totalComida / total) * 100);
            Console.WriteLine("El total de medicamentos es ${0}, {1}% del total", totalMedicamentos, (totalMedicamentos / total) * 100);
            Console.WriteLine("El total de deportes es ${0}, {1}% del total", totalDeportes, (totalDeportes / total) * 100);
            Console.WriteLine("El total de {0} productos es ${1}", cantidad, total);
        }

        public void ListarProductos(Dictionary<string, double> pProductos)
        {
            // Comida
            Console.WriteLine("\nProductos de Comida:");
            foreach (KeyValuePair<string, double> p in pProductos)
            {
                if (p.Key[0] == 'C')
                {
                    double precioConIVA = p.Value + (p.Value * IVA);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} - ${1} (Precio con IVA: ${2})", p.Key, p.Value, precioConIVA);
                }
            }
            Console.ResetColor();

            // Medicamentos
            Console.WriteLine("\nProductos de Medicamentos:");
            foreach (KeyValuePair<string, double> p in pProductos)
            {
                if (p.Key[0] == 'M')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("{0} - ${1}", p.Key, p.Value);
                }
            }
            Console.ResetColor();

            // Deportes
            Console.WriteLine("\nProductos de Deportes:");
            foreach (KeyValuePair<string, double> p in pProductos)
            {
                if (p.Key[0] == 'D')
                {
                    double precioConIVA = p.Value + (p.Value * IVA);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} - ${1} (Precio con IVA: ${2})", p.Key, p.Value, precioConIVA);
                }
            }

            Console.ResetColor();
        }
    }
}

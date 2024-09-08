using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuilder
{
    /// Clase que representa la tienda que permite comprar componentes.
    ///
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 06/09/2024
    /// Versión: 1.0.0
    /// Modificación: 06/09/2024
    public class Tienda : ICompra
    {
        public void ComprarComponente(string componente)
        {
            // Compra exitosa del componente
            Console.WriteLine($"Compra realizada para: {componente}");
        }
    }
}

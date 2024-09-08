using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuilder
{
    /// Interfaz para realizar compras.
    ///
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 06/09/2024
    /// Versión: 1.0.0
    /// Modificación: 06/09/2024
    public interface ICompra
    {
        /// Método para realizar la compra de un componente.
        /// <param name="componente">Nombre del componente a comprar.</param>
        void ComprarComponente(string componente);
    }

}

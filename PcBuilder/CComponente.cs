using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuilder
{
    /// Esta clase representa un componente de PC abstracto.
    ///
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 06/09/2024
    /// Versión: 1.0.0
    /// Modificación: 06/09/2024
    public abstract class Componente
    {
        protected IMarca marca; //!&lt; Marca del componente.

        /// Constructor que inicializa la marca del componente.
        /// <param name="marca">Interfaz que define la marca del componente.</param>
        public Componente(IMarca marca)
        {
            this.marca = marca;
        }

        /// Método abstracto para mostrar los detalles del componente.
        public abstract void MostrarDetalles();
    }
}

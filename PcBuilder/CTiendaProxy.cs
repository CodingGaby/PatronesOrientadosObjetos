using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuilder
{
    /// Proxy que autentica al usuario antes de realizar una compra.
    ///
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 06/09/2024
    /// Versión: 1.0.0
    /// Modificación: 06/09/2024
    public class TiendaProxy : ICompra
    {
        private Tienda tienda = new Tienda(); //!&lt; Referencia a la tienda real.
        private string usuario; //!&lt; Nombre del usuario.
        private string contrasena; //!&lt; Contraseña del usuario.

        public TiendaProxy(string usuario, string contrasena)
        {
            this.usuario = usuario;
            this.contrasena = contrasena;
        }

        public void ComprarComponente(string componente)
        {
            if (Autenticar())
            {
                // Si la autenticación es exitosa, realiza la compra
                tienda.ComprarComponente(componente);
            }
            else
            {
                // Fallo en la autenticación
                Console.WriteLine("Autenticación fallida. No se puede realizar la compra.");
            }
        }

        /// Método privado que autentica al usuario.
        /// <returns>True si la autenticación es exitosa, false en caso contrario.</returns>
        private bool Autenticar()
        {
            // Simulación de autenticación básica
            return usuario == "admin" && contrasena == "1234";
        }
    }
}

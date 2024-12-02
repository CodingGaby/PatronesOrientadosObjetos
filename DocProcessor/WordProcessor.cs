using System;

namespace DocProcessor
{
    /// Procesador concreto para documentos Word.
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 29/11/2024
    /// Versión: 1.0.0.0
    /// Modificación: 29/11/2024
    public class WordProcessor : DocumentProcessor
    {
        protected override void LoadDocument()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cargando documento Word...");
        }

        protected override void ParseDocument()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Analizando contenido del documento Word...");
        }

        protected override void SaveDocument()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Guardando cambios en el documento Word...");
        }
    }
}
